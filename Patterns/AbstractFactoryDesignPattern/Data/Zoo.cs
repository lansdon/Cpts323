using System;
using System.Collections.Generic;
using ZooApplication.Data;

namespace ZooApplication.Data
{
    
    /// <summary>
    /// Class that manages the animals.
    /// </summary>
    public class Zoo
    {
        /// <summary>
        /// Fired when the animals escape.
        /// </summary>
        public event EventHandler AnimalsEscaped;
        /// <summary>
        /// Fired when an animal was added.
        /// </summary>
        public event EventHandler<AnimalAddedEventArgs> AnimalAdded;

        
        /// <summary>
        /// Constructor
        /// </summary>
        public Zoo()
        {
            Animals = new List<Animal>();

        }
     
        /// <summary>
        /// Gets the list of animals 
        /// </summary>
        public List<Animal> Animals
        {
            get;
            private set;
        }
        /// <summary>
        /// Clears the zoo, by removing the animals.
        /// </summary>
        public void ClearZoo()
        {
            // Cleanup an event handlers, we dont want dangling references
            foreach (Animal animal in Animals)
            {
                //GOOD Practice:  Clean up any event handler delegate links.
                animal.NeedsFoodNow -= animal_NeedsFoodNow;

                //GOOD Practice: Clean up the image resource to prevent memory leaks.
                if (animal.Image != null)
                {
                    animal.Image.Dispose();
                }
            }
            // Clear the list 
            Animals.Clear();

            // Then let listeners know that the animals escaped.
            if (AnimalsEscaped != null)
            {
                AnimalsEscaped(this, null);
            }
        }
        /// <summary>
        /// Adds an animal to the zoo
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            // Sync the new animal
            animal.NeedsFoodNow += new EventHandler(animal_NeedsFoodNow);

            // Let listeners know that an animal was added.
            if (this.AnimalAdded != null)
            {
                AnimalAdded(this, new AnimalAddedEventArgs(animal));
            }

            // Then add the animal to the list of animals the zoo is maintaining.
            Animals.Add(animal);
        }

        /// <summary>
        /// Handles when an animal is starving!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void animal_NeedsFoodNow(object sender, System.EventArgs e)
        {
            // If the animal needs food DO SOMETHING
        }
        /// <summary>
        /// Feeds each animal.
        /// </summary>
        public void FeedAnimals(int amount)
        {
            Animals.ForEach(x => x.Feed(amount));
        }

    }    
}
