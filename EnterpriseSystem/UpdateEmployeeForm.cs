﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseSystem
{
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();

            EditEmployee_label.Left = (this.ClientSize.Width - EditEmployee_label.Width) / 2;
            EmployeeName_textBox.Left = (this.ClientSize.Width - EmployeeName_textBox.Width) / 2;
            EmployeeEmail_textBox.Left = (this.ClientSize.Width - EmployeeEmail_textBox.Width) / 2;
            EmployeePhoneNumber_textBox.Left = (this.ClientSize.Width - EmployeePhoneNumber_textBox.Width) / 2;
            EmployeeSalary_textBox.Left = (this.ClientSize.Width - EmployeeSalary_textBox.Width) / 2;
            EmployeeBirthDate_label.Left = (this.ClientSize.Width - EmployeeBirthDate_label.Width) / 2;
            EmployeePosition_label.Left = (this.ClientSize.Width - EmployeePosition_label.Width) / 2;
            EmployeePosition_comboBox.Left = (this.ClientSize.Width - EmployeePosition_comboBox.Width) / 2;
            EditEmployee_button.Left = (this.ClientSize.Width - EditEmployee_button.Width) / 2;
            ClearFields_button.Left = (this.ClientSize.Width - ClearFields_button.Width) / 2;
            DateFields_panel.Left = (this.ClientSize.Width - DateFields_panel.Width) / 2;
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearFields_button_Click(object sender, EventArgs e)
        {
            EmployeeName_textBox.Text = "";
            EmployeeEmail_textBox.Text = "";
            EmployeePhoneNumber_textBox.Text = "";
            EmployeeSalary_textBox.Text = "";
            EmployeeBirthDate_label.Text = "";
            EmployeePosition_label.Text = "";
            EmployeePosition_comboBox.Text = "";
        }
    }
}
