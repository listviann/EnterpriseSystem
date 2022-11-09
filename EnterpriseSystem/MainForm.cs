using EnterpriseSystem.Entities;
using EnterpriseSystem.Logging;
using EnterpriseSystem.Serialization.Json;
using EnterpriseSystem.Serialization.Xml;
using EnterpriseSystem.Service;
using System.Diagnostics;

namespace EnterpriseSystem
{
    // The main menu and form in the application
    public partial class MainForm : Form
    {
        private readonly Manager _manager;

        public MainForm()
        {
            InitializeComponent();

            // centering form
            this.CenterToScreen();
            
            // subscribing to events and creating the object of manager
            LoggerViewModel.Logger.Notify += LoggingFunctions.LogMessage;
            _manager = new Manager();
            _manager.ModelNotify += DialogMessageFunctions.ShowMessage;

            // setting a file dialogs filters
            jsonSave_saveFileDialog.Filter = "JSON file(*.json)|*.json|Text file(*.txt)|*.txt";
            jsonOpen_openFileDialog.Filter = "JSON file(*.json)|*.json|Text file(*.txt)|*.txt";
            xmlSave_SaveFileDialog.Filter = "XML file(*.xml)|*.xml|Text file(*.txt)|*.txt";
            xmlOpen_openFileDialog.Filter = "XML file(*.xml)|*.xml|Text file(*.txt)|*.txt";

            Welcome_label.Left = (this.ClientSize.Width - Welcome_label.Width) / 2;
        }

        // Exit program
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
            ManagerForm managerForm = new(_manager);
            managerForm.Show();
        }

        private void LoginAsEmployee_button_Click(object sender, EventArgs e)
        {
            EmpLoginForm empLoginForm = new(_manager);
            empLoginForm.Show();
        }

        // file dialogs to save data in xml or json
        private void jsonFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jsonSave_saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = jsonSave_saveFileDialog.FileName;
            SaveToJsonFile(filename);
            MessageBox.Show("Saved");
        }

        private void xmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlSave_SaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = xmlSave_SaveFileDialog.FileName;
            SaveToXmlFile(filename);
            MessageBox.Show("Saved");
        }

        // Logic of saving and opening json files
        // save as json file
        private void SaveToJsonFile(string filename)
        {
            JsonManager<Employee> jsonManager = new JsonManager<Employee>();
            jsonManager.SerializeData(_manager.Employees, filename);
        }

        // open json file
        private void OpenJsonFile(string filename)
        {
            JsonManager<Employee> jsonManager = new JsonManager<Employee>();
            try
            {
                List<Employee> objects = jsonManager.DeserializeData(filename);
                _manager.Employees.Clear();
                _manager.Employees = objects;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Logic of saving and opening xml files
        // save as xml file 
        private void SaveToXmlFile(string filename)
        {
            XmlManager<Employee> xmlManager = new XmlManager<Employee>();
            xmlManager.SerializeData(_manager.Employees, filename);
        }

        // open xml file
        private void OpenXmlFile(string filename)
        {
            XmlManager<Employee> xmlManager = new XmlManager<Employee>();
            try
            {
                List<Employee> objects = xmlManager.DeserializeData(filename);
                _manager.Employees.Clear();
                _manager.Employees = objects;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // file dialogs for opening json or xml files
        private void jsonFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (jsonOpen_openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = jsonOpen_openFileDialog.FileName;
            OpenJsonFile(filename);
            MessageBox.Show("Opened");
        }

        private void xmlFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (xmlOpen_openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = xmlOpen_openFileDialog.FileName;
            OpenXmlFile(filename);
            MessageBox.Show("Opened");
        }

        // Go to About form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            aboutForm.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}