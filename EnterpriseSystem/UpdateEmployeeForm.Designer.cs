namespace EnterpriseSystem
{
    partial class UpdateEmployeeForm
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
            this.DateFields_panel = new System.Windows.Forms.Panel();
            this.EmployeeBirthDay_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthMonth_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthYear_textBox = new System.Windows.Forms.TextBox();
            this.EmployeePosition_label = new System.Windows.Forms.Label();
            this.EmployeeBirthDate_label = new System.Windows.Forms.Label();
            this.ClearFields_button = new System.Windows.Forms.Button();
            this.EditEmployee_button = new System.Windows.Forms.Button();
            this.EmployeePosition_comboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeSalary_textBox = new System.Windows.Forms.TextBox();
            this.EmployeePhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeEmail_textBox = new System.Windows.Forms.TextBox();
            this.EditEmployee_label = new System.Windows.Forms.Label();
            this.EmployeeName_textBox = new System.Windows.Forms.TextBox();
            this.DateFields_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFields_panel
            // 
            this.DateFields_panel.Controls.Add(this.EmployeeBirthDay_textBox);
            this.DateFields_panel.Controls.Add(this.EmployeeBirthMonth_textBox);
            this.DateFields_panel.Controls.Add(this.EmployeeBirthYear_textBox);
            this.DateFields_panel.Location = new System.Drawing.Point(12, 253);
            this.DateFields_panel.Name = "DateFields_panel";
            this.DateFields_panel.Size = new System.Drawing.Size(224, 33);
            this.DateFields_panel.TabIndex = 32;
            // 
            // EmployeeBirthDay_textBox
            // 
            this.EmployeeBirthDay_textBox.Location = new System.Drawing.Point(3, 3);
            this.EmployeeBirthDay_textBox.MaxLength = 2;
            this.EmployeeBirthDay_textBox.Name = "EmployeeBirthDay_textBox";
            this.EmployeeBirthDay_textBox.PlaceholderText = "DD";
            this.EmployeeBirthDay_textBox.Size = new System.Drawing.Size(50, 27);
            this.EmployeeBirthDay_textBox.TabIndex = 6;
            this.EmployeeBirthDay_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeBirthDay_textBox_KeyPress);
            // 
            // EmployeeBirthMonth_textBox
            // 
            this.EmployeeBirthMonth_textBox.Location = new System.Drawing.Point(59, 3);
            this.EmployeeBirthMonth_textBox.MaxLength = 2;
            this.EmployeeBirthMonth_textBox.Name = "EmployeeBirthMonth_textBox";
            this.EmployeeBirthMonth_textBox.PlaceholderText = "MM";
            this.EmployeeBirthMonth_textBox.Size = new System.Drawing.Size(50, 27);
            this.EmployeeBirthMonth_textBox.TabIndex = 14;
            this.EmployeeBirthMonth_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeBirthMonth_textBox_KeyPress);
            // 
            // EmployeeBirthYear_textBox
            // 
            this.EmployeeBirthYear_textBox.Location = new System.Drawing.Point(115, 3);
            this.EmployeeBirthYear_textBox.MaxLength = 4;
            this.EmployeeBirthYear_textBox.Name = "EmployeeBirthYear_textBox";
            this.EmployeeBirthYear_textBox.PlaceholderText = "YYYY";
            this.EmployeeBirthYear_textBox.Size = new System.Drawing.Size(100, 27);
            this.EmployeeBirthYear_textBox.TabIndex = 15;
            this.EmployeeBirthYear_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeBirthYear_textBox_KeyPress);
            // 
            // EmployeePosition_label
            // 
            this.EmployeePosition_label.AutoSize = true;
            this.EmployeePosition_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeePosition_label.ForeColor = System.Drawing.Color.White;
            this.EmployeePosition_label.Location = new System.Drawing.Point(12, 283);
            this.EmployeePosition_label.Name = "EmployeePosition_label";
            this.EmployeePosition_label.Size = new System.Drawing.Size(61, 20);
            this.EmployeePosition_label.TabIndex = 30;
            this.EmployeePosition_label.Text = "Position";
            // 
            // EmployeeBirthDate_label
            // 
            this.EmployeeBirthDate_label.AutoSize = true;
            this.EmployeeBirthDate_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeBirthDate_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeBirthDate_label.Location = new System.Drawing.Point(12, 230);
            this.EmployeeBirthDate_label.Name = "EmployeeBirthDate_label";
            this.EmployeeBirthDate_label.Size = new System.Drawing.Size(74, 20);
            this.EmployeeBirthDate_label.TabIndex = 29;
            this.EmployeeBirthDate_label.Text = "Birth date";
            // 
            // ClearFields_button
            // 
            this.ClearFields_button.BackColor = System.Drawing.Color.DarkRed;
            this.ClearFields_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFields_button.ForeColor = System.Drawing.Color.White;
            this.ClearFields_button.Location = new System.Drawing.Point(11, 411);
            this.ClearFields_button.Name = "ClearFields_button";
            this.ClearFields_button.Size = new System.Drawing.Size(216, 65);
            this.ClearFields_button.TabIndex = 28;
            this.ClearFields_button.Text = "Clear fields";
            this.ClearFields_button.UseVisualStyleBackColor = false;
            this.ClearFields_button.Click += new System.EventHandler(this.ClearFields_button_Click);
            // 
            // EditEmployee_button
            // 
            this.EditEmployee_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditEmployee_button.ForeColor = System.Drawing.Color.White;
            this.EditEmployee_button.Location = new System.Drawing.Point(11, 340);
            this.EditEmployee_button.Name = "EditEmployee_button";
            this.EditEmployee_button.Size = new System.Drawing.Size(216, 65);
            this.EditEmployee_button.TabIndex = 27;
            this.EditEmployee_button.Text = "Edit";
            this.EditEmployee_button.UseVisualStyleBackColor = false;
            this.EditEmployee_button.Click += new System.EventHandler(this.EditEmployee_button_Click);
            // 
            // EmployeePosition_comboBox
            // 
            this.EmployeePosition_comboBox.FormattingEnabled = true;
            this.EmployeePosition_comboBox.Location = new System.Drawing.Point(12, 306);
            this.EmployeePosition_comboBox.Name = "EmployeePosition_comboBox";
            this.EmployeePosition_comboBox.Size = new System.Drawing.Size(216, 28);
            this.EmployeePosition_comboBox.TabIndex = 25;
            // 
            // EmployeeSalary_textBox
            // 
            this.EmployeeSalary_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeSalary_textBox.Location = new System.Drawing.Point(12, 200);
            this.EmployeeSalary_textBox.Name = "EmployeeSalary_textBox";
            this.EmployeeSalary_textBox.PlaceholderText = "Salary";
            this.EmployeeSalary_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeSalary_textBox.TabIndex = 24;
            this.EmployeeSalary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSalary_textBox_KeyPress);
            // 
            // EmployeePhoneNumber_textBox
            // 
            this.EmployeePhoneNumber_textBox.Location = new System.Drawing.Point(12, 167);
            this.EmployeePhoneNumber_textBox.Name = "EmployeePhoneNumber_textBox";
            this.EmployeePhoneNumber_textBox.PlaceholderText = "Phone number";
            this.EmployeePhoneNumber_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeePhoneNumber_textBox.TabIndex = 23;
            // 
            // EmployeeEmail_textBox
            // 
            this.EmployeeEmail_textBox.Location = new System.Drawing.Point(12, 134);
            this.EmployeeEmail_textBox.Name = "EmployeeEmail_textBox";
            this.EmployeeEmail_textBox.PlaceholderText = "Email";
            this.EmployeeEmail_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeEmail_textBox.TabIndex = 22;
            // 
            // EditEmployee_label
            // 
            this.EditEmployee_label.AutoSize = true;
            this.EditEmployee_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditEmployee_label.ForeColor = System.Drawing.Color.White;
            this.EditEmployee_label.Location = new System.Drawing.Point(100, 14);
            this.EditEmployee_label.Name = "EditEmployee_label";
            this.EditEmployee_label.Size = new System.Drawing.Size(339, 62);
            this.EditEmployee_label.TabIndex = 21;
            this.EditEmployee_label.Text = "Edit employee";
            // 
            // EmployeeName_textBox
            // 
            this.EmployeeName_textBox.Location = new System.Drawing.Point(12, 101);
            this.EmployeeName_textBox.Name = "EmployeeName_textBox";
            this.EmployeeName_textBox.PlaceholderText = "Name";
            this.EmployeeName_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeName_textBox.TabIndex = 20;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.DateFields_panel);
            this.Controls.Add(this.EmployeePosition_label);
            this.Controls.Add(this.EmployeeBirthDate_label);
            this.Controls.Add(this.ClearFields_button);
            this.Controls.Add(this.EditEmployee_button);
            this.Controls.Add(this.EmployeePosition_comboBox);
            this.Controls.Add(this.EmployeeSalary_textBox);
            this.Controls.Add(this.EmployeePhoneNumber_textBox);
            this.Controls.Add(this.EmployeeEmail_textBox);
            this.Controls.Add(this.EditEmployee_label);
            this.Controls.Add(this.EmployeeName_textBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "UpdateEmployeeForm";
            this.Text = "Edit employee";
            this.Load += new System.EventHandler(this.UpdateEmployeeForm_Load);
            this.DateFields_panel.ResumeLayout(false);
            this.DateFields_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel DateFields_panel;
        private TextBox EmployeeBirthDay_textBox;
        private TextBox EmployeeBirthMonth_textBox;
        private TextBox EmployeeBirthYear_textBox;
        private Label EmployeePosition_label;
        private Label EmployeeBirthDate_label;
        private Button ClearFields_button;
        private Button EditEmployee_button;
        private ComboBox EmployeePosition_comboBox;
        private TextBox EmployeeSalary_textBox;
        private TextBox EmployeePhoneNumber_textBox;
        private TextBox EmployeeEmail_textBox;
        private Label EditEmployee_label;
        private TextBox EmployeeName_textBox;
    }
}