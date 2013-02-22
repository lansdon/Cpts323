using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesBasics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AddClass        add         = new AddClass();
            SubtractClass   subtract    = new SubtractClass();

            IExampleInterface exampleInterface = add;
            Console.WriteLine(exampleInterface.Perform(5, 6));
            exampleInterface.Print();

            exampleInterface = subtract;
            Console.WriteLine(exampleInterface.Perform(5, 6));
            exampleInterface.Print();

            IExampleInterface2 music = subtract;
            music.AnotherExample(10000);
        }
    }

    /// <summary>
    /// An example interface
    /// </summary>
    public interface IExampleInterface
    {
        /// <summary>
        /// An example method
        /// </summary>
        void Print();
        int Perform(int a, int b);
    }
    public interface IExampleInterface2
    {
        /// <summary>
        /// Plays a sound.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void AnotherExample(int b);
    }

    /// <summary>
    /// Adds multiple numbers together
    /// </summary>
    public class AddClass : IExampleInterface
    {
        public void Print()
        {
            Console.WriteLine("This is a test");
        }

        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        /// <param name="a">A</param>
        /// <param name="b">B</param>
        /// <returns>Addition of A and B</returns>
        public int Perform(int a, int b)
        {
            return a + b;
        }
    }
    /// <summary>
    /// Subtracts numbers from each other.
    /// </summary>
    public class SubtractClass : IExampleInterface, IExampleInterface2
    {
        /// <summary>
        /// Prints garbage to a file.
        /// </summary>
        public void Print()
        {
            File.AppendAllText("test", "garbage");
        }
        /// <summary>
        /// Subtracts A from B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Perform(int a, int b)
        {
            return a - b;
        }

        public void AnotherExample(int b)
        {
            Console.WriteLine((b + 2).ToString());
        }
    }
}
