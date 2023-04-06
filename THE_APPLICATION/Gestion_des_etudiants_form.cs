using DataAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace THE_APPLICATION
{
    public partial class Gestion_des_etudiants_form : Form
    {
        public Gestion_des_etudiants_form()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            //chrger le comboboxk filiere ..
            dataGridView1.Rows.Clear();

            FiliereCombobox.Items.Clear();
            Filiere filiere = new Filiere();
            List<dynamic>  liste =   filiere.All();

            foreach(var l in liste)
            {
                
                FiliereCombobox.Items.Add(((Filiere)l).code);
            }

            //recuperer les eleves et les represeter ff datagriview 
            Eleve ev = new Eleve();
            List<dynamic> eleves = ev.All();
            //le nombre de colomns  ..
            this.dataGridView1.ColumnCount = 5;
            //les columns ..
            dataGridView1.Columns[0].Name = "CODE ELEVE";
            dataGridView1.Columns[1].Name = "NOM";
            dataGridView1.Columns[2].Name = "PRENOM";
            dataGridView1.Columns[3].Name = "FILIERE";
            dataGridView1.Columns[4].Name = "NIVEAU";
            //remlir les lignes ..

            foreach (var ee in eleves)
            {
                Eleve el = (Eleve)ee;

                dataGridView1.Rows.Add(el.code, el.nom, el.prenom, el.code_filiere, el.niveau);
            }
          
        }

      
       

        private void NouveauBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            // if (CodeTxt.Text == "" || NomTxt.Text == "" || PrenomTxt.Text == "" || FiliereCombobox.Text == "" || NiveauCombobox.Text == "") 
            // {

                CodeTxt.Text = "";
                NomTxt.Text = "";
                PrenomTxt.Text = "";
                FiliereCombobox.Text = "";
                NiveauCombobox.Text = "";
                NiveauCombobox.Items.Clear();

            //}
           Form2_Load(this,new EventArgs());    
           
          
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
           
            Boolean UniqueCode = true;
            Boolean ttSelected = true;

            if (CodeTxt.Text=="" || NomTxt.Text == "" || PrenomTxt.Text == "" || FiliereCombobox.Text == "" || NiveauCombobox.Text == "") 
            {
                ttSelected = false;
                //MessageBox.Show("REMLISSEZ TOUS LES CHAMPS", "manque de champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
          
         else
            {
                //verifier l'unicité du code ..

                Eleve ev = new Eleve();
                List<dynamic> eleves = ev.All();

                foreach (var ee in eleves)
                {
                    Eleve el = (Eleve)ee;
                    if(el.code== CodeTxt.Text)
                    {

                        UniqueCode = false;
                        MessageBox.Show("le code doit etre unique .. ", "unicite de code ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }



            }


            if (ttSelected == false)
                {
                    MessageBox.Show("REMLISSEZ TOUS LES CHAMPS", "manque de champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else if(UniqueCode == false)
                {
                    MessageBox.Show("le code doit etre unique", "unicite de code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

             if (UniqueCode == true && ttSelected == true )
             {
                //hinsertion de l'eleve
                // string sqlll = "insert into eleve(code,nom,prenom,niveau,code_filiere) values('eleve1','eleveNom','eleveprenom','niv1','AP')";

                // string sqll ="insert into eleve(code,nom,prenom,niveau,code_filiere) values('"+CodeTxt.Text+"','"+NomTxt.Text+"','"+PrenomTxt.Text+"','"+FiliereCombobox.Text+"','"+NiveauCombobox.Text+"')";
                // DataAccess.Connexion.IUD(sqll);
                Eleve eleve = new Eleve();
                eleve.code = CodeTxt.Text;
                eleve.nom = NomTxt.Text;
                eleve.prenom = PrenomTxt.Text;
                eleve.code_filiere = FiliereCombobox.Text;
                eleve.niveau = NiveauCombobox.Text;
                eleve.save();

                MessageBox.Show("l'eleve est enregestré", "infos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2_Load(this,new EventArgs());
              }



        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
         
            Dictionary<string, object> dico = new Dictionary<string, object>();

            dico.Add("code", CodeTxt.Text);

                Eleve eleve = new Eleve();
                List<dynamic> elevee = eleve.Select(dico);
                eleve.id = elevee[0].id;  
               /* foreach(dynamic d in elevee)
                {
                  foreach(KeyValuePair<string,object> elv in d)
                        {
                         if (elv.Key == "id")
                          eleve.id =Convert.ToInt32(elv.Value);
                        }   
                }
 */ 
               eleve.delete();
          
              
                MessageBox.Show("l'eleve supprimé", "infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
              Form2_Load(this,new EventArgs());

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            // DataAccess.Connexion.IUD(sqll);
            if(CodeTxt.Text=="")
            {
                MessageBox.Show("remplissez le code pour modifier ..", "infos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            Eleve eleve = new Eleve();


            
            //trouver l'id

            List<dynamic> eleves = eleve.All();
            foreach(var elv in eleves)
            {
               eleve.id =((Eleve)elv).id;
          
            }

            
                
             

                eleve.code = CodeTxt.Text;
                eleve.nom = NomTxt.Text;
                eleve.prenom = PrenomTxt.Text;
                eleve.code_filiere = FiliereCombobox.Text;
                eleve.niveau = NiveauCombobox.Text;
            
                eleve.save();


                 Form2_Load(this, new EventArgs());
                 MessageBox.Show("l'eleve  modifié", "infos", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
        }

       

        private void FiliereCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

                Dictionary<string,object> dico = new Dictionary<string, object>();
                string varr = FiliereCombobox.Text.ToString();
                dico.Add("code_filiere",varr);
                //string req = "SELECT DISTINCT niveau FROM eleve where code_filiere ='"+varr+"'";
                    
                    Eleve el = new Eleve();
                    List<dynamic> eleves = el.Select(dico);
                    //CodeTxt.Text = eleves[0].niveau;
           foreach(dynamic obj in eleves)
            {
               
                 if(!NiveauCombobox.Items.Contains(obj.niveau))
                 NiveauCombobox.Items.Add(obj.niveau);
            }
                  // NiveauCombobox.Items.Add(o.Value);
            /*  foreach(dynamic obj in eleves)
                    {
                       foreach(KeyValuePair<string,object> o in obj)
                            {

                                    if (o.Key == "niveau")
                                    {
                                        if(!NiveauCombobox.Items.Contains(o.Value))
                                        NiveauCombobox.Items.Add(o.Value);
                                    }
                            }
                    }
               */

        }


     

        private void RechercherBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource= null;
            dataGridView1.Rows.Clear();
            //le nombre de colomns  ..
            this.dataGridView1.ColumnCount = 5;

            //les columns ..

            dataGridView1.Columns[0].Name = "CODE ELEVE";
            dataGridView1.Columns[1].Name = "NOM";
            dataGridView1.Columns[2].Name = "PRENOM";
            dataGridView1.Columns[4].Name = "NIVEAU";
            dataGridView1.Columns[3].Name = "FILIERE";
            
           
            
            Dictionary<string,object> dico = new Dictionary<string,object>();
            if(!CheckCode.Checked && !CheckNom.Checked && !CheckPrenom.Checked && !CheckFiliere.Checked && !CheckNiveau.Checked)
            {
                MessageBox.Show("rien n'est selectionné", "infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (CheckCode.Checked)
            {
                dico.Add("code",CodeTxt.Text);
            }
           
           
                    if (CheckNom.Checked)
                    {
                        dico.Add("nom",NomTxt.Text);
                    }
                    if (CheckPrenom.Checked)
                    {
                        dico.Add("prenom", PrenomTxt.Text);
                    }
                    if (CheckNiveau.Checked)
                    {
                        dico.Add("niveau", NiveauCombobox.Text);
                    }
                    if (CheckFiliere.Checked)
                    {
                        dico.Add("code_filiere",FiliereCombobox.Text);
                    }


            if (!CheckCode.Checked)
            {

                dico.Remove("code");
            }


            if (!CheckNom.Checked)
            {
                dico.Remove("nom");
            }
            if (!CheckPrenom.Checked)
            {
                dico.Remove("prenom");
            }
            if (!CheckNiveau.Checked)
            {
                dico.Remove("niveau");
            }
            if (!CheckFiliere.Checked)
            {
                dico.Remove("code_filiere");
            }
            List<String> lis = new List<String>();
                //extraire just l'elve conserné .. et l'afficher dans datagridView ..
                
                Eleve eleve = new Eleve();
                List<dynamic> liste = eleve.Select(dico);

               
                
            foreach (dynamic d in liste)

                {
                    
                   // foreach (KeyValuePair<string, Object> ss in d)
                    
                        
                            
                                    lis.Add(d.code);
                lis.Add(d.nom);
                lis.Add(d.prenom);
                lis.Add(d.niveau);
                lis.Add(d.code_filiere);
                        
                    
                   
                    dataGridView1.Rows.Add(lis[0], lis[1], lis[2], lis[3], lis[4]);
                    lis.Clear();
                
               }


        }
    }//fin de la class
}
