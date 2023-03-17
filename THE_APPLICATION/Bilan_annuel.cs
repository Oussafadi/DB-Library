using DataAccess;
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
    public partial class Bilan_annuel : Form
    {
        //List<Filiere> filieres;
        //List<Eleve> eleves;

        public Bilan_annuel()
        {
            InitializeComponent();
            Filiere fil = new Filiere();
            //   var filieres = Model.all<Filiere>();
            var filieres = fil.All();
            foreach (var fi in filieres)
            {
                comboBoxFiliere.Items.Add(fi.code);
            }
            //Eleve elv = new Eleve();
            //var eleves = elv.All();
            //foreach ( var eleve in eleves )
            //{
            //    comboBoxEtudiant.Items.Add(eleve.nom + eleve.prenom);
            //}
        }

        private void Bilan_annuel_Load(object sender, EventArgs e)
        {
          
        }
    }
}
