using EnterpriseSystem.Logging;

namespace EnterpriseSystem
{
    public partial class MainForm : Form
    {
        private readonly Logger _logger;
        private readonly Manager _manager;

        public MainForm()
        {
            InitializeComponent();

            _logger = Logger.Instance;
            _logger.Notify += LoggingFunctions.LogMessage;
            _manager = new Manager(_logger);
            _manager.ModelNotify += DialogMessageFunctions.ShowMessage;

            Welcome_label.Left = (this.ClientSize.Width - Welcome_label.Width) / 2;
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to quit?";
            string caption = "Exit";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginAsManager_button_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new(_manager, _logger);
            managerForm.Show();
        }

        private void LoginAsEmployee_button_Click(object sender, EventArgs e)
        {
            EmpLoginForm empLoginForm = new(_manager, _logger);
            empLoginForm.Show();
        }
    }
}