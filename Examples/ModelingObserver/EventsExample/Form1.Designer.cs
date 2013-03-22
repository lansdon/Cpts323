namespace EventsExample
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
            this.buttonCat = new System.Windows.Forms.Button();
            this.catsLabel = new System.Windows.Forms.Label();
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonCow = new System.Windows.Forms.Button();
            this.dogLabel = new System.Windows.Forms.Label();
            this.cowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCat
            // 
            this.buttonCat.Location = new System.Drawing.Point(12, 12);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(108, 65);
            this.buttonCat.TabIndex = 0;
            this.buttonCat.Text = "Add Cat";
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // catsLabel
            // 
            this.catsLabel.AutoSize = true;
            this.catsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catsLabel.Location = new System.Drawing.Point(178, 38);
            this.catsLabel.Name = "catsLabel";
            this.catsLabel.Size = new System.Drawing.Size(71, 31);
            this.catsLabel.TabIndex = 1;
            this.catsLabel.Text = "Cats";
            // 
            // buttonDog
            // 
            this.buttonDog.Location = new System.Drawing.Point(12, 92);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(108, 65);
            this.buttonDog.TabIndex = 2;
            this.buttonDog.Text = "Add Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCow
            // 
            this.buttonCow.Location = new System.Drawing.Point(12, 174);
            this.buttonCow.Name = "buttonCow";
            this.buttonCow.Size = new System.Drawing.Size(108, 65);
            this.buttonCow.TabIndex = 3;
            this.buttonCow.Text = "Add Cow";
            this.buttonCow.UseVisualStyleBackColor = true;
            this.buttonCow.Click += new System.EventHandler(this.buttonCow_Click);
            // 
            // dogLabel
            // 
            this.dogLabel.AutoSize = true;
            this.dogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogLabel.Location = new System.Drawing.Point(178, 109);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(78, 31);
            this.dogLabel.TabIndex = 4;
            this.dogLabel.Text = "Dogs";
            // 
            // cowLabel
            // 
            this.cowLabel.AutoSize = true;
            this.cowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cowLabel.Location = new System.Drawing.Point(178, 187);
            this.cowLabel.Name = "cowLabel";
            this.cowLabel.Size = new System.Drawing.Size(83, 31);
            this.cowLabel.TabIndex = 5;
            this.cowLabel.Text = "Cows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 255);
            this.Controls.Add(this.cowLabel);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.buttonCow);
            this.Controls.Add(this.buttonDog);
            this.Controls.Add(this.catsLabel);
            this.Controls.Add(this.buttonCat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Label catsLabel;
        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonCow;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.Label cowLabel;
    }
}

