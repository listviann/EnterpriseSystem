using EnterpriseSystem.Entities;

namespace EnterpriseSystem
{
    public partial class AddProductForm : Form
    {
        private readonly Employee _employee;

        public AddProductForm(Employee employee)
        {
            InitializeComponent();

            _employee = employee;

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

        private void CreateProduct_button_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(ProductSellingPrice_textBox.Text))
            {
                ProductSellingPrice_textBox.Text = "1";
            }

            AddProduct();
        }

        private void AddProduct()
        {
            _employee.CreateProduct(ProductName_textBox.Text, ProductType_textBox.Text,
                Convert.ToDecimal(ProductSellingPrice_textBox.Text));
        }
    }
}
