using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication.Data
{
    /// <summary>
    /// Event arguments when an animal is added.
    /// </summary>
    public class AnimalAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor for animals added events.
        /// </summary>
        /// <param name="addedAnimal">The Animal that was added</param>
        public AnimalAddedEventArgs(Animal addedAnimal)
        {
            Animal = addedAnimal;
        }
        /// <summary>
        /// Gets the animal that was provided
        /// </summary>
        public Animal Animal
        {
            get;
            private set; // Here I use a private scope modifier 
            // so that someone who is handling the event that this 
            // object was passed through cannot change the reference
            // of the animal to : null, or another animal
            // This protects the data through the call stack.
        }
    }
}
