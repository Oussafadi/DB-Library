using DataAccess;
using MODELES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;


namespace THE_APPLICATION
{
    public partial class Bilan_annuel : Form
    {
        List<dynamic> Filieres;
        List<dynamic> Eleves;
        List<dynamic> niveaux;
        List<dynamic> notesList;
        Filiere filSelected;
        Eleve elvSelected;
        string nvSelected;

        public class NoteEtd
        {
            public string code_matiere { get; set; }
            public string designation { get; set; }
            public string semestre { get; set; }
            public float note { get; set; }

        }
        public Bilan_annuel()
        {
            
            InitializeComponent();
           
            
        }

        private void Bilan_annuel_Load(object sender, EventArgs e)
        {
            Filiere fil = new Filiere();
            Filieres = fil.All();
            foreach (var fi in Filieres)
            {
                comboBoxFiliere.Items.Add(fi.code);
            }

            comboBoxEtudiant.Enabled = false;
            comboBoxNiveau.Enabled = false;
        }

        private void comboBoxFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------
            export_button.Enabled = false;
            //-------------------------------

            // test requete linq ::::: ca marche
            filSelected = (from Filiere f in Filieres
                           where f.code == comboBoxFiliere.Text
                           select f).First();

            comboBoxNiveau.Items.Clear();
            comboBoxNiveau.Text = "";
   
            List<dynamic> modules = Model.select<Module>(new Dictionary<string, object> { { "code_filiere", filSelected.code } } );
            niveaux = ( from dynamic m in modules select m.niveau ).Distinct().ToList();
            comboBoxNiveau.Items.AddRange(niveaux.ToArray());
            comboBoxNiveau.Enabled = true;

        }

        private void comboBoxNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {

            //-------------------------------
            export_button.Enabled = false;
            //-------------------------------

            nvSelected = comboBoxNiveau.Text;
            Eleves = Model.select<Eleve>(new Dictionary<string, object>() { { "niveau", nvSelected } , { "code_filiere" , filSelected.code } });
            comboBoxEtudiant.Items.Clear();
            comboBoxEtudiant.Text = "";
            foreach ( var elv in Eleves )
            {
                comboBoxEtudiant.Items.Add(elv.nom + " " + elv.prenom);
            }
            comboBoxEtudiant.Enabled = true;
            

        }

        private void comboBoxEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------
            export_button.Enabled = false;
            //-------------------------------

            elvSelected = (from Eleve ev in Eleves
                           where (ev.nom + " " + ev.prenom) == comboBoxEtudiant.Text
                           select ev).First();
           // to test
           // textBoxMoy.Text = elvSelected.nom + " " + elvSelected.prenom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( elvSelected == null || nvSelected == null || filSelected == null)
            {
                MessageBox.Show(" Veuillez remplir les informations de l'etudiant pour pouvoir voir ses notes ! ");
                return;
            }

            List<dynamic> modules = Model.select<Module>(new Dictionary<string, object>() { { "code_filiere", filSelected.code } });
 
            if ( modules.Count == 0)
            {
                MessageBox.Show(" Les notes de ce etudiant ne sont pas encore saisies  ");
                return;
            }
            List<KeyValuePair<string, dynamic>> matieres = new List<KeyValuePair<string, dynamic>>();
            foreach (Module module in modules)
            {
                //if ( ! matieres.ContainsKey(module.semestre) )
                //matieres.Add(module.semestre, Model.select<Matiere>(new Dictionary<string, object>() { { "code_module", module.code } })) ;
                foreach (Matiere matiere in Model.select<Matiere>(new Dictionary<string, object>() { { "code_module", module.code } })) {

                    matieres.Add(new KeyValuePair<string, dynamic> (

                        module.semestre,
                        matiere
                    ));
                    
                }

            }
            if (matieres.Count == 0)
            {
                MessageBox.Show(" Les notes de ce etudiant ne sont pas encore saisies  ");
                return;
            }

            notesList = new List<dynamic>();
            Note notevar;

            //foreach (KeyValuePair<string, List<dynamic>> matkv in matieres)
            //{
                foreach (KeyValuePair<string, dynamic>matkv in matieres)
                {
                    
                    notevar = Model.select<Note>(new Dictionary<string, object>() {
                        { "code_matiere", matkv.Value.code },
                        { "code_eleve", elvSelected.code }
                    }).FirstOrDefault();

                    notesList.Add(new NoteEtd()
                    {
                        code_matiere = matkv.Value.code,
                        designation = matkv.Value.designation,
                        semestre = matkv.Key,
                        note = notevar == null ? float.NaN : notevar.note
                    });

                }
            //}
            if ( notesList.Count == 0)
            {
                MessageBox.Show(" Les notes de ce etudiant ne sont pas encore saisies  ");
                return;
            }

            dataGridView1.DataSource= notesList;

            textBoxMoy.Text = (from NoteEtd n in notesList
                              select n.note).Average().ToString();

            Dictionary<string, object> rules = new Dictionary<string, object>()
            {
                ["code_eleve"] = elvSelected.code,
                ["code_filiere"] = filSelected.code,
                ["niveau"] = nvSelected.ToString()
            };

            if (Model.select<Moyenne>(rules).Count != 0)
                export_button.Enabled = true;

        }

        
    }
}
