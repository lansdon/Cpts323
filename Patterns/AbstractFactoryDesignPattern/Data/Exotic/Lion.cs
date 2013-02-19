using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication.Data.Exotic
{
    /// <summary>
    /// A ferocious line
    /// </summary>
    public sealed class Lion: Animal
    {
        public Lion(int metabolism, string name):
            base(metabolism, name)
        {
            m_rangeMovementX = 20;
            m_rangeMovementY = 15;
            m_animalImage = global::ZooApplication.Properties.Resources.lion;
        }
        /// <summary>
        /// Makes a really scary growling sound
        /// </summary>
        /// <returns>Text version of what was said</returns>
        protected override string Speak()
        {
            return "rawr...";
        }
    }
}
