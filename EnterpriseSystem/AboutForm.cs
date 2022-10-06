using EnterpriseSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseSystem
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            AboutInfo_label.Left = (this.ClientSize.Width - AboutInfo_label.Width) / 2;
            Info_richTextBox.Text = GetApplicationInfo();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private string GetApplicationInfo()
        {
            string info = File.ReadAllText(Config.ABOUT_INFO);
            return info;
        }

        private void Info_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
