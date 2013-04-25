using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLEngineSdk
{
    /// <summary>
    /// Interface for validating that a target was hit.
    /// </summary>
    public interface ITargetValidator
    {
        /// <summary>
        /// Starts listening for any potential validations.
        /// </summary>
        void Start();
        /// <summary>
        /// Stops listening for any potential validations.
        /// </summary>
        void Stop();
        /// <summary>
        /// Resets the underlying validation scheme.
        /// </summary>
        void Reset();
        /// <summary>
        /// Retrieves data to see if a target was hit.
        /// </summary>
        /// <param name="name"></param>
        bool WasTargetHit(string name);
    }
}
