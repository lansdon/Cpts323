namespace WindowsFormsApplication1
{
    partial class ZooView
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
            this.components = new System.ComponentModel.Container();
            this.AnimalFactorySelectorBox = new System.Windows.Forms.ComboBox();
            this.AnimalFactoryButton = new System.Windows.Forms.Button();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.AnimalTypeBox = new System.Windows.Forms.ComboBox();
            this.FeedAnimalsButton = new System.Windows.Forms.Button();
            this.AnimalTypeLabel = new System.Windows.Forms.Label();
            this.AnimalFactoryTypeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.zooTab = new System.Windows.Forms.TabPage();
            this.zooPanel = new System.Windows.Forms.Panel();
            this.AnimalDetails = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearAnimalsButton = new System.Windows.Forms.Button();
            this.FeedTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.zooTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalFactorySelectorBox
            // 
            this.AnimalFactorySelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalFactorySelectorBox.FormattingEnabled = true;
            this.AnimalFactorySelectorBox.Location = new System.Drawing.Point(23, 52);
            this.AnimalFactorySelectorBox.Name = "AnimalFactorySelectorBox";
            this.AnimalFactorySelectorBox.Size = new System.Drawing.Size(140, 21);
            this.AnimalFactorySelectorBox.TabIndex = 1;
            // 
            // AnimalFactoryButton
            // 
            this.AnimalFactoryButton.Location = new System.Drawing.Point(23, 79);
            this.AnimalFactoryButton.Name = "AnimalFactoryButton";
            this.AnimalFactoryButton.Size = new System.Drawing.Size(138, 31);
            this.AnimalFactoryButton.TabIndex = 2;
            this.AnimalFactoryButton.Text = "Set Animal Factory Type";
            this.AnimalFactoryButton.UseVisualStyleBackColor = true;
            this.AnimalFactoryButton.Click += new System.EventHandler(this.AnimalFactoryButton_Click);
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(25, 219);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(138, 31);
            this.AddAnimalButton.TabIndex = 3;
            this.AddAnimalButton.Text = "Add Animal";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            this.AddAnimalButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // AnimalTypeBox
            // 
            this.AnimalTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalTypeBox.FormattingEnabled = true;
            this.AnimalTypeBox.Location = new System.Drawing.Point(25, 192);
            this.AnimalTypeBox.Name = "AnimalTypeBox";
            this.AnimalTypeBox.Size = new System.Drawing.Size(140, 21);
            this.AnimalTypeBox.TabIndex = 4;
            // 
            // FeedAnimalsButton
            // 
            this.FeedAnimalsButton.Location = new System.Drawing.Point(27, 491);
            this.FeedAnimalsButton.Name = "FeedAnimalsButton";
            this.FeedAnimalsButton.Size = new System.Drawing.Size(138, 31);
            this.FeedAnimalsButton.TabIndex = 5;
            this.FeedAnimalsButton.Text = "Feed All";
            this.FeedAnimalsButton.UseVisualStyleBackColor = true;
            this.FeedAnimalsButton.Click += new System.EventHandler(this.FeedAnimalsButton_Click);
            // 
            // AnimalTypeLabel
            // 
            this.AnimalTypeLabel.AutoSize = true;
            this.AnimalTypeLabel.Location = new System.Drawing.Point(24, 176);
            this.AnimalTypeLabel.Name = "AnimalTypeLabel";
            this.AnimalTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.AnimalTypeLabel.TabIndex = 6;
            this.AnimalTypeLabel.Text = "Animal Type";
            // 
            // AnimalFactoryTypeLabel
            // 
            this.AnimalFactoryTypeLabel.AutoSize = true;
            this.AnimalFactoryTypeLabel.Location = new System.Drawing.Point(24, 36);
            this.AnimalFactoryTypeLabel.Name = "AnimalFactoryTypeLabel";
            this.AnimalFactoryTypeLabel.Size = new System.Drawing.Size(69, 13);
            this.AnimalFactoryTypeLabel.TabIndex = 7;
            this.AnimalFactoryTypeLabel.Text = "Factory Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.zooTab);
            this.tabControl1.Location = new System.Drawing.Point(209, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 500);
            this.tabControl1.TabIndex = 9;
            // 
            // zooTab
            // 
            this.zooTab.Controls.Add(this.zooPanel);
            this.zooTab.Location = new System.Drawing.Point(4, 22);
            this.zooTab.Name = "zooTab";
            this.zooTab.Padding = new System.Windows.Forms.Padding(3);
            this.zooTab.Size = new System.Drawing.Size(489, 474);
            this.zooTab.TabIndex = 0;
            this.zooTab.Text = "Animal View";
            this.zooTab.UseVisualStyleBackColor = true;
            // 
            // zooPanel
            // 
            this.zooPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zooPanel.Location = new System.Drawing.Point(3, 3);
            this.zooPanel.Name = "zooPanel";
            this.zooPanel.Size = new System.Drawing.Size(483, 468);
            this.zooPanel.TabIndex = 2;
            // 
            // AnimalDetails
            // 
            this.AnimalDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimalDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.columnHeader1,
            this.columnHeader2});
            this.AnimalDetails.GridLines = true;
            this.AnimalDetails.Location = new System.Drawing.Point(712, 74);
            this.AnimalDetails.Name = "AnimalDetails";
            this.AnimalDetails.Size = new System.Drawing.Size(299, 478);
            this.AnimalDetails.TabIndex = 0;
            this.AnimalDetails.UseCompatibleStateImageBehavior = false;
            this.AnimalDetails.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HungerFactor";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Is Angry?";
            // 
            // ClearAnimalsButton
            // 
            this.ClearAnimalsButton.Location = new System.Drawing.Point(27, 271);
            this.ClearAnimalsButton.Name = "ClearAnimalsButton";
            this.ClearAnimalsButton.Size = new System.Drawing.Size(138, 31);
            this.ClearAnimalsButton.TabIndex = 10;
            this.ClearAnimalsButton.Text = "Clear Animals";
            this.ClearAnimalsButton.UseVisualStyleBackColor = true;
            this.ClearAnimalsButton.Click += new System.EventHandler(this.ClearAnimalsButton_Click);
            // 
            // FeedTimer
            // 
            this.FeedTimer.Enabled = true;
            this.FeedTimer.Interval = 500;
            this.FeedTimer.Tick += new System.EventHandler(this.FeedTimer_Tick);
            // 
            // ZooView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 564);
            this.Controls.Add(this.AnimalDetails);
            this.Controls.Add(this.ClearAnimalsButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AnimalFactoryTypeLabel);
            this.Controls.Add(this.AnimalTypeLabel);
            this.Controls.Add(this.FeedAnimalsButton);
            this.Controls.Add(this.AnimalTypeBox);
            this.Controls.Add(this.AddAnimalButton);
            this.Controls.Add(this.AnimalFactoryButton);
            this.Controls.Add(this.AnimalFactorySelectorBox);
            this.Name = "ZooView";
            this.Text = "Zoo!";
            this.tabControl1.ResumeLayout(false);
            this.zooTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AnimalFactorySelectorBox;
        private System.Windows.Forms.Button AnimalFactoryButton;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.ComboBox AnimalTypeBox;
        private System.Windows.Forms.Button FeedAnimalsButton;
        private System.Windows.Forms.Label AnimalTypeLabel;
        private System.Windows.Forms.Label AnimalFactoryTypeLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage zooTab;
        private System.Windows.Forms.Panel zooPanel;
        private System.Windows.Forms.ListView AnimalDetails;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ClearAnimalsButton;
        private System.Windows.Forms.Timer FeedTimer;
    }
}

