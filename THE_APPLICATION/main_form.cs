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
using MODELES;
using System.Xml.Linq;

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

        private void backup()
        {
            XDocument x = XDocument.Load(Config.XML_BACKUP_FILE);
            XElement root = x.Root;
            //naa i will go explicit


            XElement notes = root.Element("Notes");
            XElement eleves = root.Element("Eleves");
            XElement filieres = root.Element("Filieres");
            XElement matieres = root.Element("Matieres");
            XElement modules = root.Element("Modules");
            XElement moyennes = root.Element("Moyennes");

            //note

            foreach (var ne in notes.Elements("Note"))
            {
                List<dynamic> ln = Model.all<Note>();
                Note n = new Note();
                n.id = 0;
                n.code_eleve = ne.Element("code_eleve").Value;
                n.code_matiere = ne.Element("code_matiere").Value;
                n.note = float.Parse(ne.Element("note").Value);
                foreach (var i in ln)
                {
                    if ((((Note)i).code_eleve == n.code_eleve) && (((Note)i).code_matiere == n.code_matiere))
                    {
                        n.id = ((Note)i).id;

                    }



                }
                n.save();

            }
            //eleve

            foreach (var ee in eleves.Elements("Eleve"))
            {
                List<dynamic> le = Model.all<Eleve>();
                Eleve elv = new Eleve();
                elv.id = 0;
                elv.nom = ee.Element("nom").Value;
                elv.prenom = ee.Element("prenom").Value;
                elv.niveau = ee.Element("niveau").Value;
                elv.code = ee.Element("code").Value;
                elv.code_filiere = ee.Element("code_filiere").Value;
                foreach (var i in le)
                {
                    if (((Eleve)i).code == elv.code)
                    {
                        elv.id = ((Eleve)i).id;

                    }



                }
                elv.save();

            }

            //Filiere

            foreach (var fe in filieres.Elements("Filiere"))
            {
                List<dynamic> lf = Model.all<Note>();
                Filiere f = new Filiere();
                f.id = 0;
                f.code = fe.Element("code").Value;
                f.designation = fe.Element("designation").Value;

                foreach (var i in lf)
                {
                    if (((Filiere)i).code == f.code)
                    {
                        f.id = ((Filiere)i).id;

                    }



                }
                f.save();

            }

            //Matiere

            foreach (var ma in matieres.Elements("Matiere"))
            {
                List<dynamic> lm = Model.all<Matiere>();
                Matiere m = new Matiere();
                m.id = 0;
                m.code_module = ma.Element("code_module").Value;
                m.code = ma.Element("code").Value;
                m.designation = ma.Element("designation").Value;
                foreach (var i in lm)
                {
                    if (((Matiere)i).code == m.code)
                    {
                        m.id = ((Matiere)i).id;

                    }



                }
                m.save();

            }

            //Modules

            foreach (var me in modules.Elements("Module"))
            {
                List<dynamic> lmo = Model.all<Module>();
                Module mo = new Module();
                mo.id = 0;
                mo.code = me.Element("code").Value;
                mo.code_filiere = me.Element("code_filiere").Value;
                mo.designation = me.Element("designation").Value;
                foreach (var i in lmo)
                {
                    if (((Module)i).code == mo.code)
                    {
                        mo.id = ((Module)i).id;

                    }



                }
                mo.save();

            }

            //Moyennes

            foreach (var mye in moyennes.Elements("Moyenne"))
            {
                List<dynamic> lmy = Model.all<Moyenne>();
                Moyenne my = new Moyenne();
                my.id = 0;
                my.code_eleve = mye.Element("code_eleve").Value;
                my.code_filiere = mye.Element("code_filiere").Value;
                my.moyenne = float.Parse(mye.Element("moyenne").Value);
                foreach (var i in lmy)
                {
                    if ((((Moyenne)i).code_eleve == my.code_eleve) && (((Moyenne)i).code_filiere == my.code_filiere))
                    {
                        my.id = ((Moyenne)i).id;

                    }



                }
                my.save();

            }

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup();
            MessageBox.Show("Restored!");
        }
    }
}
