using System;
using System.Drawing;

namespace ShapeExample.Shapes
{
    /// <summary>
    /// Shape class.  Notice that it implements the ICloneable interface.  This is an implementation of the prototype pattern.
    /// </summary>
    public abstract class Shape: ICloneable
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="color">Color of the shape.</param>
        public Shape(Color color)
        {
            Color = color;
            Location = new Point(0, 0);
        }

        #region Properties
        /// <summary>
        /// Gets or sets whether the shape should be filled.
        /// </summary>
        public bool ShouldFill { get; set; }
        /// <summary>
        /// Gets or sets the shapes color.
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// Gets or sets the location of the shape.
        /// </summary>
        public Point Location { get; set; }
        /// <summary>
        /// Gets or sets the size of the shape.
        /// </summary>
        public Size Size { get; set; }
        #endregion

        /// <summary>
        /// Forces the shape to draw the object.
        /// </summary>
        /// <param name="graphics"></param>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// Returns a copy of self.
        /// </summary>
        /// <returns></returns>
        public abstract object Clone();        
    }
}
