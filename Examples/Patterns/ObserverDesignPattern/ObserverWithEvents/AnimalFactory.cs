using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class AnimalFactory
    {
        private static Random m_random;
        private static List<string> m_startNames;
        private static List<string> m_endNames;
        private static bool m_namesMade = false;

        public static Animal CreateAnimal(AnimalType type)
        {
            if (m_namesMade == false)
            {
                m_namesMade     = true;
                m_startNames    = new List<string>();
                m_endNames      = new List<string>();

                m_startNames.Add("Jim");
                m_startNames.Add("Harry");
                m_startNames.Add("Jerry");
                m_startNames.Add("Fred");
                m_startNames.Add("Josh");


                m_endNames.Add("Jim");
                m_endNames.Add("Bob");
                m_endNames.Add("Sue");
                m_endNames.Add("Jo");
                m_endNames.Add("Ted");
                m_random = new Random();
            }

            Animal animal = null;
            switch (type)
            {
                case AnimalType.Cow:
                    animal = new Cow();
                    animal.Name = "moooooo....";
                    break;
                case AnimalType.Dog:
                    animal = new Dog();
                    animal.Name = "ruff....";
                    break;
                case AnimalType.Cat:
                    animal = new Cat();
                    animal.Name = "meow....";
                    break;
                default:
                    break;
            }
            animal.Name += GetName();
            return animal;
        }

        /// <summary>
        /// Gets a new name for an animal.
        /// </summary>
        /// <returns></returns>
        private static string GetName()
        {
            int start = m_random.Next(0, m_startNames.Count);
            int end   = m_random.Next(0, m_endNames.Count);

            string name = string.Format("{0} {1}",
                                                m_startNames[start],
                                                m_endNames[end]);
            return name;
        }
    }
}
