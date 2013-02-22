
namespace ZooApplication.Data.Domestic
{
    /// <summary>
    /// Man's best friend
    /// </summary>
    public sealed class Labrador : Animal
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="metabolism"></param>
        /// <param name="name"></param>
        public Labrador(int metabolism, string name) :
            base(metabolism, name)
        {
            m_animalImage = global::ZooApplication.Properties.Resources.labrador;
        }
        /// <summary>
        /// Speaks a nice bark
        /// </summary>
        /// <returns>Text version of the bark.</returns>
        protected override string Speak()
        {
            return "bow-wow";
        }
    }
}
