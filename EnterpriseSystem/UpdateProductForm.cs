using EnterpriseSystem.Entities;

namespace EnterpriseSystem
{
    public partial class UpdateProductForm : Form
    {
        private readonly Employee _employee;
        private readonly int _id;

        public UpdateProductForm(Employee employee, int id)
        {
            InitializeComponent();

            _employee = employee;
            _id = id;

            Product? product = _employee.ProductsList.FirstOrDefault(p => p.Id == _id);

            ProductName_textBox.Text = product!.Name;
            ProductType_textBox.Text = product.ProductType;
            ProductSellingPrice_textBox.Text = product.SellingPrice.ToString();

            EditProduct_label.Left = (this.ClientSize.Width - EditProduct_button.Width) / 2;
            EditProduct_button.Left = (this.ClientSize.Width - EditProduct_button.Width) / 2;
            ProductName_textBox.Left = (this.ClientSize.Width - ProductName_textBox.Width) / 2;
            ProductType_textBox.Left = (this.ClientSize.Width - ProductType_textBox.Width) / 2;
            ProductSellingPrice_textBox.Left = (this.ClientSize.Width - ProductSellingPrice_textBox.Width) / 2;
            ClearFields_button.Left = (this.ClientSize.Width - ClearFields_button.Width) / 2;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductSellingPrice_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearFields_button_Click(object sender, EventArgs e)
        {
            ProductName_textBox.Text = "";
            ProductType_textBox.Text = "";
            ProductSellingPrice_textBox.Text = "1";
        }

        private void EditProduct_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductSellingPrice_textBox.Text))
            {
                ProductSellingPrice_textBox.Text = "1";
            }

            _employee.UpdateProduct(_id, ProductName_textBox.Text, 
                ProductType_textBox.Text, Convert.ToDecimal(ProductSellingPrice_textBox.Text));

            this.Close();
        }
    }
}
