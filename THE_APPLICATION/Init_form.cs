using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_APPLICATION
{
    public partial class Init_form : Form
    {
        public Init_form()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_selector = new FolderBrowserDialog();
            folder_selector.ShowDialog();

            folder_path_text.Text = folder_selector.SelectedPath;
            env_path_text.Text = folder_path_text.Text + @"\.env";
        }

        private void Init_form_Load(object sender, EventArgs e)
        {

        }

        private void env_path_text_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(env_path_text.Text))
            {
                status_text.Text = "[Status] Gucci.";
                go_button.Enabled = true;
            }
            else 
            {
                status_text.Text = "[Status] Not valid.";
                go_button.Enabled = false;
            }
        }

        private void env_selector_button_Click(object sender, EventArgs e)
        {
            FileDialog file_selector = new OpenFileDialog();
            file_selector.ShowDialog();

            env_path_text.Text = file_selector.FileName;
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            Config.DATA_FOLDER = folder_path_text.Text;
            Config.ENV_FILE = env_path_text.Text;
            Config.XML_BACKUP_FILE = Config.DATA_FOLDER + @"\backup.xml";
            this.Close();
        }
    }
}
