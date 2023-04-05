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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            List<dynamic> l = Model.all<Matiere>();
            foreach (var i in l)
            {
                this.comboBox1.Items.Add(((Matiere)i).code.ToString());
            }
            codbox.Clear();
            notebox.Clear();

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int existN = -1;
            int existE = -1;
            Note n = new Note();
            n.note = float.Parse(notebox.Text);
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
                        existN = 1;
                    }
                }

                if (existN == -1) { n.save("NoteInsert");
                    MessageBox.Show("Ajouter avec succes !!");
                } else
                {
                    MessageBox.Show("la note est deja insere pour ce eleve !!");
                }
            }
            if (existE == -1)
            {
                MessageBox.Show("le code d'eleve n'existe pas !!");
            }

            codbox.Clear();
            notebox.Clear();

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int existN = -1;
            int existE = -1;
            Note n = new Note();
            n.note = float.Parse(notebox.Text);
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
                        existN = 1;
                    }
                }

                if (existN == 1) { n.save("NoteUpdate");
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

        private void bkp_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"C:\Users\yassine\Desktop\gilani\MINI_PROJECT_C_SHARP\MINI_PROJECT_C_SHARP\Access\ENSAT.xml");
            XElement root = x.Root;
            //naa i will go explicit
            /*<Eleves></Eleves>
            <Filieres></Filieres>
            <Matieres></Matieres>
            <Modules></Modules>
            <Moyennes></Moyennes>*/

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

            foreach (var ee in notes.Elements("Eleve"))
            {
                List<dynamic> le = Model.all<Eleve>();
                Eleve elv = new Eleve();
                elv.id = 0;
                elv.nom = ee.Element("nom").Value;
                elv.prenom = ee.Element("prenom").Value;
                elv.niveau = ee.Element("note").Value;
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
    


        
    }
}
