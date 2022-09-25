namespace EnterpriseSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //
            // Centering controls:
            //
            // centering horizontally
            Welcome_label.Left = (this.ClientSize.Width - Welcome_label.Width) / 2;
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginAsManager_button_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new();
            managerForm.Show();
        }

        private void LoginAsEmployee_button_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new();
            employeeForm.Show();
        }
    }
}