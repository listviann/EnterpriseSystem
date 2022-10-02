using EnterpriseSystem.Entities;
using EnterpriseSystem.Exceptions;
using System.Runtime.InteropServices;
using System.Windows;

namespace EnterpriseSystem
{
    public partial class GetEmployeesForm : Form
    {
        private readonly Manager _manager;
        private readonly string[] _empTypes = { "All", "Hour", "Fixed" };

        public GetEmployeesForm(Manager manager)
        {
            InitializeComponent();

            _manager = manager;

            Employees_listBox.DataSource = _manager.Employees;
            employeeTypes_comboBox.DataSource = _empTypes;

            GetEmployees_label.Left = (this.ClientSize.Width - GetEmployees_label.Width) / 2;
        }

        private void GetEmployeesForm_Load(object sender, EventArgs e)
        {
            if (Employees_listBox.Items.Count == 0)
            {
                EditEmployee_button.Enabled = false;
                DeleteEmployee_button.Enabled = false;
            }
        }

        private void EditEmployee_button_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void DeleteEmployee_button_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
        }

        private void Employees_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeTypes_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)employeeTypes_comboBox.SelectedItem == _empTypes[0])
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.Employees;
            }
            else if ((string)employeeTypes_comboBox.SelectedItem == _empTypes[1])
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.GetHourEmployees();
            }
            else if ((string)employeeTypes_comboBox.SelectedItem == _empTypes[2])
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.GetFixedEmployees();
            }
        }

        private void EditEmployee()
        {
            Employee emp = (Employee)Employees_listBox.SelectedItem;

            if (emp == null)
            {
                throw new EmployeeNotFoundException();
            }

            Guid empId = emp.Id;

            UpdateEmployeeForm updateEmployeeForm = new(_manager, empId);
            updateEmployeeForm.Show();
        }

        private void RemoveEmployee()
        {
            Employee? emp = (Employee)Employees_listBox.SelectedItem;

            if (emp == null)
            {
                throw new EmployeeNotFoundException();
            }

            Guid empId = emp.Id;
            _manager.DeleteEmployee(empId);
            Employees_listBox.DataSource = null;
            Employees_listBox.DataSource = _manager.Employees;
        }

        private void Employees_listBox_DoubleClick(object sender, EventArgs e)
        {
            Employee? emp = (Employee)Employees_listBox.SelectedItem;
            Clipboard.SetText(emp.Id.ToString());
            MessageBox.Show("Id is copied to clipboard");
        }

        private void SortEmployees_button_Click(object sender, EventArgs e)
        {
            //await SortAsync();
            Sort();
            Employees_listBox.DataSource = null;
            Employees_listBox.DataSource = _manager.Employees;
        }

        private async void Sort()
        {
            await _manager.SortAllEmployees();
        }
    }
}
