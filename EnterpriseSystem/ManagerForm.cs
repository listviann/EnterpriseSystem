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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();

            ManagerHeader_label.Left = (this.ClientSize.Width - ManagerHeader_label.Width) / 2;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateEmployee_button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new();
            addEmployeeForm.Show();
        }

        private void GetEmployees_button_Click(object sender, EventArgs e)
        {
            GetEmployeesForm getEmployeesForm = new();
            getEmployeesForm.Show();
        }
    }
}
