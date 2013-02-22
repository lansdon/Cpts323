
using ZooApplication.Data;

namespace ZooApplication.Factories
{
    /// <summary>
    /// Abstract class for creating animal factories
    /// </summary>
    public abstract class AbstractAnimalFactory
    {
        /// <summary>
        /// Create an animal based on a type directive.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public abstract Animal CreateAnimal(AnimalTypes animalType);
    }
}
