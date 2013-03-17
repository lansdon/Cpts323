using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class TargetExample : UserControl
    {
        public TargetExample()
        {
            InitializeComponent();
        }


        public string TargetName
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am " + TargetName);
        }
    }
}
