using System.Drawing;

namespace ShapeExample.Shapes
{
    /// <summary>
    /// Draws a circle 
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Square() :
            base(Color.Black)
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="color"></param>
        public Square(Color color) :
            base(color)
        {
        }

        /// <summary>
        /// Draws the shape onto the graphics.
        /// </summary>
        /// <param name="graphics"></param>
        public override void Draw(System.Drawing.Graphics graphics)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                if (!ShouldFill)
                {
                    using (Pen pen = new Pen(brush))
                    {
                        graphics.DrawRectangle(pen, Location.X, Location.Y, Size.Width, Size.Height);
                    }
                }
                else
                {
                    graphics.FillRectangle(brush, Location.X, Location.Y, Size.Width, Size.Height);
                }
            }
        }

        /// <summary>
        /// Clones itself.  Does not adjust the location.
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            Shape circle = new Square();
            circle.Color = Color;
            //circle.Location     = new Point(Location.X + 10, Location.Y + 10);
            circle.Location = Location;
            circle.ShouldFill = ShouldFill;
            circle.Size = Size;
            return circle;
        }
    }
}
