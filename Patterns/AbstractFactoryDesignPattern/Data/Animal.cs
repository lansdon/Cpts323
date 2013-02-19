using System;
using System.Drawing;
using System.IO;
using System.Media;

namespace ZooApplication.Data
{
    /// <summary>
    /// Abstract class that defines the basic needs of an animal.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Random number generator for all animals to use when moving.
        /// </summary>
        private static Random m_random = new Random();

        /// <summary>
        /// Value that the animal will move by default
        /// </summary>
        protected int m_rangeMovementY;
        /// <summary>
        /// Value that the animal will move by default
        /// </summary>
        protected int m_rangeMovementX;
        /// <summary>
        /// Event that is fired when the animal needs food now!
        /// </summary>
        public event EventHandler NeedsFoodNow;

        /// <summary>
        /// Image of the animal;
        /// </summary>
        protected Image m_animalImage;
        /// <summary>
        /// Rate at which the animal metabolizes food
        /// </summary>
        protected int m_metabolism;
        /// <summary>
        /// Amount of food 
        /// </summary>
        protected int m_hungerFactor;
        /// <summary>
        /// Path to the sound byte to play.
        /// </summary>
        protected string m_soundPath;

        public Animal(int metabolismRate, string name)
        {
            m_rangeMovementY = 10;
            m_rangeMovementX = 10;

            m_hungerFactor   = 10;
            m_metabolism     = metabolismRate;
            Name             = name;
            m_soundPath = null;
        }

        /// <summary>
        /// Name of the animal.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the location of the animal.
        /// </summary>
        public Point Location
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the hunger factor for an animal.
        /// </summary>
        public int Hungerfactor
        {
            get
            {
                return m_hungerFactor;
            }
        }
        /// <summary>
        /// Gets whether the animal is angry or not.
        /// </summary>
        public bool IsAngry
        {
            get
            {
                return m_hungerFactor <= 1;
            }
        }
        /// <summary>
        /// Gets the image associated with this animal.
        /// </summary>
        public Image Image
        {
            get
            { 
                return m_animalImage; 
            }           
        }
        /// <summary>
        /// Feeds the animal 
        /// </summary>
        /// <param name="food"></param>
        public virtual void Feed(int food)
        {
            m_hungerFactor += food;
        }

        /// <summary>
        /// Moves and renders the animal to the screen.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pen"></param>
        public string MakeNoise()
        {
            m_hungerFactor -= m_metabolism;
            string speak    = Speak();

            if (m_hungerFactor <= 0)
            {
                // The animal is dead!
                if (NeedsFoodNow != null)
                {
                    NeedsFoodNow(this, null);
                }
                // Draw the animal upside down
                speak = "need food!";
            }
            return speak;
        }
        /// <summary>
        /// Moves the animal a slight amount.
        /// </summary>
        /// <param name="animalPen"></param>
        public void MoveAnimal(Size animalPen)
        {
            if (m_animalImage != null)
            {
                int width  = Math.Abs(animalPen.Width  - m_animalImage.Width);
                int height = Math.Abs(animalPen.Height - m_animalImage.Height);

                int x = Math.Max(0, Math.Min(width, Location.X + m_random.Next(-m_rangeMovementX, m_rangeMovementX)));
                int y = Math.Max(0, Math.Min(width, Location.Y + m_random.Next(-m_rangeMovementY, m_rangeMovementY))); 
                
                Location = new Point(x, y);
            }
           
        }

        /// <summary>
        /// Creates a noise based on the animal.
        /// </summary>
        /// <returns></returns>
        protected abstract string Speak();

        /// <summary>
        /// Plays a sound byte from the animal.
        /// </summary>
        /// <param name="soundBytePath">Path to sound byte to play.</param>
        protected virtual void PlaySpeech()
        {
            // make sure that the sound byte path exists.
            if (m_soundPath == null)
                return;

            try
            {
                using (SoundPlayer player = new SoundPlayer(m_soundPath))
                {
                    player.Play();
                }
            }
            catch (UriFormatException)
            {

            }
            catch (FileNotFoundException)
            {

            }
        }
    }
   
    /// <summary>
    /// Types of animals that the application can create.
    /// </summary>
    public enum AnimalTypes
    {
        Feline,
        Canine,
        Bovine
    }
}
