using System.Drawing;

namespace ASMLEngineSdk
{
    /// <summary>
    /// Interface for controlling a missile launcher.
    /// </summary>
    public interface IVideo
    {
        /// <summary>
        /// Moves the missile launcher by a relative amount.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="phi"></param>
        Image GetImage();        
    }
}
