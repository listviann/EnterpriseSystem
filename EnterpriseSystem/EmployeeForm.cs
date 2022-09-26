using Accessibility;
using EnterpriseSystem.Logging;
using EnterpriseSystem.Entities;
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
    public partial class EmployeeForm : Form
    {
        private readonly Logger _logger;
        private readonly Manager _manager;
        private readonly Employee _employee;


        public EmployeeForm(Manager manager, Logger logger, Employee employee)
        {
            InitializeComponent();

            _logger = logger;
            _manager = manager;
            _employee = employee;
            _employee.ModelNotify += DialogMessageFunctions.ShowMessage;

            EmployeeHeader_label.Left = (this.ClientSize.Width - EmployeeHeader_label.Width) / 2;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateProduct_button_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new(_employee, _logger);
            addProductForm.Show();
        }

        private void GetProducts_button_Click(object sender, EventArgs e)
        {
            GetProductsForm getProductsForm = new(_employee, _logger);
            getProductsForm.Show();
        }
    }
}
