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
        public EmployeeForm()
        {
            InitializeComponent();

            EmployeeHeader_label.Left = (this.ClientSize.Width - EmployeeHeader_label.Width) / 2;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateProduct_button_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new();
            addProductForm.Show();
        }

        private void GetProducts_button_Click(object sender, EventArgs e)
        {
            GetProductsForm getProductsForm = new();
            getProductsForm.Show();
        }
    }
}
