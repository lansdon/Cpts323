namespace ThreadingExample
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_getDataButton = new System.Windows.Forms.Button();
            this.m_dataLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop Thread";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // m_getDataButton
            // 
            this.m_getDataButton.Location = new System.Drawing.Point(12, 183);
            this.m_getDataButton.Name = "m_getDataButton";
            this.m_getDataButton.Size = new System.Drawing.Size(84, 51);
            this.m_getDataButton.TabIndex = 2;
            this.m_getDataButton.Text = "Get Data";
            this.m_getDataButton.UseVisualStyleBackColor = true;
            this.m_getDataButton.Click += new System.EventHandler(this.m_getDataButton_Click);
            // 
            // m_dataLabel
            // 
            this.m_dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dataLabel.Location = new System.Drawing.Point(16, 107);
            this.m_dataLabel.Name = "m_dataLabel";
            this.m_dataLabel.Size = new System.Drawing.Size(169, 58);
            this.m_dataLabel.TabIndex = 3;
            this.m_dataLabel.Text = "READY!";
            this.m_dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 195);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.m_dataLabel);
            this.Controls.Add(this.m_getDataButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button m_getDataButton;
        private System.Windows.Forms.Label m_dataLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

