using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExampleConsole
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Cat
    {
        /// <summary>
        /// Detects targets
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public abstract bool DetectTargets(string text);
    }
    /// <summary>
    /// TargetDetector
    /// </summary>
    public class GrumpyCat : Cat
    {
        public override bool DetectTargets(string text)
        {
            if ("missiles" == text)
            {
                Console.WriteLine(" Fine!");
                return true;
            }

            Console.WriteLine(" NO! ");
            return false;
        }
    }

    public class PassiveAggressiveCat : Cat
    {
        public override bool DetectTargets(string text)
        {

            if (text == "missiles")
            {
                Console.WriteLine("YAY! ");
                return true;
            }
            Console.WriteLine("Nice try!....but you suck");
            return false;
        }
    }
    
    /// <summary>
    /// Missile Launcher
    /// </summary>
    public class ChuckNorris
    {
        public void FireMissiles()
        {
            Console.WriteLine("Surprise!!!");
        }
    }

    public enum CatType
    {
        PassiveAggressive,
        Grumpy
    }

    public class CatFactory
    {
        /// <summary>
        /// Creates a cat.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Cat CreateCat(CatType type)
        {
            Cat cat = null;
            switch (type)
            {
                case CatType.PassiveAggressive:
                    cat = new PassiveAggressiveCat();
                    break;
                case CatType.Grumpy:
                    cat = new GrumpyCat();
                    break;
                default:
                    break;
            }
            return cat;
        }
    }

    public class Mediator
    {
        private Cat   m_detector;
        private ChuckNorris m_launcher;

        public Mediator(Cat cat)
        {
            m_detector = cat;
            m_launcher = new ChuckNorris();
        }        

        public void SeekAndDestroy()
        {
            string input = "";

            while (input != "quit")
            {
                if (input != "quit")
                {
                    Console.Write("And then? ");
                    input = Console.ReadLine();

                    bool didFindTarget = m_detector.DetectTargets(input);
                    if (didFindTarget)
                    {
                        m_launcher.FireMissiles();
                    }
                }
            }
            
        }
    }

    class Program
    {      
        static void Main(string[] args)
        {
            Console.Write("what kind of cat do you want? ");
            string catName = Console.ReadLine();

            CatType type = CatType.PassiveAggressive;
            if (catName.ToLower() == "grumpy")
            {
                type = CatType.Grumpy;
            }
            Cat cat = CatFactory.CreateCat(type);

            Mediator mediator = new Mediator(cat);
            mediator.SeekAndDestroy();
        }
    }
}
