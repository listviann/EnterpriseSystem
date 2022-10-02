using EnterpriseSystem.Entities;

namespace EnterpriseSystem
{
    public partial class GetProductsForm : Form
    {   
        private readonly Employee _employee;
        
        public GetProductsForm(Employee employee)
        {
            InitializeComponent();
            
            _employee = employee;

            Products_listBox.DataSource = _employee.ProductsList;

            if (Products_listBox.Items.Count == 0)
            {
                EditProduct_button.Enabled = false;
                DeleteProduct_button.Enabled = false;
            }

            GetProducts_label.Left = (this.ClientSize.Width - GetProducts_label.Width) / 2;
        }

        private void EditProduct_button_Click(object sender, EventArgs e)
        {
            Product? prod = (Product)Products_listBox.SelectedItem;
            int prodId = prod.Id;
            UpdateProductForm updateProductForm = new(_employee, prodId);
            updateProductForm.Show();
        }

        private void GetProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_button_Click(object sender, EventArgs e)
        {
            Product? product = (Product)Products_listBox.SelectedItem;
            int prodId = product.Id;
            _employee.DeleteProduct(prodId);

            Products_listBox.DataSource = null;
            Products_listBox.DataSource = _employee.ProductsList;
        }
    }
}
