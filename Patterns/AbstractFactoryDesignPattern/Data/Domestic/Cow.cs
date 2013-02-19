
namespace ZooApplication.Data.Domestic
{
    /// <summary>
    /// Pasture cow that is harmless and likes to be tipped.
    /// </summary>
    public sealed class Cow: Animal
    {
        /// <summary>
        /// Constructor for a nice cow
        /// </summary>
        /// <param name="metabolism"></param>
        /// <param name="name"></param>
        public Cow(int metabolism, string name) :
            base(metabolism, name)
        {
            m_rangeMovementX = 1;
            m_rangeMovementY = 2;
            m_animalImage = global::ZooApplication.Properties.Resources.cow;
        }
        /// <summary>
        /// Makes a moooooooo!
        /// </summary>
        /// <returns></returns>
        protected override string Speak()
        {
            PlaySpeech();
            return "moooo!";
        }
    }
}
