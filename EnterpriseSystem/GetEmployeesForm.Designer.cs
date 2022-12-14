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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetEmployeesForm));
            this.EditEmployee_button = new System.Windows.Forms.Button();
            this.DeleteEmployee_button = new System.Windows.Forms.Button();
            this.Employees_listBox = new System.Windows.Forms.ListBox();
            this.GetEmployees_label = new System.Windows.Forms.Label();
            this.SearchKey_comboBox = new System.Windows.Forms.ComboBox();
            this.SearchEmployee_TextBox = new System.Windows.Forms.TextBox();
            this.SearchEmployees_Button = new System.Windows.Forms.Button();
            this.employeeTypes_comboBox = new System.Windows.Forms.ComboBox();
            this.SortEmployees_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditEmployee_button
            // 
            this.EditEmployee_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditEmployee_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditEmployee_button.ForeColor = System.Drawing.Color.White;
            this.EditEmployee_button.Location = new System.Drawing.Point(12, 471);
            this.EditEmployee_button.Name = "EditEmployee_button";
            this.EditEmployee_button.Size = new System.Drawing.Size(260, 65);
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
            this.DeleteEmployee_button.Location = new System.Drawing.Point(327, 471);
            this.DeleteEmployee_button.Name = "DeleteEmployee_button";
            this.DeleteEmployee_button.Size = new System.Drawing.Size(263, 65);
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
            this.Employees_listBox.Location = new System.Drawing.Point(12, 121);
            this.Employees_listBox.Name = "Employees_listBox";
            this.Employees_listBox.Size = new System.Drawing.Size(581, 344);
            this.Employees_listBox.TabIndex = 15;
            this.Employees_listBox.SelectedIndexChanged += new System.EventHandler(this.Employees_listBox_SelectedIndexChanged);
            this.Employees_listBox.DoubleClick += new System.EventHandler(this.Employees_listBox_DoubleClick);
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
            // SearchKey_comboBox
            // 
            this.SearchKey_comboBox.FormattingEnabled = true;
            this.SearchKey_comboBox.Location = new System.Drawing.Point(81, 88);
            this.SearchKey_comboBox.Name = "SearchKey_comboBox";
            this.SearchKey_comboBox.Size = new System.Drawing.Size(90, 28);
            this.SearchKey_comboBox.TabIndex = 17;
            // 
            // SearchEmployee_TextBox
            // 
            this.SearchEmployee_TextBox.Location = new System.Drawing.Point(177, 89);
            this.SearchEmployee_TextBox.Name = "SearchEmployee_TextBox";
            this.SearchEmployee_TextBox.Size = new System.Drawing.Size(170, 27);
            this.SearchEmployee_TextBox.TabIndex = 18;
            // 
            // SearchEmployees_Button
            // 
            this.SearchEmployees_Button.Location = new System.Drawing.Point(353, 88);
            this.SearchEmployees_Button.Name = "SearchEmployees_Button";
            this.SearchEmployees_Button.Size = new System.Drawing.Size(117, 27);
            this.SearchEmployees_Button.TabIndex = 19;
            this.SearchEmployees_Button.Text = "Search";
            this.SearchEmployees_Button.UseVisualStyleBackColor = true;
            this.SearchEmployees_Button.Click += new System.EventHandler(this.SearchEmployees_Button_Click);
            // 
            // employeeTypes_comboBox
            // 
            this.employeeTypes_comboBox.FormattingEnabled = true;
            this.employeeTypes_comboBox.Location = new System.Drawing.Point(12, 88);
            this.employeeTypes_comboBox.Name = "employeeTypes_comboBox";
            this.employeeTypes_comboBox.Size = new System.Drawing.Size(63, 28);
            this.employeeTypes_comboBox.TabIndex = 20;
            this.employeeTypes_comboBox.SelectedIndexChanged += new System.EventHandler(this.employeeTypes_comboBox_SelectedIndexChanged);
            // 
            // SortEmployees_button
            // 
            this.SortEmployees_button.Location = new System.Drawing.Point(476, 88);
            this.SortEmployees_button.Name = "SortEmployees_button";
            this.SortEmployees_button.Size = new System.Drawing.Size(117, 27);
            this.SortEmployees_button.TabIndex = 21;
            this.SortEmployees_button.Text = "Sort";
            this.SortEmployees_button.UseVisualStyleBackColor = true;
            this.SortEmployees_button.Click += new System.EventHandler(this.SortEmployees_button_Click);
            // 
            // GetEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(602, 548);
            this.Controls.Add(this.SortEmployees_button);
            this.Controls.Add(this.employeeTypes_comboBox);
            this.Controls.Add(this.SearchEmployees_Button);
            this.Controls.Add(this.SearchEmployee_TextBox);
            this.Controls.Add(this.SearchKey_comboBox);
            this.Controls.Add(this.GetEmployees_label);
            this.Controls.Add(this.Employees_listBox);
            this.Controls.Add(this.DeleteEmployee_button);
            this.Controls.Add(this.EditEmployee_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 595);
            this.Name = "GetEmployeesForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.GetEmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditEmployee_button;
        private Button DeleteEmployee_button;
        private ListBox Employees_listBox;
        private Label GetEmployees_label;
        private ComboBox SearchKey_comboBox;
        private TextBox SearchEmployee_TextBox;
        private Button SearchEmployees_Button;
        private ComboBox employeeTypes_comboBox;
        private Button SortEmployees_button;
    }
}