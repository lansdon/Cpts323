using System.Drawing;

namespace ShapeExample.Shapes
{
    /// <summary>
    /// Draws a circle 
    /// </summary>
    public class Circle: Shape
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Circle(): 
            base(Color.Black)
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="color"></param>
        public Circle(Color color): 
            base (color)
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
                        graphics.DrawEllipse(pen, Location.X, Location.Y, Size.Width, Size.Height);
                    }
                }
                else
                {
                    graphics.FillEllipse(brush, Location.X, Location.Y, Size.Width, Size.Height);
                }
            }
        }

        /// <summary>
        /// Clones self, and offsets it's clones location.  
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            Shape circle = new Circle();
            circle.Color        = Color;
            circle.Location     = new Point(Location.X + 10, Location.Y + 10);
            //circle.Location     = Location;
            circle.ShouldFill   = ShouldFill;
            circle.Size         = Size;
            return circle;
        }
    }
}
