namespace EnterpriseSystem
{
    partial class AddEmployeeForm
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
            this.EmployeeName_textBox = new System.Windows.Forms.TextBox();
            this.AddEmployee_label = new System.Windows.Forms.Label();
            this.EmployeeEmail_textBox = new System.Windows.Forms.TextBox();
            this.EmployeePhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthDay_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalary_textBox = new System.Windows.Forms.TextBox();
            this.EmployeePosition_comboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeType_comboBox = new System.Windows.Forms.ComboBox();
            this.CreateEmployee_button = new System.Windows.Forms.Button();
            this.ClearFields_button = new System.Windows.Forms.Button();
            this.EmployeeBirthMonth_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthYear_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthDate_label = new System.Windows.Forms.Label();
            this.EmployeePosition_label = new System.Windows.Forms.Label();
            this.EmployeeType_label = new System.Windows.Forms.Label();
            this.DateFields_panel = new System.Windows.Forms.Panel();
            this.DateFields_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeName_textBox
            // 
            this.EmployeeName_textBox.Location = new System.Drawing.Point(12, 96);
            this.EmployeeName_textBox.Name = "EmployeeName_textBox";
            this.EmployeeName_textBox.PlaceholderText = "Name";
            this.EmployeeName_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeName_textBox.TabIndex = 0;
            this.EmployeeName_textBox.TextChanged += new System.EventHandler(this.EmployeeName_textBox_TextChanged);
            // 
            // AddEmployee_label
            // 
            this.AddEmployee_label.AutoSize = true;
            this.AddEmployee_label.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployee_label.ForeColor = System.Drawing.Color.White;
            this.AddEmployee_label.Location = new System.Drawing.Point(100, 9);
            this.AddEmployee_label.Name = "AddEmployee_label";
            this.AddEmployee_label.Size = new System.Drawing.Size(486, 62);
            this.AddEmployee_label.TabIndex = 3;
            this.AddEmployee_label.Text = "Add a new employee";
            // 
            // EmployeeEmail_textBox
            // 
            this.EmployeeEmail_textBox.Location = new System.Drawing.Point(12, 129);
            this.EmployeeEmail_textBox.Name = "EmployeeEmail_textBox";
            this.EmployeeEmail_textBox.PlaceholderText = "Email";
            this.EmployeeEmail_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeEmail_textBox.TabIndex = 4;
            this.EmployeeEmail_textBox.TextChanged += new System.EventHandler(this.EmployeeEmail_textBox_TextChanged);
            // 
            // EmployeePhoneNumber_textBox
            // 
            this.EmployeePhoneNumber_textBox.Location = new System.Drawing.Point(12, 162);
            this.EmployeePhoneNumber_textBox.Name = "EmployeePhoneNumber_textBox";
            this.EmployeePhoneNumber_textBox.PlaceholderText = "Phone number";
            this.EmployeePhoneNumber_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeePhoneNumber_textBox.TabIndex = 5;
            this.EmployeePhoneNumber_textBox.TextChanged += new System.EventHandler(this.EmployeePhoneNumber_textBox_TextChanged);
            // 
            // EmployeeBirthDay_textBox
            // 
            this.EmployeeBirthDay_textBox.Location = new System.Drawing.Point(3, 3);
            this.EmployeeBirthDay_textBox.MaxLength = 2;
            this.EmployeeBirthDay_textBox.Name = "EmployeeBirthDay_textBox";
            this.EmployeeBirthDay_textBox.PlaceholderText = "DD";
            this.EmployeeBirthDay_textBox.Size = new System.Drawing.Size(50, 27);
            this.EmployeeBirthDay_textBox.TabIndex = 6;
            this.EmployeeBirthDay_textBox.TextChanged += new System.EventHandler(this.EmployeeBirthDate_textBox_TextChanged);
            this.EmployeeBirthDay_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeBirthDay_textBox_KeyPress);
            // 
            // EmployeeSalary_textBox
            // 
            this.EmployeeSalary_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeSalary_textBox.Location = new System.Drawing.Point(12, 195);
            this.EmployeeSalary_textBox.Name = "EmployeeSalary_textBox";
            this.EmployeeSalary_textBox.PlaceholderText = "Salary";
            this.EmployeeSalary_textBox.Size = new System.Drawing.Size(216, 27);
            this.EmployeeSalary_textBox.TabIndex = 7;
            this.EmployeeSalary_textBox.TextChanged += new System.EventHandler(this.EmployeeSalary_textBox_TextChanged);
            this.EmployeeSalary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSalary_textBox_KeyPress);
            // 
            // EmployeePosition_comboBox
            // 
            this.EmployeePosition_comboBox.FormattingEnabled = true;
            this.EmployeePosition_comboBox.Location = new System.Drawing.Point(12, 301);
            this.EmployeePosition_comboBox.Name = "EmployeePosition_comboBox";
            this.EmployeePosition_comboBox.Size = new System.Drawing.Size(216, 28);
            this.EmployeePosition_comboBox.TabIndex = 10;
            // 
            // EmployeeType_comboBox
            // 
            this.EmployeeType_comboBox.FormattingEnabled = true;
            this.EmployeeType_comboBox.Location = new System.Drawing.Point(12, 355);
            this.EmployeeType_comboBox.Name = "EmployeeType_comboBox";
            this.EmployeeType_comboBox.Size = new System.Drawing.Size(216, 28);
            this.EmployeeType_comboBox.TabIndex = 11;
            // 
            // CreateEmployee_button
            // 
            this.CreateEmployee_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateEmployee_button.ForeColor = System.Drawing.Color.White;
            this.CreateEmployee_button.Location = new System.Drawing.Point(12, 397);
            this.CreateEmployee_button.Name = "CreateEmployee_button";
            this.CreateEmployee_button.Size = new System.Drawing.Size(216, 65);
            this.CreateEmployee_button.TabIndex = 12;
            this.CreateEmployee_button.Text = "Create";
            this.CreateEmployee_button.UseVisualStyleBackColor = false;
            this.CreateEmployee_button.Click += new System.EventHandler(this.CreateEmployee_button_Click);
            // 
            // ClearFields_button
            // 
            this.ClearFields_button.BackColor = System.Drawing.Color.DarkRed;
            this.ClearFields_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFields_button.ForeColor = System.Drawing.Color.White;
            this.ClearFields_button.Location = new System.Drawing.Point(12, 468);
            this.ClearFields_button.Name = "ClearFields_button";
            this.ClearFields_button.Size = new System.Drawing.Size(216, 65);
            this.ClearFields_button.TabIndex = 13;
            this.ClearFields_button.Text = "Clear fields";
            this.ClearFields_button.UseVisualStyleBackColor = false;
            this.ClearFields_button.Click += new System.EventHandler(this.ClearFields_button_Click);
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
            // EmployeeBirthDate_label
            // 
            this.EmployeeBirthDate_label.AutoSize = true;
            this.EmployeeBirthDate_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeBirthDate_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeBirthDate_label.Location = new System.Drawing.Point(12, 225);
            this.EmployeeBirthDate_label.Name = "EmployeeBirthDate_label";
            this.EmployeeBirthDate_label.Size = new System.Drawing.Size(74, 20);
            this.EmployeeBirthDate_label.TabIndex = 16;
            this.EmployeeBirthDate_label.Text = "Birth date";
            // 
            // EmployeePosition_label
            // 
            this.EmployeePosition_label.AutoSize = true;
            this.EmployeePosition_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeePosition_label.ForeColor = System.Drawing.Color.White;
            this.EmployeePosition_label.Location = new System.Drawing.Point(12, 278);
            this.EmployeePosition_label.Name = "EmployeePosition_label";
            this.EmployeePosition_label.Size = new System.Drawing.Size(61, 20);
            this.EmployeePosition_label.TabIndex = 17;
            this.EmployeePosition_label.Text = "Position";
            // 
            // EmployeeType_label
            // 
            this.EmployeeType_label.AutoSize = true;
            this.EmployeeType_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeType_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeType_label.Location = new System.Drawing.Point(12, 332);
            this.EmployeeType_label.Name = "EmployeeType_label";
            this.EmployeeType_label.Size = new System.Drawing.Size(108, 20);
            this.EmployeeType_label.TabIndex = 18;
            this.EmployeeType_label.Text = "Employee type";
            // 
            // DateFields_panel
            // 
            this.DateFields_panel.Controls.Add(this.EmployeeBirthDay_textBox);
            this.DateFields_panel.Controls.Add(this.EmployeeBirthMonth_textBox);
            this.DateFields_panel.Controls.Add(this.EmployeeBirthYear_textBox);
            this.DateFields_panel.Location = new System.Drawing.Point(12, 248);
            this.DateFields_panel.Name = "DateFields_panel";
            this.DateFields_panel.Size = new System.Drawing.Size(224, 33);
            this.DateFields_panel.TabIndex = 19;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 548);
            this.Controls.Add(this.DateFields_panel);
            this.Controls.Add(this.EmployeeType_label);
            this.Controls.Add(this.EmployeePosition_label);
            this.Controls.Add(this.EmployeeBirthDate_label);
            this.Controls.Add(this.ClearFields_button);
            this.Controls.Add(this.CreateEmployee_button);
            this.Controls.Add(this.EmployeeType_comboBox);
            this.Controls.Add(this.EmployeePosition_comboBox);
            this.Controls.Add(this.EmployeeSalary_textBox);
            this.Controls.Add(this.EmployeePhoneNumber_textBox);
            this.Controls.Add(this.EmployeeEmail_textBox);
            this.Controls.Add(this.AddEmployee_label);
            this.Controls.Add(this.EmployeeName_textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 595);
            this.MinimumSize = new System.Drawing.Size(500, 595);
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.DateFields_panel.ResumeLayout(false);
            this.DateFields_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EmployeeName_textBox;
        private Label AddEmployee_label;
        private TextBox EmployeeEmail_textBox;
        private TextBox EmployeePhoneNumber_textBox;
        private TextBox EmployeeBirthDay_textBox;
        private TextBox EmployeeSalary_textBox;
        private ComboBox EmployeePosition_comboBox;
        private ComboBox EmployeeType_comboBox;
        private Button CreateEmployee_button;
        private Button ClearFields_button;
        private TextBox EmployeeBirthMonth_textBox;
        private TextBox EmployeeBirthYear_textBox;
        private Label EmployeeBirthDate_label;
        private Label EmployeePosition_label;
        private Label EmployeeType_label;
        private Panel DateFields_panel;
    }
}