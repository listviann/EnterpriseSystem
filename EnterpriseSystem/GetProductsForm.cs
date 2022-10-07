using EnterpriseSystem.Entities;
using EnterpriseSystem.Exceptions;

namespace EnterpriseSystem
{
    public partial class GetProductsForm : Form
    {   
        private readonly Employee _employee;

        private enum SearchKey
        {
           All, Name, Type, Price
        }

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

            SearchKey_comboBox.DataSource = Enum.GetValues(typeof(SearchKey));
            GetProducts_label.Left = (this.ClientSize.Width - GetProducts_label.Width) / 2;
        }

        private void EditProduct_button_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void GetProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_button_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void EditProduct()
        {
            Product? product = (Product)Products_listBox.SelectedItem;

            if (product == null)
            {
                throw new ProductNotFoundException();
            }

            Guid prodId = product.Id;
            UpdateProductForm updateProductForm = new(_employee, prodId);
            updateProductForm.Show();
        }

        private void RemoveProduct()
        {
            Product? product = (Product)Products_listBox.SelectedItem;

            if (product == null)
            {
                throw new ProductNotFoundException();
            }

            Guid prodId = product.Id;
            _employee.DeleteProduct(prodId);

            Products_listBox.DataSource = null;
            Products_listBox.DataSource = _employee.ProductsList;
        }

        private void Products_listBox_DoubleClick(object sender, EventArgs e)
        {
            Product? product = (Product)Products_listBox.SelectedItem;
            Clipboard.SetText(product.Id.ToString());
            MessageBox.Show("Id is copied to clipboard");
        }

        private void SearchProduct_Button_Click(object sender, EventArgs e)
        {
            switch ((SearchKey)SearchKey_comboBox.SelectedItem)
            {
                case SearchKey.Name:
                    Products_listBox.DataSource = null;
                    Products_listBox.DataSource = _employee.ProductsList.Where(p => p.Name == SearchProduct_TextBox.Text).ToList();
                    break;
                case SearchKey.Type:
                    Products_listBox.DataSource = null;
                    Products_listBox.DataSource = _employee.ProductsList.Where(p => p.ProductType == SearchProduct_TextBox.Text).ToList();
                    break;
                case SearchKey.Price:
                    try
                    {
                        Products_listBox.DataSource = null;
                        Products_listBox.DataSource = _employee.ProductsList.Where(p => p.SellingPrice == Convert.ToDecimal(SearchProduct_TextBox.Text)).ToList();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    Products_listBox.DataSource = null;
                    Products_listBox.DataSource = _employee.ProductsList;
                    break;
            }
        }

        private void SortProducts_button_Click(object sender, EventArgs e)
        {
            Sort();
            Products_listBox.DataSource = null;
            Products_listBox.DataSource = _employee.ProductsList;
        }

        private async void Sort()
        {
            await _employee.SortProducts();
        }
    }
}
