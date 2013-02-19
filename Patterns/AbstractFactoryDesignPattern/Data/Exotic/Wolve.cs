
namespace ZooApplication.Data.Exotic
{    
    /// <summary>
    /// A scary wolve
    /// </summary>
    public sealed class Wolve : Animal
    {
        public Wolve(int metabolism, string name) :
            base(metabolism, name)
        {
            m_animalImage = global::ZooApplication.Properties.Resources.wolf;
        }
        /// <summary>
        /// Makes a call to arms
        /// </summary>
        /// <returns>Text version of what was said</returns>
        protected override string Speak()
        {
            return "whooooooooooooooooooo";
        }
    }
}
