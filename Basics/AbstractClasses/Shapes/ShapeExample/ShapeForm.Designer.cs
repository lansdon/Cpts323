namespace ShapeExample
{
    partial class ShapeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_renderPanel = new System.Windows.Forms.Panel();
            this.m_circle = new System.Windows.Forms.Button();
            this.m_square = new System.Windows.Forms.Button();
            this.m_colorDialog = new System.Windows.Forms.ColorDialog();
            this.m_randomize = new System.Windows.Forms.Button();
            this.m_fill = new System.Windows.Forms.CheckBox();
            this.cloneButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_renderPanel
            // 
            this.m_renderPanel.AutoSize = true;
            this.m_renderPanel.BackColor = System.Drawing.Color.White;
            this.m_renderPanel.Location = new System.Drawing.Point(9, 9);
            this.m_renderPanel.Name = "m_renderPanel";
            this.m_renderPanel.Size = new System.Drawing.Size(633, 462);
            this.m_renderPanel.TabIndex = 0;
            // 
            // m_circle
            // 
            this.m_circle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_circle.Location = new System.Drawing.Point(9, 486);
            this.m_circle.Name = "m_circle";
            this.m_circle.Size = new System.Drawing.Size(103, 36);
            this.m_circle.TabIndex = 1;
            this.m_circle.Text = "Circle";
            this.m_circle.UseVisualStyleBackColor = true;
            this.m_circle.Click += new System.EventHandler(this.m_circle_Click);
            // 
            // m_square
            // 
            this.m_square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_square.Location = new System.Drawing.Point(118, 486);
            this.m_square.Name = "m_square";
            this.m_square.Size = new System.Drawing.Size(103, 36);
            this.m_square.TabIndex = 2;
            this.m_square.Text = "Square";
            this.m_square.UseVisualStyleBackColor = true;
            this.m_square.Click += new System.EventHandler(this.m_square_Click);
            // 
            // m_randomize
            // 
            this.m_randomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_randomize.Location = new System.Drawing.Point(227, 486);
            this.m_randomize.Name = "m_randomize";
            this.m_randomize.Size = new System.Drawing.Size(103, 36);
            this.m_randomize.TabIndex = 3;
            this.m_randomize.Text = "Randomize";
            this.m_randomize.UseVisualStyleBackColor = true;
            this.m_randomize.Click += new System.EventHandler(this.m_randomize_Click);
            // 
            // m_fill
            // 
            this.m_fill.AutoSize = true;
            this.m_fill.Location = new System.Drawing.Point(586, 497);
            this.m_fill.Name = "m_fill";
            this.m_fill.Size = new System.Drawing.Size(38, 17);
            this.m_fill.TabIndex = 4;
            this.m_fill.Text = "Fill";
            this.m_fill.UseVisualStyleBackColor = true;
            // 
            // cloneButton
            // 
            this.cloneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cloneButton.Location = new System.Drawing.Point(336, 486);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(103, 36);
            this.cloneButton.TabIndex = 5;
            this.cloneButton.Text = "Clone!";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(273, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.m_fill);
            this.Controls.Add(this.m_randomize);
            this.Controls.Add(this.m_square);
            this.Controls.Add(this.m_circle);
            this.Controls.Add(this.m_renderPanel);
            this.Name = "ShapeForm";
            this.Text = "Shape Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_renderPanel;
        private System.Windows.Forms.Button m_circle;
        private System.Windows.Forms.Button m_square;
        private System.Windows.Forms.ColorDialog m_colorDialog;
        private System.Windows.Forms.Button m_randomize;
        private System.Windows.Forms.CheckBox m_fill;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.Button button1;
    }
}

