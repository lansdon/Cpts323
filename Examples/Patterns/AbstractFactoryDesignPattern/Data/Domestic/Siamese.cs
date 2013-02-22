
namespace ZooApplication.Data.Domestic
{
   
    /// <summary>
    /// Simple House Cat
    /// </summary>
    public sealed class SiameseCat : Animal
    {
        public SiameseCat(int metabolism, string name) :
            base(metabolism, name)
        {
            m_animalImage = global::ZooApplication.Properties.Resources.siamese;
        }
        /// <summary>
        /// Speaks a nice endearing meow
        /// </summary>
        /// <returns>Text of meow that was said.</returns>
        protected override string Speak()
        {
            return "meeeoooww";
        }
    }   
}
