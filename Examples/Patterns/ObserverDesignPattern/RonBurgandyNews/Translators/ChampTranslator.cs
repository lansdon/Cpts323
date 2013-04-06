using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample1.Translators
{
    public class ChampTranslator: ITranslatorBase
    {
        /// <summary>
        /// Translates 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string TranslateNews(string message)
        {

            string newMessage = "";
            for (int i = 0; i < message.Length; i ++)
            {
                if ((i % 2) == 0)
                    newMessage += message[i].ToString().ToUpper();
                else
                    newMessage += message[i].ToString().ToLower();
            }
            return newMessage; 
        }
        /// <summary>
        /// Gets the name of Champ translator.
        /// </summary>
        public string Name
        {
            get 
            {
                 return "Champ";
            }
        }
    }
}
