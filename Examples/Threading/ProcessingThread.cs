using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace ThreadingExample
{
    /// <summary>
    /// Example of how to thread something...hint hint hint.
    /// </summary>
    public class ExampleThreadedClass
    {
        Capture m_camera; 

        #region Members
        /// <summary>
        /// Object for synchronizing
        /// </summary>
        private object m_lockObject;
        /// <summary>
        /// The last data acquired from the camera.
        /// </summary>
        private Image<Bgr, Byte> m_lastData;
        /// <summary>
        /// Processing thread.
        /// </summary>
        private Thread m_thread;
        /// <summary>
        /// Flag indicating whether the thread is running.
        /// </summary>
        private bool m_isProcessing;
        /// <summary>
        /// Flag indicating whether the processing should capture data.
        /// </summary>
        private bool m_isRunning;
        /// <summary>
        /// Helps synchronize threads thread event.
        /// </summary>
        private ManualResetEvent m_waitEvent;
        #endregion

        #region Events
        /// <summary>
        /// Fired when data is ready.        
        /// </summary>
        public event EventHandler<ExampleEventArgs> DataCaptured;
        /// <summary>
        /// Fired when the processing is started.
        /// </summary>
        public event EventHandler ThreadStarted;
        /// <summary>
        /// Fired when the processing is stopped.
        /// </summary>
        public event EventHandler ThreadStopped;
        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public ExampleThreadedClass()
        {
            

            Name        = "Example threaded class";
            m_lastData  = null;

            m_camera = new Capture();

            /// 
            /// This is a manual reset event, its a way to synchronize between threads
            /// You could also look into just using BackgroundWorkerThreads, but I do it the old fashion way...
            /// 
            m_waitEvent = new ManualResetEvent(false);

            m_isProcessing = true;
            m_isRunning = false;

            // This is used to prevent deadlocks, thread safe way like a mutex.
            m_lockObject = new object();

            // All initialization code goes here...
            SetupThread();
        }

        #region Threading
        /// <summary>
        /// Sets up and starts the processing thread.
        /// </summary>
        private void SetupThread()
        {

            ThreadStart start   = new ThreadStart(ImagingThread);
            m_thread            = new Thread(start);
            m_thread.Start();
        }
        /// <summary>
        /// Imaging thread.
        /// </summary>
        private void ImagingThread()
        {
            ManualResetEvent dummyEvent = new ManualResetEvent(false);
            WaitHandle[] events = new WaitHandle[] {dummyEvent,  m_waitEvent };

            // Wait until someone tells us not to process - this is the main loop
            while (m_isProcessing)
            {
                int eventHandle = WaitHandle.WaitAny(events);
                if (eventHandle == 1)
                {
                    m_waitEvent.Reset();

                    int runEvent = 0;
                    // otherwise we wait for a start and stop.
                    while (m_isRunning)
                    {
                        // We tell it to wait for a few milliseconds for an event.
                        // In this case the events is just a trigger to collect data or abort.
                        runEvent = WaitHandle.WaitAny(events, 50);                       
                        if (runEvent == 1)
                        {
                            m_waitEvent.Reset();
                        }
                        else if (runEvent == 258)
                        {
                            // Wait around the data, so that when we write 
                            // we know nothing else can touch it.
                            lock (m_lockObject)
                            {
                                //m_lastData = DateTime.Now.ToString();                                
                                m_lastData = m_camera.QueryFrame();
                            }

                            if (this.DataCaptured != null && m_lastData != null)
                            {
                                this.DataCaptured(this, new ExampleEventArgs(m_lastData));
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the name of the device.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Starts the thread processing.
        /// </summary>
        public void Start()
        {
            m_isRunning = true;
            m_waitEvent.Set();
            
            if (ThreadStarted != null)
            {
                ThreadStarted(this, null);
            }
        }
        /// <summary>
        /// Stops the camera from running.
        /// </summary>
        public void Stop()
        {
            m_isRunning = false;
            m_waitEvent.Set();

            if (ThreadStopped != null)
            {
                ThreadStopped(this, null);
            }
        }
        /// <summary>
        /// Gets an the last data we saw.
        /// </summary>
        /// <returns></returns>
        public Image<Bgr, Byte> GetLastData()
        {
            return m_lastData;
        }
        #endregion
    }

    /// <summary>
    /// This is an event arguments class, so that I dont have to define 
    /// a delegate.
    /// </summary>
    public class ExampleEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">Data to share with rest of the application.</param>
        public ExampleEventArgs(Image<Bgr, Byte> data)
        {
            LastData = data;
        }
           
        /// <summary>
        /// Gets the last data .
        /// </summary>
        public Image<Bgr, Byte> LastData
        {            
            get;
            // we use a private set, so that no one can mess with the 
            // data later
            private set;
        }
    }
}
