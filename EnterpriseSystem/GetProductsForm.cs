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
    public partial class GetProductsForm : Form
    {
        public GetProductsForm()
        {
            InitializeComponent();
        }

        private void EditProduct_button_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProductForm = new();
            updateProductForm.Show();
        }
    }
}
