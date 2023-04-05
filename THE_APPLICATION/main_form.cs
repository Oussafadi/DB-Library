using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace THE_APPLICATION
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ExecutablePath;
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultation_des_notes_form = new Consultation_des_notes_form();
            consultation_des_notes_form.MdiParent = this;
            consultation_des_notes_form.Show();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilan_annuel bn =  new Bilan_annuel();
            bn.MdiParent = this;
            bn.Show();
        }

        private void env_detection()
        {
            FolderBrowserDialog folder_browser = new FolderBrowserDialog();
            folder_browser.ShowDialog();

            Config.DATA_FOLDER = folder_browser.SelectedPath;
            Config.CONFIG_FOLDER += Config.DATA_FOLDER + "\\Config";
            Config.ENV_FILE += Config.CONFIG_FOLDER + "\\.env";

            DataAccess.Connexion.file = Config.ENV_FILE;

            this.Text = Config.ENV_FILE;
        }
    }
}
