using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class MainForm : Form
    {

        DateTime m_startDown;

        public MainForm()
        {
            InitializeComponent();

            buttonDisplaySomeControls.Click += buttonDisplaySomeControls_Click;

            targetExample1.TargetName = "Bob";
            targetExample2.TargetName = "John";
            targetExample3.TargetName = "George";
            targetExample4.TargetName = "Fred";
        }

        private void buttonDisplaySomeControls_Click(object sender, EventArgs e)
        {
            someControlsGroupBox.Visible = true;
        }

        private void displayTextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example of a button click event handler");
        }



        private void MoveItDown(object sender, MouseEventArgs e)
        {
            moveItTimer.Enabled = true;
            m_startDown = DateTime.Now;
        }

        private void MoveItUp(object sender, MouseEventArgs e)
        {
            moveItTimer.Enabled = false;
            timeElapsedLabel.Text         = "press it!";
        }

        private void moveItTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime  = DateTime.Now;
            TimeSpan spanSince    = currentTime.Subtract(m_startDown);

            double acceleration   = 5 * Math.Log(Math.Max(1, spanSince.TotalSeconds));


            accelerationLabel.Text = string.Format("{0:0.00} m/s^2", acceleration);
            timeElapsedLabel.Text = string.Format("{0:0.00} seconds since", spanSince.TotalSeconds);
        }

        private void buttonHideSomeControls_Click(object sender, EventArgs e)
        {
            someControlsGroupBox.Visible = false;
        }


        int m_dogs = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Dog fido = new Dog();
            fido.Name = "fido " + m_dogs.ToString();
            fido.Age = ++m_dogs;

            listBox1.Items.Add(fido);

            ListViewItem dogItem = new ListViewItem();
            dogItem.Tag = fido;
            dogItem.Text = fido.Name;
            ListViewItem.ListViewSubItem ageItem = new ListViewItem.ListViewSubItem();
            ageItem.Text = fido.Age.ToString();

            dogItem.SubItems.Add(ageItem);
            listView1.Items.Add(dogItem);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// This tries to type case the selected item into a dog,
            /// if it fails then the dog will be null
            Dog dog = listBox1.SelectedItem as Dog;
            // as opposed to doing it this way...which will throw an exception Dog dog = (Dog)listBox1.SelectedItem;

            // but we have to check to see that the dog is not null
            if (dog == null)
                return;

            selectedDogLabel.Text = dog.Name;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;

            /// This tries to type case the selected item into a dog,
            /// if it fails then the dog will be null
            ListViewItem selectedItem = listView1.SelectedItems[0];
            Dog dog = selectedItem.Tag  as Dog;
            // as opposed to doing it this way...which will throw an exception Dog dog = (Dog)listBox1.SelectedItem;

            // but we have to check to see that the dog is not null
            if (dog == null)
                return;

            selectedDogLabel.Text = dog.Name;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();  
            //txt files (*.txt)|*.txt|All files (*.*)|*.*
            dialog.Filter = "XML Targets |*.xml|INI Targets|*.ini|All Files|*.*";
            DialogResult result =  dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string path =  dialog.FileName;
                MessageBox.Show("File: " + path);
            }
        }      
        
    }
}
