namespace EnterpriseSystem
{
    partial class GetEmployeesForm
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
            this.EditEmployee_button = new System.Windows.Forms.Button();
            this.DeleteEmployee_button = new System.Windows.Forms.Button();
            this.Employees_listBox = new System.Windows.Forms.ListBox();
            this.GetEmployees_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditEmployee_button
            // 
            this.EditEmployee_button.BackColor = System.Drawing.Color.Orchid;
            this.EditEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditEmployee_button.ForeColor = System.Drawing.Color.White;
            this.EditEmployee_button.Location = new System.Drawing.Point(12, 471);
            this.EditEmployee_button.Name = "EditEmployee_button";
            this.EditEmployee_button.Size = new System.Drawing.Size(216, 65);
            this.EditEmployee_button.TabIndex = 13;
            this.EditEmployee_button.Text = "Edit";
            this.EditEmployee_button.UseVisualStyleBackColor = false;
            this.EditEmployee_button.Click += new System.EventHandler(this.EditEmployee_button_Click);
            // 
            // DeleteEmployee_button
            // 
            this.DeleteEmployee_button.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteEmployee_button.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployee_button.Location = new System.Drawing.Point(254, 471);
            this.DeleteEmployee_button.Name = "DeleteEmployee_button";
            this.DeleteEmployee_button.Size = new System.Drawing.Size(216, 65);
            this.DeleteEmployee_button.TabIndex = 14;
            this.DeleteEmployee_button.Text = "Delete";
            this.DeleteEmployee_button.UseVisualStyleBackColor = false;
            this.DeleteEmployee_button.Click += new System.EventHandler(this.DeleteEmployee_button_Click);
            // 
            // Employees_listBox
            // 
            this.Employees_listBox.FormattingEnabled = true;
            this.Employees_listBox.HorizontalScrollbar = true;
            this.Employees_listBox.ItemHeight = 20;
            this.Employees_listBox.Location = new System.Drawing.Point(12, 81);
            this.Employees_listBox.Name = "Employees_listBox";
            this.Employees_listBox.Size = new System.Drawing.Size(458, 384);
            this.Employees_listBox.TabIndex = 15;
            this.Employees_listBox.SelectedIndexChanged += new System.EventHandler(this.Employees_listBox_SelectedIndexChanged);
            // 
            // GetEmployees_label
            // 
            this.GetEmployees_label.AutoSize = true;
            this.GetEmployees_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetEmployees_label.ForeColor = System.Drawing.Color.White;
            this.GetEmployees_label.Location = new System.Drawing.Point(12, 12);
            this.GetEmployees_label.Name = "GetEmployees_label";
            this.GetEmployees_label.Size = new System.Drawing.Size(351, 62);
            this.GetEmployees_label.TabIndex = 16;
            this.GetEmployees_label.Text = "Get employees";
            // 
            // GetEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(482, 548);
            this.Controls.Add(this.GetEmployees_label);
            this.Controls.Add(this.Employees_listBox);
            this.Controls.Add(this.DeleteEmployee_button);
            this.Controls.Add(this.EditEmployee_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 595);
            this.MinimumSize = new System.Drawing.Size(500, 595);
            this.Name = "GetEmployeesForm";
            this.Text = "GetEmployeesForm";
            this.Load += new System.EventHandler(this.GetEmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditEmployee_button;
        private Button DeleteEmployee_button;
        private ListBox Employees_listBox;
        private Label GetEmployees_label;
    }
}