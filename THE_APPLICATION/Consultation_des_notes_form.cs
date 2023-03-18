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
using MODELES;

namespace THE_APPLICATION
{
    
    public partial class Consultation_des_notes_form : Form
    {
        Filiere selected_filiere = null;
        String selected_niveau = null;
        Matiere selcted_matiere = null;
        public Consultation_des_notes_form()
        {
            InitializeComponent();
            init();
        }


        private void init() {

            foreach(Filiere filiere in Model.all<Filiere>()) {
                this.filiere_combo_box.Items.Add(filiere);
            }
        }

        private void filiere_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_filiere = (Filiere) filiere_combo_box.SelectedItem;

            foreach (Filiere filiere in Model.all<Filiere>())
            {
                this.filiere_combo_box.Items.Add(filiere);
            }
        }
    }
}
