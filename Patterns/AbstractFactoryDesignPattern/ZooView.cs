using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooApplication.Data;
using ZooApplication.Factories;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// View of the animal zoo.
    /// </summary>
    public partial class ZooView : Form
    {
        private Dictionary<Animal, bool> m_animalFlipped;
        /// <summary>
        /// Maps the animal to a given ListViewItem tag so we can update the UI.
        /// </summary>
        private Dictionary<Animal, ListViewItem> m_animalToViewMap;
        /// <summary>
        /// Selected animal factory to use.
        /// </summary>
        private AbstractAnimalFactory m_factory;
        /// <summary>
        /// Object that maintains the animals.
        /// </summary>
        private Zoo m_zoo;
        /// <summary>
        /// Generates a random location to draw the animal initially.
        /// </summary>
        private Random m_randomLocation;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ZooView()
        {
            InitializeComponent();

            m_randomLocation      = new Random();
            zooPanel.Invalidated += zooPanel_Invalidated;

            // Animal factories to create.
            AnimalFactorySelectorBox.Items.Add(new DomesticAnimalFactory());
            AnimalFactorySelectorBox.Items.Add(new ExoticAnimalFactory());
            AnimalFactorySelectorBox.SelectedIndex = 0;

            // Animal types to create
            AnimalTypeBox.Items.Add(AnimalTypes.Bovine);
            AnimalTypeBox.Items.Add(AnimalTypes.Canine);
            AnimalTypeBox.Items.Add(AnimalTypes.Feline);
            AnimalTypeBox.SelectedIndex = 0;

            m_zoo = new Zoo();
            m_zoo.AnimalsEscaped += m_zoo_AnimalsEscaped;
            m_zoo.AnimalAdded    += m_zoo_AnimalAdded;

            m_animalToViewMap   = new Dictionary<Animal, ListViewItem>();
            m_animalFlipped     = new Dictionary<Animal, bool>();

            m_factory = AnimalFactorySelectorBox.SelectedItem as AbstractAnimalFactory;
        }

        void zooPanel_Invalidated(object sender, InvalidateEventArgs e)
        {
            DrawAnimals(m_zoo.Animals);
        }

        #region Zoo Event Handlers
        /// <summary>
        /// Handles synching UI elements when a new animal is added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_zoo_AnimalAdded(object sender, AnimalAddedEventArgs e)
        {            
            Animal animal     = e.Animal;
            m_animalFlipped.Add(animal, false);
            AddAnimalToListView(animal);
            DrawAnimals(m_zoo.Animals);
        }
        /// <summary>
        /// Clears the current display of animals.
        /// </summary>
        private void ClearGraphics()
        {
            using (Graphics graphics = Graphics.FromHwnd(zooPanel.Handle))
            {
                graphics.Clear(Color.White);
            }
        }
        /// <summary>
        /// Draws an animal to the screen.
        /// </summary>
        /// <param name="animal"></param>
        private void DrawAnimals(List<Animal> animals)
        {
            ClearGraphics();

            // Here we are actually coupling an animal (our data model)
            // to a view (the graphics component)
            // and should really be 
            foreach(Animal animal in animals)
            {
                DrawAnimal(animal);
            }           
        }
        /// <summary>
        /// Draws an animal
        /// </summary>
        /// <param name="animal"></param>
        private void DrawAnimal(Animal animal)
        {
            if (animal.Image == null)
                return;

            using (Graphics graphics = Graphics.FromHwnd(zooPanel.Handle))
            {
                string message = animal.MakeNoise();

                if (message != null)
                {
                    using (Brush brush = new SolidBrush(Color.Black))
                    {
                        graphics.DrawString(message, Font, brush, animal.Location.X - 20, animal.Location.Y - 20);
                    }   
                }
                // Rotate if the animal is having a caniption
                if (animal.IsAngry)
                {
                    if (!m_animalFlipped[animal])
                    {
                        m_animalFlipped[animal] = true;
                        animal.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    }
                }
                else
                {
                    if (m_animalFlipped[animal])
                    {
                        m_animalFlipped[animal] = false;
                        animal.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    }
                }
                    
                // Draw the image.
                graphics.DrawImage(animal.Image, animal.Location);                               
            }          
        }
        /// <summary>
        /// Adds an animal to the list view control
        /// </summary>
        /// <param name="animal"></param>
        private void AddAnimalToListView(Animal animal)
        {    
            ListViewItem item = new ListViewItem();
            item.Text         = animal.Name;

            ListViewItem.ListViewSubItem isAngrySubItem = new ListViewItem.ListViewSubItem();
            isAngrySubItem.Text = animal.IsAngry.ToString();

            ListViewItem.ListViewSubItem hungerSubItem = new ListViewItem.ListViewSubItem();
            hungerSubItem.Text = animal.Hungerfactor.ToString();
            
            item.SubItems.Add(hungerSubItem);
            item.SubItems.Add(isAngrySubItem);

            m_animalToViewMap.Add(animal, item);
            AnimalDetails.Items.Add(item);
        }
        /// <summary>
        /// Handles synching UI elements when animals escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_zoo_AnimalsEscaped(object sender, EventArgs e)
        {
            m_animalFlipped.Clear();
            ClearGraphics();
            m_animalToViewMap.Clear();
            AnimalDetails.Clear();
        }
        #endregion

        #region Window Event Handlers 
        /// <summary>
        /// Releases the animals from the zoo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAnimalsButton_Click(object sender, EventArgs e)
        {
            m_zoo.ClearZoo();
        }
        /// <summary>
        /// Adds a new animal to the zoo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            // Figure out what type of animal to create.
            AnimalTypes typeOfAnimal = ((AnimalTypes)AnimalTypeBox.SelectedItem);

            // Create the new animal.
            Animal animal            = m_factory.CreateAnimal(typeOfAnimal);

            if (animal.Image != null)
            {
                int width       = zooPanel.Width  - animal.Image.Width;
                int height      = zooPanel.Height - animal.Image.Height;
                animal.Location = new Point(m_randomLocation.Next(10, width),
                                            m_randomLocation.Next(10, height));
            }

            m_zoo.AddAnimal(animal);
        }
        /// <summary>
        /// Sets the Animal Factory Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimalFactoryButton_Click(object sender, EventArgs e)
        {
            m_factory = AnimalFactorySelectorBox.SelectedItem as AbstractAnimalFactory;
        }
        #endregion

        private void FeedTimer_Tick(object sender, EventArgs e)
        {
            ClearGraphics();
            foreach (Animal animal in m_zoo.Animals)
            {
                animal.MoveAnimal(zooPanel.Size);

                ListViewItem item     = m_animalToViewMap[animal];
                item.SubItems[1].Text = animal.Hungerfactor.ToString();
                item.SubItems[2].Text = animal.IsAngry.ToString();

                DrawAnimal(animal);
            }            
        }

        private void FeedAnimalsButton_Click(object sender, EventArgs e)
        {
            m_zoo.FeedAnimals(10);
        }
    }
}
