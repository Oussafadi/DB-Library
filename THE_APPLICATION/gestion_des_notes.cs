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
using System.Xml.Linq;

namespace THE_APPLICATION
{
    public partial class Gestion_des_notes : Form
    {
        public Gestion_des_notes()
        {
            DataAccess.Connexion.Connect();

            InitializeComponent();
            List<dynamic> l = Model.all<Matiere>();
            foreach (var i in l)
            {
                this.comboBox1.Items.Add(((Matiere)i).code.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
           
            codbox.Clear();
            notebox.Clear();

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int existN = -1;
            int existE = -1;
            string codefiliere="";
            string niveau="";
            Note n = new Note();
            n.code_eleve = codbox.Text;
            n.code_matiere = comboBox1.Text;
            List<dynamic> ln = Model.all<Note>();
            List<dynamic> le = Model.all<Eleve>();
            
            //for eleve
            if (notebox.Text == "") { MessageBox.Show("insere une note !!"); }
            else
            {
                n.note = float.Parse(notebox.Text);

                foreach (var i in le)
                {
                    if (((Eleve)i).code == n.code_eleve)
                    {
                        codefiliere = ((Eleve)i).code_filiere;
                        niveau =((Eleve)i).niveau;
                        existE = 1;
                        break;
                    }
                }
                if (existE == 1)
                {
                    //for note
                    foreach (var i in ln)
                    {
                        if ((((Note)i).code_eleve == n.code_eleve) && (((Note)i).code_matiere == n.code_matiere))
                        {
                            existN = 1;
                        }
                    }

                    if (existN == -1)
                    {
                        n.save("NoteInsert");
                        MessageBox.Show("Ajouter avec succes !!");
                    }
                    else
                    {
                        MessageBox.Show("la note est deja insere pour ce eleve !!");
                    }
                }
                if (existE == -1)
                {
                    MessageBox.Show("le code d'eleve n'existe pas !!");
                }

                //calcul moyen
                int counter = 0;
                List<dynamic> matieres = new List<dynamic>();

                // join, kinda to get the matiere 
                Dictionary<string, object> rules_module = new Dictionary<string, object>();
                rules_module["niveau"] = niveau;
                rules_module["code_filiere"] = codefiliere;
                foreach (Module module in Model.select<Module>(rules_module)) {

                    Dictionary<string, object> rules_matiere = new Dictionary<string, object>();
                    rules_matiere["code_module"] = module.code;

                    foreach (Matiere matiere in Model.select<Matiere>(rules_matiere)) {
                        matieres.Add(matiere);
                    }

                }


                float moyene = 0;
                foreach (var i in ln)
                {
                    if (((Note)i).code_eleve == n.code_eleve)
                    {
                        moyene = moyene + ((Note)i).note;
                        counter++;
                    }
                }
            

                if (counter+1 == matieres.Count)
                {
                    MessageBox.Show("La moyenne est calculer.");
                    Moyenne m = new Moyenne();
                    m.code_eleve = n.code_eleve;
                    m.code_filiere = codefiliere;
                    m.niveau = niveau;
                    m.moyenne = moyene/counter;
                    m.save();
                }

            }
           
        }

        private void add_moyenne() { 
        
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string codefiliere = "";
            string niveau = "";
            int existN = -1;
            int existE = -1;
            Note n = new Note();
            n.code_eleve = codbox.Text;
            n.code_matiere = comboBox1.Text;
            List<dynamic> ln = Model.all<Note>();
            List<dynamic> le = Model.all<Eleve>();
            //for eleve
            if (notebox.Text == "") { MessageBox.Show("insere une note !!"); }
            else
            {
                n.note = float.Parse(notebox.Text);

                foreach (var i in le)
                {
                    if (((Eleve)i).code == n.code_eleve)
                    {
                        codefiliere = ((Eleve)i).code_filiere;
                        niveau = ((Eleve)i).niveau;
                        existE = 1;

                    }
                }
                if (existE == 1)
                {
                    //for note
                    foreach (var i in ln)
                    {
                        if ((((Note)i).code_eleve == n.code_eleve) && (((Note)i).code_matiere == n.code_matiere))
                        {
                            existN = 1;
                        }
                    }

                    if (existN == 1)
                    {
                        n.save("NoteUpdate");
                        MessageBox.Show("Modifier avec succes !!");
                    }
                    else
                    {
                        MessageBox.Show("la note n'existe pas !!");
                    }
                }
                if (existE == -1)
                {
                    MessageBox.Show("le code d'eleve n'existe pas !!");
                }

                //calcul moyen
                int counter = 0;
                List<dynamic> matieres = new List<dynamic>();

                // join, kinda to get the matiere 
                Dictionary<string, object> rules_module = new Dictionary<string, object>();
                rules_module["niveau"] = niveau;
                rules_module["code_filiere"] = codefiliere;
                foreach (Module module in Model.select<Module>(rules_module))
                {

                    Dictionary<string, object> rules_matiere = new Dictionary<string, object>();
                    rules_matiere["code_module"] = module.code;

                    foreach (Matiere matiere in Model.select<Matiere>(rules_matiere))
                    {
                        matieres.Add(matiere);
                    }

                }
                float moyene = 0;
                foreach (var i in ln)
                {
                    if (((Note)i).code_eleve == n.code_eleve)
                    {
                        moyene = moyene + ((Note)i).note;
                        counter++;
                    }
                }


                if (counter  == matieres.Count)
                {
                    MessageBox.Show("La moyenne est calculer.");
                    Moyenne m = new Moyenne();
                    m.code_eleve = n.code_eleve;
                    m.code_filiere = codefiliere;
                    m.niveau = niveau;
                    m.moyenne = moyene / counter;
                    m.save();
                }


            }


        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int idN = 0;
            int existN = -1;
            int existE = -1;
            Note n = new Note();

            n.code_eleve = codbox.Text;
            n.code_matiere = comboBox1.Text;
            List<dynamic> ln = Model.all<Note>();
            List<dynamic> le = Model.all<Eleve>();
            //for eleve
            foreach (var i in le)
            {
                if (((Eleve)i).code == n.code_eleve)
                {
                    existE = 1;

                }
            }
            if (existE == 1)
            {
                //for note
                foreach (var i in ln)
                {
                    if ((((Note)i).code_eleve == n.code_eleve) && (((Note)i).code_matiere == n.code_matiere))
                    {
                        idN = ((Note)i).id;
                        n.note = ((Note)i).note;
                        existN = 1;
                    }
                }
                if (existN == 1) {

                    n.id = idN;
                    n.delete("NoteDelete");
                    MessageBox.Show("Supprimer avec succes !!");
                }
                else
                {
                    MessageBox.Show("la note n'existe pas !!");
                }
            }
            if (existE == -1)
            {
                MessageBox.Show("le code d'eleve n'existe pas !!");
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            float noteN = 0;
            int idN = 0;
            int existN = -1;
            int existE = -1;
            Note n = new Note();

            n.code_eleve = codbox.Text;
            n.code_matiere = comboBox1.Text;
            List<dynamic> ln = Model.all<Note>();
            List<dynamic> le = Model.all<Eleve>();
            //for eleve
            foreach (var i in le)
            {
                if (((Eleve)i).code == n.code_eleve)
                {
                    existE = 1;

                }
            }
            if (existE == 1)
            {
                //for note
                foreach (var i in ln)
                {
                    if ((((Note)i).code_eleve == n.code_eleve) && (((Note)i).code_matiere == n.code_matiere))
                    {
                        idN = ((Note)i).id;
                        noteN = ((Note)i).note;
                        existN = 1;
                    }
                }
                if (existN == 1)
                {
                    n.id = idN;

                    MessageBox.Show("id= " + idN + ",Note= " + noteN);
                }
                else
                {
                    MessageBox.Show("la note n'existe pas !!");
                }
            }
            if (existE == -1)
            {
                MessageBox.Show("le code d'eleve n'existe pas !!");
            }
        }
  
    }
}
