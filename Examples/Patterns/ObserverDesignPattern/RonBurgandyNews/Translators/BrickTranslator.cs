
namespace ObserverExample1.Translators
{
    /// <summary>
    /// English translator...
    /// </summary>
    public class BrickTranslator: ITranslatorBase
    {

        /// <summary>
        /// Translates the message from English into English.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string TranslateNews(string message)
        {
            return string.Format("I love LAMP! {0}", message);
        }

        /// <summary>
        /// Gets the name of the translator.
        /// </summary>
        public string Name
        {
            get { return "Brick..."; }
        }
    }



}
