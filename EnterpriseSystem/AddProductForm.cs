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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();

            AddProduct_label.Left = (this.ClientSize.Width - AddProduct_label.Width) / 2;
            ProductName_textBox.Left = (this.ClientSize.Width - ProductName_textBox.Width) / 2;
            ProductType_textBox.Left = (this.ClientSize.Width - ProductType_textBox.Width) / 2;
            ProductSellingPrice_textBox.Left = (this.ClientSize.Width - ProductSellingPrice_textBox.Width) / 2;
            CreateProduct_button.Left = (this.ClientSize.Width - CreateProduct_button.Width) / 2;
            ClearFields_button.Left = (this.ClientSize.Width - ClearFields_button.Width) / 2;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearFields_button_Click(object sender, EventArgs e)
        {
            ProductName_textBox.Text = "";
            ProductType_textBox.Text = "";
            ProductSellingPrice_textBox.Text = "1";
        }
    }
}
