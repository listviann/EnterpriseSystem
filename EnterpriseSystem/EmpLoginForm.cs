using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnterpriseSystem.Entities;
using EnterpriseSystem.Logging;

namespace EnterpriseSystem
{
    public partial class EmpLoginForm : Form
    {
        private readonly Manager _manager;
        private readonly Logger _logger;

        public EmpLoginForm(Manager manager, Logger logger)
        {
            InitializeComponent();

            _manager = manager;
            _logger = logger;

            EmpId_label.Left = (this.ClientSize.Width - EmpId_label.Width) / 2;
            EmpId_textBox.Left = (this.ClientSize.Width - EmpId_textBox.Width) / 2;
            EmpSignIn_button.Left = (this.ClientSize.Width - EmpSignIn_button.Width) / 2;
        }

        private void EmpLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void EmpId_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpSignIn_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EmpId_textBox.Text);

            try
            {
                Employee? emp = _manager.GetEmployeeById(id);
                EmployeeForm employeeForm = new(_manager, _logger, emp);
                employeeForm.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Cannot sign in as employee");
                EmpId_textBox.Text = "1";
            }
        }
    }
}
