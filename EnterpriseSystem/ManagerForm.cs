namespace EnterpriseSystem
{
    public partial class ManagerForm : Form
    {
        private readonly Manager _manager;

        public ManagerForm(Manager manager)
        {
            InitializeComponent();

            _manager = manager;

            ManagerHeader_label.Left = (this.ClientSize.Width - ManagerHeader_label.Width) / 2;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateEmployee_button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new(_manager);
            addEmployeeForm.Show();
        }

        private void GetEmployees_button_Click(object sender, EventArgs e)
        {
            GetEmployeesForm getEmployeesForm = new(_manager);
            getEmployeesForm.Show();
        }
    }
}
