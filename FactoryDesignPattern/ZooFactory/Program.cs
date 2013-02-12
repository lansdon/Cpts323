using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooFactory
{
    /// <summary>
    /// A simple example of an animal
    /// </summary>
    public abstract class Animal
    {
        public string Name
        {
            get;
            set;
        }

        public void Feed()
        {
        }
    }

    public sealed class Dog : Animal
    {
        public Dog()
        {
            Name = "Doggy";
        }
        public Dog(string doggyName)
        {
            Name = doggyName;
        }
    }
    public sealed class Cat : Animal
    {
        public Cat()
        {
            Name = "Kibbles";
        }
    }

    /// <summary>
    /// Concrete factory that creates animals.
    /// </summary>
    public class ZooFactory
    {
        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <returns></returns>
        public Animal CreateAnimal()
        {
            Animal animal   = null;
            animal          = new Dog();
            return animal;
        }            
        /// <summary>
        /// Creates a new animal
        /// </summary>
        /// <param name="animalType">Animal to create</param>
        /// <returns>An animal.</returns>
        public Animal CreateAnimal(AnimalType animalType)
        {
            Animal animal = null;

            switch (animalType)
            {
                case AnimalType.Dog:
                    animal = new Dog();
                    break;
                case AnimalType.Cat:
                    animal = new Cat();
                    break;
                default:
                    break;
            }
            return animal;
        }
        /// <summary>
        /// Creates an animal based on the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Animal CreateDog(string name)
        {
            return new Dog(name);
        }
    }
    /// <summary>
    /// Simple enumeration for animal types.
    /// </summary>
    public enum AnimalType
    {
        Dog,
        Cat
    }
        
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
