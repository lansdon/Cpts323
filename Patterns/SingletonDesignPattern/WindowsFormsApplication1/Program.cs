using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        ///  this method adds a memory manager to the list of resources we want to use.
        /// </summary>
        static void ExampleOfAnotherMethod()
        {
            // This shows that we only have one instance, and we can access the 
            // reference to the object via the singleton pattern.
            ResourceManager.GetInstance().AddResource(new MemoryManager());
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //   ResourceManager manager = new ResourceManager();
            // We can't do the above, because we have used the singleton pattern
            // to limit the number of instances that we are using            
            // instead:
            ResourceManager manager = ResourceManager.GetInstance();
            manager.AddResource(new DigitalCamera());
            ExampleOfAnotherMethod();
            manager.AddResource(new XMLFileReader());

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Cleaning up resources");
            CleanUp();
            Console.WriteLine("input key to continue...");
            Console.Read();
        }

        private static void CleanUp()
        {

            ResourceManager manager = ResourceManager.GetInstance();
            manager.CleanUpAfterYourself();
        }

        #region Singleton Example Object
        public class ResourceManager
        {
            /// <summary>
            /// Singleton reference.
            /// </summary>
            private static ResourceManager m_instance;
            
            /// <summary>
            /// Lazy implementation that gets the instance of the singleton.
            /// </summary>
            /// <returns></returns>
            public static ResourceManager GetInstance()
            {
                if (m_instance == null)
                {
                    m_instance = new ResourceManager();
                }
                return m_instance;
            }

            /// <summary>
            /// Constructor.
            /// </summary>
            private ResourceManager()
            {
                m_resources = new List<IDisposable>();
            }

            /// <summary>
            /// List that holds onto any resources possible
            /// </summary>
            List<IDisposable> m_resources;

            /// <summary>
            /// Adds a resource to the static singleton.
            /// </summary>
            /// <param name="resource"></param>
            public void AddResource(IDisposable resource)
            {
                m_resources.Add(resource);
            }
            /// <summary>
            /// Cleans up the resources.
            /// </summary>
            public void CleanUpAfterYourself()
            {
                foreach (IDisposable obj in m_resources)
                {
                    obj.Dispose();
                }
            }
        }
        #endregion

        #region Objects that use resources
        public class MemoryManager : IDisposable
        {

            public void Dispose()
            {
                Console.WriteLine("Memory manager");
            }
        }
        public class DigitalCamera : IDisposable
        {

            public void Dispose()
            {
                Console.WriteLine("Digital Camera");
            }
        }
        public class XMLFileReader : IDisposable
        {
            public void Dispose()
            {

                Console.WriteLine("XML File reader");
            }
        }
        #endregion
    }
}
