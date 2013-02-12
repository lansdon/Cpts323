using System;
using System.Drawing;
using System.Collections.Generic;

using ExternalShapeLibrary;

namespace ShapeExample.Shapes
{
    public class UgliestImageAdapter: Shape
    {
        private MyBigUglyImageClass m_adaptee;

        /// <summary>
        /// Constructor.
        /// </summary>
        public UgliestImageAdapter():
            base(Color.Black)
        {
            m_adaptee = new MyBigUglyImageClass();
        }

        public UgliestImageAdapter(Color color):
            base(color)
        {
            m_adaptee = new MyBigUglyImageClass();
        }
            
        public override void Draw(System.Drawing.Graphics graphics)
        {
            graphics.DrawImage(m_adaptee.MyImage, Location);   
        }

        public override object Clone()
        {
            return this;
        }
    }
}
