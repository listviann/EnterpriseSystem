using EnterpriseSystem.Entities;

namespace EnterpriseSystem
{
    public partial class EmpLoginForm : Form
    {
        private readonly Manager _manager;

        public EmpLoginForm(Manager manager)
        {
            InitializeComponent();

            _manager = manager;

            EmpId_label.Left = (this.ClientSize.Width - EmpId_label.Width) / 2;
            EmpId_textBox.Left = (this.ClientSize.Width - EmpId_textBox.Width) / 2;
            EmpSignIn_button.Left = (this.ClientSize.Width - EmpSignIn_button.Width) / 2;
        }

        private void EmpLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void EmpId_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpSignIn_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EmpId_textBox.Text);

            try
            {
                Employee? emp = _manager.GetEmployeeById(id);
                EmployeeForm employeeForm = new(_manager, emp);
                employeeForm.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Cannot sign in as employee");
                EmpId_textBox.Text = "1";
            }
        }
    }
}
