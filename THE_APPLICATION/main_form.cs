using System;
using System.IO;
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

        }
        private void Form_Shown(object sender, EventArgs e)
        {
            new Init_form().ShowDialog();
            DataAccess.Connexion.file = Config.ENV_FILE;
            DataAccess.Model.xml_path = Config.XML_BACKUP_FILE;
            DataAccess.Connexion.Connect();
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultation_des_notes_form = new Consultation_des_notes_form();
            consultation_des_notes_form.MdiParent = this;
            consultation_des_notes_form.Show();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilan_annuel bn = new Bilan_annuel();
            bn.MdiParent = this;
            bn.Show();
        }

        public static void env_detection()
        {
            //FolderBrowserDialog folder_browser = new FolderBrowserDialog();
            FileDialog file_browser = new OpenFileDialog();
            file_browser.ShowDialog();

            //Config.DATA_FOLDER = folder_browser.SelectedPath;
            //Config.CONFIG_FOLDER += Config.DATA_FOLDER + "\\Config";
            Config.ENV_FILE += file_browser.FileName;

            DataAccess.Connexion.file = Config.ENV_FILE;

        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestion_des_etudiants = new Gestion_des_etudiants_form();
            gestion_des_etudiants.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Gestion_des_note = new Gestion_des_notes();
            Gestion_des_note.ShowDialog();

        }
    }
}
