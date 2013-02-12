using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    public abstract class Animal
    {
        /// <summary>
        /// Number of legs the animal has.
        /// </summary>
        protected int m_legs;
        /// <summary>
        /// Name of animal
        /// </summary>
        protected string m_name;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of animal</param>
        public Animal(string name)
        {
            m_name = name;
        }    

        /// <summary>
        /// Feeds the animal.  Has to be implemented by the sub-class
        /// </summary>
        public abstract void Feed();
        

        /// <summary>
        /// Says the name of the animal.
        /// </summary>
        public void SayName()
        {
            Speak(string.Format("I am {0}", m_name));
        }
   
        /// <summary>
        /// Speaks 
        /// </summary>
        public virtual void Speak(string words)
        {
            Console.WriteLine("{0}", words);
        }
    }

    /// <summary>
    /// Cat sub class
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name):
            base(name)
        {

        }

        
            
        /// <summary>
        /// Feeds the cat
        /// </summary>
        public override void Feed()
        {
            Speak("I eat when I want!");
        }
    }

     class Horse : Animal
    {

        public Horse(string name) :
            base(name)
        {
        }

        /// <summary>
        /// Feeds the cat
        /// </summary>
        public override void Feed()
        {
            
        }
    }


    /// <summary>
    /// Derives from the Animal Class.
    /// </summary>
    public class Dog : Animal
    {
        public Dog(string name):
            base(name)
        {
            
        }

        /// <summary>
        /// Feeds the animal
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine("woof woof {0} ate their food" , m_name);
        }

        /// <summary>
        /// Speaks the words while barking
        /// </summary>
        /// <param name="words"></param>
        public override void Speak(string words)
        {
            Console.WriteLine("Bow wow {0} wow bow", words);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myCat = new Cat("Kibbles");
            Animal myDog = new Dog("Fido");

            List<Animal> animals = new List<Animal>();

            animals.Add(myCat);
            animals.Add(myDog);

            foreach (Animal pet in animals)
            {
                pet.SayName();
                pet.Feed();
                pet.Speak("I am le tired!");
            }

            Console.Read();
        }
    }
}
