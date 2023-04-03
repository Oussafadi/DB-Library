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

namespace THE_APPLICATION
{
    public partial class gestion_des_notes : Form
    {
        public gestion_des_notes()
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
            int idN=0;
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
                    
                    MessageBox.Show("id= "+idN+",Note= "+noteN);
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
