using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreadingExample
{
    public partial class Form1 : Form
    {
        ExampleThreadedClass m_exampleClass;
        
        public Form1()
        {
            InitializeComponent();

            m_exampleClass = new ExampleThreadedClass();
            m_exampleClass.ThreadStarted += new EventHandler(m_exampleClass_ThreadStarted);
            m_exampleClass.ThreadStopped += new EventHandler(m_exampleClass_ThreadStopped);
            m_exampleClass.DataCaptured += new EventHandler<ExampleEventArgs>(m_exampleClass_DataCaptured);
        }

        void m_exampleClass_DataCaptured(object sender, ExampleEventArgs e)
        {
            if (InvokeRequired)
            {
                
                Invoke(new EventHandler<ExampleEventArgs>(DataHandler), sender, e);
            }
            else
            {
                DataHandler(sender, e);
            }
        }
        private void DataHandler(object sender, ExampleEventArgs e)
        {

            m_dataLabel.Text = e.LastData;
        }

        void m_exampleClass_ThreadStopped(object sender, EventArgs e)
        {
            m_dataLabel.Text = "Thread Stopped.";
        }

        void m_exampleClass_ThreadStarted(object sender, EventArgs e)
        {
            m_dataLabel.Text = "Thread Started.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m_dataLabel.Text = "";
        }

        private void m_getDataButton_Click(object sender, EventArgs e)
        {
            m_dataLabel.Text = m_exampleClass.GetLastData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_exampleClass.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_exampleClass.Stop();
        }
    }
}
