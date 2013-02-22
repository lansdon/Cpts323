using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApplication.Data;
using ZooApplication.Data.Exotic;

namespace ZooApplication.Factories
{
    /// <summary>
    /// Exotic animal factory for animals that should belong to the wild and have freedom.
    /// </summary>
    public sealed class ExoticAnimalFactory : AbstractAnimalFactory
    {
        public override Animal CreateAnimal(AnimalTypes animalType)
        {
            Animal animal = null;
            switch (animalType)
            {
                case AnimalTypes.Feline:
                    animal = new Lion(2, "Leo");
                    break;
                case AnimalTypes.Canine:
                    animal = new Wolve(2, "Wilfred");
                    break;
                case AnimalTypes.Bovine:
                    animal = new Bull(2, "Billy");
                    break;
                default:
                    break;
            }

            return animal;
        }

        public override string ToString()
        {
            return "Exotic Factory";
        }
    }
}
