using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using EnterpriseSystem.Entities;
using EnterpriseSystem.Logging;
using EnterpriseSystem.Models;

namespace EnterpriseSystem
{
    public partial class AddEmployeeForm : Form
    {
        private readonly Logger _logger;
        private readonly Manager _manager;

        public AddEmployeeForm(Manager manager, Logger logger)
        {
            InitializeComponent();

            AddEmployee_label.Left = (this.ClientSize.Width - AddEmployee_label.Width) / 2;
            EmployeeName_textBox.Left = (this.ClientSize.Width - EmployeeName_textBox.Width) / 2;
            EmployeeEmail_textBox.Left = (this.ClientSize.Width - EmployeeEmail_textBox.Width) / 2;
            EmployeePhoneNumber_textBox.Left = (this.ClientSize.Width - EmployeePhoneNumber_textBox.Width) / 2;
            EmployeeSalary_textBox.Left = (this.ClientSize.Width - EmployeeSalary_textBox.Width) / 2;
            EmployeeBirthDate_label.Left = (this.ClientSize.Width - EmployeeBirthDate_label.Width) / 2;
            EmployeeType_label.Left = (this.ClientSize.Width - EmployeeType_label.Width) / 2;
            EmployeePosition_label.Left = (this.ClientSize.Width - EmployeePosition_label.Width) / 2;
            EmployeeType_comboBox.Left = (this.ClientSize.Width - EmployeeType_comboBox.Width) / 2;
            EmployeePosition_comboBox.Left = (this.ClientSize.Width - EmployeePosition_comboBox.Width) / 2;
            CreateEmployee_button.Left = (this.ClientSize.Width - CreateEmployee_button.Width) / 2;
            ClearFields_button.Left = (this.ClientSize.Width - ClearFields_button.Width) / 2;
            DateFields_panel.Left = (this.ClientSize.Width - DateFields_panel.Width) / 2;

            EmployeePosition_comboBox.DataSource = Enum.GetValues(typeof(Position));
            EmployeeType_comboBox.DataSource = Enum.GetValues(typeof(EmployeeType));

            //_logger = Logger.Instance;
            //_manager = new Manager(_logger);
            _logger = logger;
            _manager = manager;

            _manager.ModelNotify += ShowMessage;
            //_logger.Notify += LoggingFunctions.LogMessage;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeEmail_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeePhoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeSalary_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeBirthDate_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeSalary_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmployeeBirthDay_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmployeeBirthMonth_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmployeeBirthYear_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearFields_button_Click(object sender, EventArgs e)
        {
            EmployeeName_textBox.Text = "";
            EmployeeEmail_textBox.Text = "";
            EmployeePhoneNumber_textBox.Text = "";
            EmployeeSalary_textBox.Text = "1";
            EmployeeBirthDay_textBox.Text = "1";
            EmployeeBirthMonth_textBox.Text = "1";
            EmployeeBirthYear_textBox.Text = "0001";
            EmployeePosition_comboBox.Text = "";
            EmployeeType_comboBox.Text = "";
        }

        private void CreateEmployee_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeSalary_textBox.Text)
                || string.IsNullOrWhiteSpace(EmployeeBirthDay_textBox.Text)
                || string.IsNullOrWhiteSpace(EmployeeBirthMonth_textBox.Text)
                || string.IsNullOrWhiteSpace(EmployeeBirthYear_textBox.Text))
            {
                EmployeeSalary_textBox.Text = "1";
                EmployeeBirthDay_textBox.Text = "1";
                EmployeeBirthMonth_textBox.Text = "1";
                EmployeeBirthYear_textBox.Text = "0001";
            }

            decimal salary = Convert.ToDecimal(EmployeeSalary_textBox.Text);
            int day = Convert.ToInt32(EmployeeBirthDay_textBox.Text);
            int month = Convert.ToInt32(EmployeeBirthMonth_textBox.Text);
            int year = Convert.ToInt32(EmployeeBirthYear_textBox.Text);
            DateTime date = new DateTime(year, month, day);

            _manager.CreateEmployee(EmployeeName_textBox.Text, EmployeeEmail_textBox.Text, EmployeePhoneNumber_textBox.Text, date, 
                (Position)EmployeePosition_comboBox.SelectedItem, (EmployeeType)EmployeeType_comboBox.SelectedItem, salary);
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
