namespace EnterpriseSystem
{
    partial class EmpLoginForm
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
            this.EmpId_label = new System.Windows.Forms.Label();
            this.EmpId_textBox = new System.Windows.Forms.TextBox();
            this.EmpSignIn_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpId_label
            // 
            this.EmpId_label.AutoSize = true;
            this.EmpId_label.Location = new System.Drawing.Point(83, 20);
            this.EmpId_label.Name = "EmpId_label";
            this.EmpId_label.Size = new System.Drawing.Size(139, 20);
            this.EmpId_label.TabIndex = 0;
            this.EmpId_label.Text = "Enter employee\'s id";
            // 
            // EmpId_textBox
            // 
            this.EmpId_textBox.Location = new System.Drawing.Point(83, 43);
            this.EmpId_textBox.Name = "EmpId_textBox";
            this.EmpId_textBox.Size = new System.Drawing.Size(139, 27);
            this.EmpId_textBox.TabIndex = 1;
            this.EmpId_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpId_textBox_KeyPress);
            // 
            // EmpSignIn_button
            // 
            this.EmpSignIn_button.Location = new System.Drawing.Point(83, 83);
            this.EmpSignIn_button.Name = "EmpSignIn_button";
            this.EmpSignIn_button.Size = new System.Drawing.Size(139, 32);
            this.EmpSignIn_button.TabIndex = 2;
            this.EmpSignIn_button.Text = "Sign in";
            this.EmpSignIn_button.UseVisualStyleBackColor = true;
            this.EmpSignIn_button.Click += new System.EventHandler(this.EmpSignIn_button_Click);
            // 
            // EmpLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 127);
            this.Controls.Add(this.EmpSignIn_button);
            this.Controls.Add(this.EmpId_textBox);
            this.Controls.Add(this.EmpId_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 174);
            this.Name = "EmpLoginForm";
            this.Text = "EmpLoginForm";
            this.Load += new System.EventHandler(this.EmpLoginForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpId_textBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmpId_label;
        private TextBox EmpId_textBox;
        private Button EmpSignIn_button;
    }
}