namespace WindowsFormsExample
{
    partial class MainForm
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
            this.displayTextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.moveItTimer = new System.Windows.Forms.Timer(this.components);
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDisplaySomeControls = new System.Windows.Forms.Button();
            this.buttonHideSomeControls = new System.Windows.Forms.Button();
            this.someControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.selectedDogLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetExample4 = new WindowsFormsExample.TargetExample();
            this.targetExample3 = new WindowsFormsExample.TargetExample();
            this.targetExample1 = new WindowsFormsExample.TargetExample();
            this.targetExample2 = new WindowsFormsExample.TargetExample();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.someControlsGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTextButton
            // 
            this.displayTextButton.Location = new System.Drawing.Point(865, 129);
            this.displayTextButton.Name = "displayTextButton";
            this.displayTextButton.Size = new System.Drawing.Size(146, 88);
            this.displayTextButton.TabIndex = 0;
            this.displayTextButton.Text = "Display Some Text";
            this.displayTextButton.UseVisualStyleBackColor = true;
            this.displayTextButton.Click += new System.EventHandler(this.displayTextButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Move It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveItDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveItUp);
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.Location = new System.Drawing.Point(173, 119);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(149, 39);
            this.timeElapsedLabel.TabIndex = 2;
            this.timeElapsedLabel.Text = "press it!";
            // 
            // moveItTimer
            // 
            this.moveItTimer.Interval = 500;
            this.moveItTimer.Tick += new System.EventHandler(this.moveItTimer_Tick);
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationLabel.Location = new System.Drawing.Point(173, 178);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(242, 39);
            this.accelerationLabel.TabIndex = 3;
            this.accelerationLabel.Text = "Acceleration: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 254);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 356);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.targetExample4);
            this.tabPage1.Controls.Add(this.targetExample3);
            this.tabPage1.Controls.Add(this.targetExample1);
            this.tabPage1.Controls.Add(this.targetExample2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Control Example";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDisplaySomeControls);
            this.tabPage2.Controls.Add(this.buttonHideSomeControls);
            this.tabPage2.Controls.Add(this.someControlsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visibility Example";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDisplaySomeControls
            // 
            this.buttonDisplaySomeControls.Location = new System.Drawing.Point(29, 106);
            this.buttonDisplaySomeControls.Name = "buttonDisplaySomeControls";
            this.buttonDisplaySomeControls.Size = new System.Drawing.Size(146, 51);
            this.buttonDisplaySomeControls.TabIndex = 8;
            this.buttonDisplaySomeControls.Text = "Display Some Controls";
            this.buttonDisplaySomeControls.UseVisualStyleBackColor = true;
            // 
            // buttonHideSomeControls
            // 
            this.buttonHideSomeControls.Location = new System.Drawing.Point(29, 40);
            this.buttonHideSomeControls.Name = "buttonHideSomeControls";
            this.buttonHideSomeControls.Size = new System.Drawing.Size(146, 51);
            this.buttonHideSomeControls.TabIndex = 6;
            this.buttonHideSomeControls.Text = "Hide Some Controls";
            this.buttonHideSomeControls.UseVisualStyleBackColor = true;
            // 
            // someControlsGroupBox
            // 
            this.someControlsGroupBox.Controls.Add(this.buttonShowText);
            this.someControlsGroupBox.Location = new System.Drawing.Point(197, 29);
            this.someControlsGroupBox.Name = "someControlsGroupBox";
            this.someControlsGroupBox.Size = new System.Drawing.Size(344, 172);
            this.someControlsGroupBox.TabIndex = 7;
            this.someControlsGroupBox.TabStop = false;
            this.someControlsGroupBox.Text = "Some Controls";
            // 
            // buttonShowText
            // 
            this.buttonShowText.Location = new System.Drawing.Point(22, 40);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.Size = new System.Drawing.Size(146, 88);
            this.buttonShowText.TabIndex = 1;
            this.buttonShowText.Text = "Display Some Text";
            this.buttonShowText.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.selectedDogLabel);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1024, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Box Example";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add a dog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(552, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 209);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // selectedDogLabel
            // 
            this.selectedDogLabel.AutoSize = true;
            this.selectedDogLabel.Location = new System.Drawing.Point(20, 271);
            this.selectedDogLabel.Name = "selectedDogLabel";
            this.selectedDogLabel.Size = new System.Drawing.Size(108, 13);
            this.selectedDogLabel.TabIndex = 3;
            this.selectedDogLabel.Text = "Selected Dog\'s name";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dog\'s Name";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dog\'s Age";
            this.columnHeader2.Width = 98;
            // 
            // targetExample4
            // 
            this.targetExample4.Location = new System.Drawing.Point(281, 6);
            this.targetExample4.Name = "targetExample4";
            this.targetExample4.Size = new System.Drawing.Size(150, 150);
            this.targetExample4.TabIndex = 9;
            this.targetExample4.TargetName = "";
            // 
            // targetExample3
            // 
            this.targetExample3.Location = new System.Drawing.Point(416, 6);
            this.targetExample3.Name = "targetExample3";
            this.targetExample3.Size = new System.Drawing.Size(150, 150);
            this.targetExample3.TabIndex = 8;
            this.targetExample3.TargetName = "";
            // 
            // targetExample1
            // 
            this.targetExample1.Location = new System.Drawing.Point(138, 6);
            this.targetExample1.Name = "targetExample1";
            this.targetExample1.Size = new System.Drawing.Size(150, 150);
            this.targetExample1.TabIndex = 6;
            this.targetExample1.TargetName = "";
            // 
            // targetExample2
            // 
            this.targetExample2.Location = new System.Drawing.Point(6, 6);
            this.targetExample2.Name = "targetExample2";
            this.targetExample2.Size = new System.Drawing.Size(150, 150);
            this.targetExample2.TabIndex = 7;
            this.targetExample2.TargetName = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 610);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.accelerationLabel);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayTextButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Should work";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.someControlsGroupBox.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayTextButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Timer moveItTimer;
        private System.Windows.Forms.Label accelerationLabel;
        private TargetExample targetExample1;
        private TargetExample targetExample2;
        private TargetExample targetExample3;
        private TargetExample targetExample4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDisplaySomeControls;
        private System.Windows.Forms.Button buttonHideSomeControls;
        private System.Windows.Forms.GroupBox someControlsGroupBox;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label selectedDogLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

