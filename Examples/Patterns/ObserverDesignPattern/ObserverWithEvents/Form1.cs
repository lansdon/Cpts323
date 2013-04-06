using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExample
{
    public partial class Form1 : Form
    {
        ZooManager m_manager;

        public Form1()
        {
            InitializeComponent();

            m_manager = new ZooManager();

            
        }

        private void NewFunctionForCats(object sender, Animal animal)
        {
            catLabel2.Text = "This is the second observer - " + animal.Name;
        }



        void m_manager_AddedDog(object sender, Animal animal)
        {
            dogLabel.Text = animal.Name;
        }

        void m_manager_AddedCow(object sender, Animal animal)
        {
            cowLabel.Text = animal.Name;
        }

        void m_manager_AddedCat(object sender, Animal animal)
        {
            animal = null;

            catsLabel.Text = animal.Name;       
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            
            m_manager.AddCat(AnimalFactory.CreateAnimal(AnimalType.Cat));
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            m_manager.AddDog(AnimalFactory.CreateAnimal(AnimalType.Dog));
        }

        private void buttonCow_Click(object sender, EventArgs e)
        {
            m_manager.AddCow(AnimalFactory.CreateAnimal(AnimalType.Cow));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            m_manager.AddedCat += m_manager_AddedCat;
            m_manager.AddedCow += m_manager_AddedCow;
            m_manager.AddedDog += m_manager_AddedDog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_manager.AddedCat -= m_manager_AddedCat;
            m_manager.AddedCow -= m_manager_AddedCow;
            m_manager.AddedDog -= m_manager_AddedDog;

        }
        
    }
}
