namespace EnterpriseSystem
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.ManagerHeader_label = new System.Windows.Forms.Label();
            this.CreateEmployee_button = new System.Windows.Forms.Button();
            this.GetEmployees_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerHeader_label
            // 
            this.ManagerHeader_label.AutoSize = true;
            this.ManagerHeader_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerHeader_label.ForeColor = System.Drawing.Color.White;
            this.ManagerHeader_label.Location = new System.Drawing.Point(12, 32);
            this.ManagerHeader_label.Name = "ManagerHeader_label";
            this.ManagerHeader_label.Size = new System.Drawing.Size(223, 62);
            this.ManagerHeader_label.TabIndex = 3;
            this.ManagerHeader_label.Text = "Manager";
            // 
            // CreateEmployee_button
            // 
            this.CreateEmployee_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateEmployee_button.ForeColor = System.Drawing.Color.White;
            this.CreateEmployee_button.Location = new System.Drawing.Point(12, 124);
            this.CreateEmployee_button.Name = "CreateEmployee_button";
            this.CreateEmployee_button.Size = new System.Drawing.Size(458, 100);
            this.CreateEmployee_button.TabIndex = 4;
            this.CreateEmployee_button.Text = "Create employee";
            this.CreateEmployee_button.UseVisualStyleBackColor = false;
            this.CreateEmployee_button.Click += new System.EventHandler(this.CreateEmployee_button_Click);
            // 
            // GetEmployees_button
            // 
            this.GetEmployees_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GetEmployees_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetEmployees_button.ForeColor = System.Drawing.Color.White;
            this.GetEmployees_button.Location = new System.Drawing.Point(12, 230);
            this.GetEmployees_button.Name = "GetEmployees_button";
            this.GetEmployees_button.Size = new System.Drawing.Size(458, 100);
            this.GetEmployees_button.TabIndex = 5;
            this.GetEmployees_button.Text = "Get employees list";
            this.GetEmployees_button.UseVisualStyleBackColor = false;
            this.GetEmployees_button.Click += new System.EventHandler(this.GetEmployees_button_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.GetEmployees_button);
            this.Controls.Add(this.CreateEmployee_button);
            this.Controls.Add(this.ManagerHeader_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ManagerHeader_label;
        private Button CreateEmployee_button;
        private Button GetEmployees_button;
    }
}