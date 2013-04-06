using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{

    class ZooManager
    {
        /// <summary>
        /// This is the signature that the 
        /// </summary>
        /// <param name="animal"></param>
        public delegate void AddAnimal(object sender, Animal animal);

        // Three events...
        /// <summary>
        /// Fired when a dog is added
        /// </summary>
        public event AddAnimal AddedDog;
        /// <summary>
        /// Fired when a cat is added
        /// </summary>
        public event AddAnimal AddedCat;
        /// <summary>
        /// Fired when a cow is added 
        /// </summary>
        public event AddAnimal AddedCow;

        public void AddDog(Animal animal)
        {
            if (AddedDog != null)
            {
                AddedDog(this, animal);
            }
        }

        public void AddCat(Animal animal)
        {
            if (AddedCat != null)
            {
                AddedCat(this, animal);
            }
        }

        public void AddCow(Animal animal)
        {
            if (AddedCow != null)
            {
                AddedCow(this, animal);
            }
        }
    }
}
