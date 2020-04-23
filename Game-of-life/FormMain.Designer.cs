namespace Game_of_life
{
    partial class FormMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.startButton = new System.Windows.Forms.Button();
      this.restartButton = new System.Windows.Forms.Button();
      this.geneBox = new System.Windows.Forms.TextBox();
      this.mainPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.buttonPopulate = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.populateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(335, 26);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(77, 23);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Visible = false;
      this.startButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // restartButton
      // 
      this.restartButton.Enabled = false;
      this.restartButton.Location = new System.Drawing.Point(606, 26);
      this.restartButton.Name = "restartButton";
      this.restartButton.Size = new System.Drawing.Size(60, 23);
      this.restartButton.TabIndex = 2;
      this.restartButton.Text = "Restart";
      this.restartButton.UseVisualStyleBackColor = true;
      this.restartButton.Visible = false;
      this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
      // 
      // geneBox
      // 
      this.geneBox.Cursor = System.Windows.Forms.Cursors.Default;
      this.geneBox.Location = new System.Drawing.Point(564, 27);
      this.geneBox.Name = "geneBox";
      this.geneBox.ReadOnly = true;
      this.geneBox.Size = new System.Drawing.Size(36, 20);
      this.geneBox.TabIndex = 2;
      this.geneBox.TabStop = false;
      this.geneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // mainPanel
      // 
      this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPanel.Location = new System.Drawing.Point(0, 24);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(1807, 694);
      this.mainPanel.TabIndex = 3;
      //this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(499, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Generation";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // buttonPopulate
      // 
      this.buttonPopulate.Location = new System.Drawing.Point(418, 26);
      this.buttonPopulate.Name = "buttonPopulate";
      this.buttonPopulate.Size = new System.Drawing.Size(75, 23);
      this.buttonPopulate.TabIndex = 1;
      this.buttonPopulate.Text = "Populate";
      this.buttonPopulate.UseVisualStyleBackColor = true;
      this.buttonPopulate.Visible = false;
      this.buttonPopulate.Click += new System.EventHandler(this.ButtonPopulate_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(717, 26);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(79, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Set Interval";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.ButtonSetInterval_Click);
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(672, 28);
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
      this.numericUpDown1.TabIndex = 3;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.startToolStripMenuItem,
            this.populateToolStripMenuItem1,
            this.restartToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1807, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
      // 
      // startToolStripMenuItem
      // 
      this.startToolStripMenuItem.Name = "startToolStripMenuItem";
      this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.startToolStripMenuItem.Text = "Start";
      this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
      // 
      // populateToolStripMenuItem1
      // 
      this.populateToolStripMenuItem1.Name = "populateToolStripMenuItem1";
      this.populateToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
      this.populateToolStripMenuItem1.Text = "Populate";
      this.populateToolStripMenuItem1.Click += new System.EventHandler(this.PopulateToolStripMenuItem1_Click);
      // 
      // restartToolStripMenuItem
      // 
      this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
      this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.restartToolStripMenuItem.Text = "Restart";
      this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1807, 718);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.restartButton);
      this.Controls.Add(this.buttonPopulate);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.geneBox);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Conway\'s Game of Life";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox geneBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem populateToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
  }
}

