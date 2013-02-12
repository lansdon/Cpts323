using System.Collections.ObjectModel;
using System.Drawing;
using GridironMaidenEngine.Targets;

namespace GridironMaidenEngine.Vision
{
    /// <summary>
    /// Interface for image processors.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IImageProcessor
    {
        /// <summary>
        /// Determines if there are targets within the image.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Collection<Target> DetectTargets(Image image);
    }
}
