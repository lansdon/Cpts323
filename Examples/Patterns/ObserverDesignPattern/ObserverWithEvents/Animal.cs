using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public abstract class Animal
    {
        private int m_foodInStomach;

        public Animal()
        {
            m_foodInStomach = 10;
        }

        public virtual void Feed(int food)
        {
        }
        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }

    public class Dog : Animal
    {

    }

    public class Cat : Animal
    {

    }

    public class Cow: Animal
    {

    }

    public enum AnimalType
    {
        Cow,
        Dog,
        Cat
    }
}
