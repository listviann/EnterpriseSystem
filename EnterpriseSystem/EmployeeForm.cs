using EnterpriseSystem.Entities;

namespace EnterpriseSystem
{
    public partial class EmployeeForm : Form
    {
        private readonly Manager _manager;
        private readonly Employee _employee;


        public EmployeeForm(Manager manager, Employee employee)
        {
            InitializeComponent();

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
            AddProductForm addProductForm = new(_employee);
            addProductForm.Show();
        }

        private void GetProducts_button_Click(object sender, EventArgs e)
        {
            GetProductsForm getProductsForm = new(_employee);
            getProductsForm.Show();
        }


    }
}
