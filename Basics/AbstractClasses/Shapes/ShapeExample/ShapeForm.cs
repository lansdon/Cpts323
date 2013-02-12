using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeExample.Shapes;

namespace ShapeExample
{
    /// <summary>
    /// User interface for main window.
    /// </summary>
    public partial class ShapeForm : Form
    {
        #region Members
        /// <summary>
        /// List of available shapes
        /// </summary>
        private List<Shape> m_shapes;
        /// <summary>
        /// Randomizer for shape location.
        /// </summary>
        private Random m_random;
        /// <summary>
        /// Size of the shapes.
        /// </summary>
        private int m_size;
        #endregion
       
        /// <summary>
        /// Default form constructor.
        /// </summary>
        public ShapeForm()
        {
            InitializeComponent();

            m_size                   = 50;
            m_renderPanel.Anchor     = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right;
            m_random                 = new Random();

            m_shapes                 = new List<Shape>();
            m_renderPanel.Paint     += new PaintEventHandler(m_renderPanel_Paint);
            m_renderPanel.Resize    += new EventHandler(m_renderPanel_Resize);

            cloneButton.Enabled = false;

         }

        #region Methods
        /// <summary>
        /// Randomizes the shape locations.
        /// </summary>
        private void Randomize()
        {
            foreach (Shape shape in m_shapes)
            {
                shape.Location = CreateRandomLocation();
            }
            Refresh();
        }    
        /// <summary>
        /// Creates a random Point.
        /// </summary>
        /// <returns></returns>
        private Point CreateRandomLocation()
        {
            return new Point(m_random.Next(0, Width - m_size), m_random.Next(0, Height - m_size));
        }
        #endregion

        #region Form Event Handlers
        /// <summary>
        /// Renders all shapes when the form repaints (refreshed).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_renderPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
            }

            foreach (Shape shape in m_shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
        /// <summary>
        /// Handles the resize event, randomizes the location of the shapes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_renderPanel_Resize(object sender, EventArgs e)
        {
            Randomize();
        }
        /// <summary>
        /// Adds a shape to the list of underlying shapes.
        /// </summary>
        /// <param name="shape"></param>
        public void AddShape(Shape shape)
        {
            DialogResult result = m_colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                shape.Size          = new System.Drawing.Size(m_size, m_size);
                shape.Location      = CreateRandomLocation();
                shape.ShouldFill    = m_fill.Checked;
                shape.Color         = m_colorDialog.Color;
                m_shapes.Add(shape);

                cloneButton.Enabled = true;

                // Force the control to update.
                Refresh();
            }
        }
        /// <summary>
        /// Prompts the user for a color and then adds a circle shape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_circle_Click(object sender, EventArgs e)
        {
            AddShape(new Circle());
        }
        /// <summary>
        /// Prompts the user for a color and then adds a square shape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_square_Click(object sender, EventArgs e)
        {
            AddShape(new Square());            
        }
        /// <summary>
        /// Randomizes the shape locations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_randomize_Click(object sender, EventArgs e)
        {
            Randomize();
        }
        #endregion

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (m_shapes.Count > 0)
            {
                Shape shape = m_shapes[m_shapes.Count - 1].Clone() as Shape;
                m_shapes.Add(shape);
                Refresh();
            }
        }
    }
}
