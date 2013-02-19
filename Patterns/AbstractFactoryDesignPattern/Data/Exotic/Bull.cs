using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication.Data.Exotic
{
    /// <summary>
    /// A mean bull
    /// </summary>
    public sealed class Bull: Animal
    {
        public Bull(int metabolism, string name):
            base(metabolism, name)
        {
            m_rangeMovementX = 5;
            m_rangeMovementY = 5;
            m_animalImage    = global::ZooApplication.Properties.Resources.bull;
        }

        /// <summary>
        /// Speaks a really scary noise.
        /// </summary>
        /// <returns>Text version of what the animal noise was</returns>
        protected override string Speak()
        {
            return "grumble";
        }
    }
}
