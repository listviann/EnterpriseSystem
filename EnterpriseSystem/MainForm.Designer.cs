namespace EnterpriseSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginAsManager_button = new System.Windows.Forms.Button();
            this.LoginAsEmployee_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Quit_button = new System.Windows.Forms.Button();
            this.MainFormMenu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonSave_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.xmlSave_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.xmlOpen_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.jsonOpen_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainFormMenu_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginAsManager_button
            // 
            this.LoginAsManager_button.BackColor = System.Drawing.Color.DimGray;
            this.LoginAsManager_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginAsManager_button.ForeColor = System.Drawing.Color.White;
            this.LoginAsManager_button.Location = new System.Drawing.Point(12, 110);
            this.LoginAsManager_button.Name = "LoginAsManager_button";
            this.LoginAsManager_button.Size = new System.Drawing.Size(458, 100);
            this.LoginAsManager_button.TabIndex = 0;
            this.LoginAsManager_button.Text = "Manager";
            this.LoginAsManager_button.UseVisualStyleBackColor = false;
            this.LoginAsManager_button.Click += new System.EventHandler(this.LoginAsManager_button_Click);
            // 
            // LoginAsEmployee_button
            // 
            this.LoginAsEmployee_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginAsEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginAsEmployee_button.ForeColor = System.Drawing.Color.White;
            this.LoginAsEmployee_button.Location = new System.Drawing.Point(12, 216);
            this.LoginAsEmployee_button.Name = "LoginAsEmployee_button";
            this.LoginAsEmployee_button.Size = new System.Drawing.Size(458, 100);
            this.LoginAsEmployee_button.TabIndex = 1;
            this.LoginAsEmployee_button.Text = "Employee";
            this.LoginAsEmployee_button.UseVisualStyleBackColor = false;
            this.LoginAsEmployee_button.Click += new System.EventHandler(this.LoginAsEmployee_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(12, 45);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(231, 62);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Welcome";
            // 
            // Quit_button
            // 
            this.Quit_button.BackColor = System.Drawing.Color.DarkRed;
            this.Quit_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit_button.ForeColor = System.Drawing.Color.White;
            this.Quit_button.Location = new System.Drawing.Point(12, 322);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(458, 100);
            this.Quit_button.TabIndex = 3;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = false;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // MainFormMenu_menuStrip
            // 
            this.MainFormMenu_menuStrip.BackColor = System.Drawing.Color.Black;
            this.MainFormMenu_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormMenu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainFormMenu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenu_menuStrip.Name = "MainFormMenu_menuStrip";
            this.MainFormMenu_menuStrip.Size = new System.Drawing.Size(482, 31);
            this.MainFormMenu_menuStrip.TabIndex = 4;
            this.MainFormMenu_menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonFileToolStripMenuItem,
            this.xmlFileToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // jsonFileToolStripMenuItem
            // 
            this.jsonFileToolStripMenuItem.Name = "jsonFileToolStripMenuItem";
            this.jsonFileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.jsonFileToolStripMenuItem.Text = "Json file";
            this.jsonFileToolStripMenuItem.Click += new System.EventHandler(this.jsonFileToolStripMenuItem_Click);
            // 
            // xmlFileToolStripMenuItem
            // 
            this.xmlFileToolStripMenuItem.Name = "xmlFileToolStripMenuItem";
            this.xmlFileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.xmlFileToolStripMenuItem.Text = "Xml file";
            this.xmlFileToolStripMenuItem.Click += new System.EventHandler(this.xmlFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonFileToolStripMenuItem1,
            this.xmlFileToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // jsonFileToolStripMenuItem1
            // 
            this.jsonFileToolStripMenuItem1.Name = "jsonFileToolStripMenuItem1";
            this.jsonFileToolStripMenuItem1.Size = new System.Drawing.Size(154, 28);
            this.jsonFileToolStripMenuItem1.Text = "Json file";
            this.jsonFileToolStripMenuItem1.Click += new System.EventHandler(this.jsonFileToolStripMenuItem1_Click);
            // 
            // xmlFileToolStripMenuItem1
            // 
            this.xmlFileToolStripMenuItem1.Name = "xmlFileToolStripMenuItem1";
            this.xmlFileToolStripMenuItem1.Size = new System.Drawing.Size(154, 28);
            this.xmlFileToolStripMenuItem1.Text = "Xml file";
            this.xmlFileToolStripMenuItem1.Click += new System.EventHandler(this.xmlFileToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // xmlOpen_openFileDialog
            // 
            this.xmlOpen_openFileDialog.FileName = "openFileDialog1";
            // 
            // jsonOpen_openFileDialog
            // 
            this.jsonOpen_openFileDialog.FileName = "openFileDialog2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.LoginAsEmployee_button);
            this.Controls.Add(this.LoginAsManager_button);
            this.Controls.Add(this.MainFormMenu_menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFormMenu_menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormMenu_menuStrip.ResumeLayout(false);
            this.MainFormMenu_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginAsManager_button;
        private Button LoginAsEmployee_button;
        private Label Welcome_label;
        private Button Quit_button;
        private MenuStrip MainFormMenu_menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem jsonFileToolStripMenuItem;
        private ToolStripMenuItem xmlFileToolStripMenuItem;
        private SaveFileDialog jsonSave_saveFileDialog;
        private SaveFileDialog xmlSave_SaveFileDialog;
        private OpenFileDialog xmlOpen_openFileDialog;
        private OpenFileDialog jsonOpen_openFileDialog;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem jsonFileToolStripMenuItem1;
        private ToolStripMenuItem xmlFileToolStripMenuItem1;
    }
}