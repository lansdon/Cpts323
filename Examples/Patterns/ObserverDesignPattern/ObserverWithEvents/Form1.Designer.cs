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
            this.catLabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.buttonDog.Location = new System.Drawing.Point(12, 111);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(108, 65);
            this.buttonDog.TabIndex = 2;
            this.buttonDog.Text = "Add Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCow
            // 
            this.buttonCow.Location = new System.Drawing.Point(12, 193);
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
            this.dogLabel.Location = new System.Drawing.Point(178, 128);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(78, 31);
            this.dogLabel.TabIndex = 4;
            this.dogLabel.Text = "Dogs";
            // 
            // cowLabel
            // 
            this.cowLabel.AutoSize = true;
            this.cowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cowLabel.Location = new System.Drawing.Point(178, 206);
            this.cowLabel.Name = "cowLabel";
            this.cowLabel.Size = new System.Drawing.Size(83, 31);
            this.cowLabel.TabIndex = 5;
            this.cowLabel.Text = "Cows";
            // 
            // catLabel2
            // 
            this.catLabel2.AutoSize = true;
            this.catLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel2.Location = new System.Drawing.Point(178, 80);
            this.catLabel2.Name = "catLabel2";
            this.catLabel2.Size = new System.Drawing.Size(71, 31);
            this.catLabel2.TabIndex = 6;
            this.catLabel2.Text = "Cats";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 65);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove Events";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catLabel2);
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
        private System.Windows.Forms.Label catLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

