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
    public partial class ManagerForm : Form
    {
        private readonly Logger _logger;
        private readonly Manager _manager;

        public ManagerForm(Manager manager, Logger logger)
        {
            InitializeComponent();

            _logger = logger;
            _manager = manager;

            ManagerHeader_label.Left = (this.ClientSize.Width - ManagerHeader_label.Width) / 2;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateEmployee_button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new(_manager, _logger);
            addEmployeeForm.Show();
        }

        private void GetEmployees_button_Click(object sender, EventArgs e)
        {
            GetEmployeesForm getEmployeesForm = new(_manager, _logger);
            getEmployeesForm.Show();
        }
    }
}
