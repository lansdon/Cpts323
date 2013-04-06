using ObserverExample1.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverExample1
{
    /// <summary>
    /// An abstract observer object for the observer pattern.
    /// </summary>
    public interface ITranslatorBase
    {
        /// <summary>
        /// This method tells translators to say the message.
        /// This is our notify method...
        /// </summary>
        /// <param name="message"></param>
        string TranslateNews(string message);

        /// <summary>
        /// Gets the name of the translator...
        /// </summary>
        string Name { get; }
    }

    /// <summary>
    /// Subject  class that broadcasts the message
    /// </summary>
    public class RonBurgandy
    {
        /// <summary>
        /// Singleton 
        /// </summary>
        static RonBurgandy m_burgandy;

        /// <summary>
        /// Aggregate of translators
        /// </summary>
        List<ITranslatorBase> m_translators;

        /// <summary>
        /// Private constructor since there can only be 
        /// one Ron Burgandy....
        /// </summary>
        RonBurgandy()
        {
            m_translators = new List<ITranslatorBase>();
        }

        /// <summary>
        /// Adds a translator.
        /// </summary>
        /// <param name="translator">Guy that knows how to translate news...</param>
        public void RegisterTranslator(ITranslatorBase translator)
        {
            m_translators.Add(translator);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="telepromptMessage"></param>
        public void SaySomething(string telepromptMessage)
        {
            // Iterate through the translators and 
            // broadcast a message for them to syndicate 
            // and translate into their own language.
            foreach (ITranslatorBase translator in m_translators)
            {
                string translatedMessage = translator.TranslateNews(telepromptMessage);
                Console.WriteLine("\t{0}  - {1}", 
                                        translator.Name,
                                        translatedMessage);
            }
        }

        /// <summary>
        /// singleton pattern.
        /// </summary>
        /// <returns></returns>
        public static RonBurgandy GetInstance()
        {
            if (m_burgandy == null)
            {
                m_burgandy = new RonBurgandy();
            }
            return m_burgandy;
        }
    }

    /// <summary>
    /// Startup object.
    /// </summary>
    static class Program
    {        
        /// <summary>
        /// Entry point for the application.
        /// </summary>
        static void Main()
        {

            // This guy is the message we want to send to the world...
            string newsMessage = "";

            // Get the singleton instance of Ron B.
            RonBurgandy ron = RonBurgandy.GetInstance();

            for (int i = 0; i < 100; i++)
            { 
                // Create a new English translator for the people
                ITranslatorBase english = new BrickTranslator();
                ron.RegisterTranslator(english);
                ITranslatorBase champ = new ChampTranslator();
                ron.RegisterTranslator(champ);
            }

            while (newsMessage != "quit")
            {
                // get the input from the user
                Console.WriteLine("teleprompter>>");
                newsMessage = Console.ReadLine();
                
                // Tell the broad caster what to say...
                ron.SaySomething(newsMessage);                
            }
        }
    }
}
