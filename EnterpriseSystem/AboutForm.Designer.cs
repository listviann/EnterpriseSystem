namespace EnterpriseSystem
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutInfo_label = new System.Windows.Forms.Label();
            this.Info_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AboutInfo_label
            // 
            this.AboutInfo_label.AutoSize = true;
            this.AboutInfo_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AboutInfo_label.ForeColor = System.Drawing.Color.White;
            this.AboutInfo_label.Location = new System.Drawing.Point(69, 19);
            this.AboutInfo_label.Name = "AboutInfo_label";
            this.AboutInfo_label.Size = new System.Drawing.Size(422, 62);
            this.AboutInfo_label.TabIndex = 13;
            this.AboutInfo_label.Text = "About application";
            // 
            // Info_richTextBox
            // 
            this.Info_richTextBox.Location = new System.Drawing.Point(12, 84);
            this.Info_richTextBox.Name = "Info_richTextBox";
            this.Info_richTextBox.ReadOnly = true;
            this.Info_richTextBox.Size = new System.Drawing.Size(578, 410);
            this.Info_richTextBox.TabIndex = 14;
            this.Info_richTextBox.Text = "";
            this.Info_richTextBox.TextChanged += new System.EventHandler(this.Info_richTextBox_TextChanged);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(602, 548);
            this.Controls.Add(this.Info_richTextBox);
            this.Controls.Add(this.AboutInfo_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 595);
            this.MinimumSize = new System.Drawing.Size(620, 595);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AboutInfo_label;
        private RichTextBox Info_richTextBox;
    }
}