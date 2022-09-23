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
        public GetEmployeesForm()
        {
            InitializeComponent();

            GetEmployees_label.Left = (this.ClientSize.Width - GetEmployees_label.Width) / 2;
        }

        private void GetEmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void EditEmployee_button_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm updateEmployeeForm = new();
            updateEmployeeForm.Show();
        }

        private void DeleteEmployee_button_Click(object sender, EventArgs e)
        {

        }
    }
}
