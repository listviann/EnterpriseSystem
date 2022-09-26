using EnterpriseSystem.Entities;
using EnterpriseSystem.Logging;
using System;
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
    public partial class GetEmployeesForm : Form
    {
        private readonly Logger _logger;
        private readonly Manager _manager;

        public GetEmployeesForm(Manager manager, Logger logger)
        {
            InitializeComponent();

            _manager = manager;
            _logger = logger;

            Employees_listBox.DataSource = _manager.GetEmployees().ToList();

            if (Employees_listBox.Items.Count == 0)
            {
                EditEmployee_button.Enabled = false;
                DeleteEmployee_button.Enabled = false;
            }


            GetEmployees_label.Left = (this.ClientSize.Width - GetEmployees_label.Width) / 2;
        }

        private void GetEmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void EditEmployee_button_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)Employees_listBox.SelectedItem;
            int empId = emp.Id;

            UpdateEmployeeForm updateEmployeeForm = new(_manager, _logger, empId);
            updateEmployeeForm.Show();
        }

        private void DeleteEmployee_button_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)Employees_listBox.SelectedItem;
            int empId = emp.Id;
            _manager.DeleteEmployee(empId);

            Employees_listBox.DataSource = null;
            Employees_listBox.DataSource = _manager.GetEmployees().ToList();
        }

        private void Employees_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
