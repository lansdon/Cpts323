using ZooApplication.Data;
using ZooApplication.Data.Domestic;

namespace ZooApplication.Factories
{   
    /// <summary>
    /// Domesticated animal factory for nice animals that can be placed in a house.
    /// </summary>
    public sealed class DomesticAnimalFactory : AbstractAnimalFactory
    {
        /// <summary>
        /// Creates a domesticated animal.
        /// </summary>
        /// <param name="animalType"></param>
        /// <returns></returns>
        public override Animal CreateAnimal(AnimalTypes animalType)
        {
            Animal animal = null;
            switch (animalType)
            {
                case AnimalTypes.Feline:
                    animal = new SiameseCat(1, "Snooty");
                    break;
                case AnimalTypes.Canine:
                    animal = new Labrador(1, "Fido");
                    break;
                case AnimalTypes.Bovine:
                    animal = new Cow (1, "Chik-fil-a");
                    break;
                default:
                    break;
            }

            return animal;
        }

        /// <summary>
        /// This changes the display from the object's type, to something more human readable we want to display in the UI.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Domestic Factory";
        }
    }
}
