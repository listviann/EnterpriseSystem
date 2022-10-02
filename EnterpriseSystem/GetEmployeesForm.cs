using EnterpriseSystem.Entities;
using EnterpriseSystem.Exceptions;
using System.Runtime.InteropServices;
using System.Windows;

namespace EnterpriseSystem
{
    public partial class GetEmployeesForm : Form
    {
        private enum EmployeeSearchType
        {
            All, Hour, Fixed
        }

        private enum SearchKey
        {
            All, Name, Salary, Email, PhoneNumber
        }

        private readonly Manager _manager;

        public GetEmployeesForm(Manager manager)
        {
            InitializeComponent();

            _manager = manager;

            Employees_listBox.DataSource = _manager.Employees;
            employeeTypes_comboBox.DataSource = Enum.GetValues(typeof(EmployeeSearchType));
            SearchKey_comboBox.DataSource = Enum.GetValues(typeof(SearchKey));

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
            if ((EmployeeSearchType)employeeTypes_comboBox.SelectedItem == EmployeeSearchType.Hour)
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.GetHourEmployees();
            }
            else if ((EmployeeSearchType)employeeTypes_comboBox.SelectedItem == EmployeeSearchType.Fixed)
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.GetFixedEmployees();
            }
            else
            {
                Employees_listBox.DataSource = null;
                Employees_listBox.DataSource = _manager.Employees;
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

        private void SearchEmployees_Button_Click(object sender, EventArgs e)
        {
            switch ((SearchKey)SearchKey_comboBox.SelectedItem)
            {
                case SearchKey.Name:
                    Employees_listBox.DataSource = null;
                    Employees_listBox.DataSource = _manager.Employees.Where(e => e.Name == SearchEmployee_TextBox.Text).ToList();
                    break;
                case SearchKey.Salary:
                    try
                    {
                        Employees_listBox.DataSource = null;
                        Employees_listBox.DataSource = _manager.Employees.Where(e => e.Salary == Convert.ToDecimal(SearchEmployee_TextBox.Text)).ToList();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case SearchKey.Email:
                    Employees_listBox.DataSource = null;
                    Employees_listBox.DataSource = _manager.Employees.Where(e => e.Email == SearchEmployee_TextBox.Text).ToList();
                    break;
                case SearchKey.PhoneNumber:
                    Employees_listBox.DataSource = null;
                    Employees_listBox.DataSource = _manager.Employees.Where(e => e.PhoneNumber == SearchEmployee_TextBox.Text).ToList();
                    break;
                default:
                    Employees_listBox.DataSource = null;
                    Employees_listBox.DataSource = _manager.Employees;
                    break;
            }
        }
    }
}
