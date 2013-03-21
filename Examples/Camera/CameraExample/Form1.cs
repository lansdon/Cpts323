using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;

namespace CameraExample
{
    public partial class Form1 : Form
    {
        Capture m_camera;
        bool m_isProcessing;

        public Form1()
        {
            InitializeComponent();

            m_isProcessing  = false;
            m_camera        = new Capture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetImage();
            timeLabelStrip.Text = "Image taken.";
        }

        private void GetImage()
        {
            Image<Bgr, byte> image = m_camera.QueryFrame();
            Image windowsFormImage = image.ToBitmap();
            pictureBox1.Image = windowsFormImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled  = (imageTimer.Enabled == false);
            m_isProcessing      = false;
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            GetImage();
            if (m_isProcessing)
            {
                // simulate a lot of processing
                Thread.Sleep(3000);
            }

            DateTime now        = DateTime.Now;
            timeLabelStrip.Text = now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_isProcessing      = true;
            imageTimer.Enabled  = (imageTimer.Enabled == false);
        } 
    }
}
