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
using Mysqlx.Session;

namespace THE_APPLICATION
{
    
    public partial class Consultation_des_notes_form : Form
    {

        DataTable data_table;
        public Consultation_des_notes_form()
        {
            InitializeComponent();
            init();
        }


        private void init() {

            data_table = new DataTable();
            data_table.Columns.Add(new DataColumn("Code"));
            data_table.Columns.Add(new DataColumn("Nom"));
            data_table.Columns.Add(new DataColumn("Prenom"));
            data_table.Columns.Add(new DataColumn("Note"));

            this.notes_grid.DataSource = data_table;

            foreach (Filiere filiere in Model.all<Filiere>()) {
                this.filiere_combo_box.Items.Add(filiere);
            }
        }
        private void reset_combo_box(ComboBox box) {
            box.Items.Clear();
            box.SelectedItem = null;
            box.Text = "";
        }

        private void filiere_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset_combo_box(niveau_combo_box);

            Filiere selected_filiere = (Filiere) filiere_combo_box.SelectedItem;

            niveau_combo_box.Items.Clear();
            niveau_combo_box.Items.Add("1");
            niveau_combo_box.Items.Add("2");
            if (selected_filiere.code != "AP")
                niveau_combo_box.Items.Add("3");

        }

        private void niveau_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            reset_combo_box(matiere_combo_box);

            Filiere selected_filiere = (Filiere)filiere_combo_box.SelectedItem;
            string selected_niveau = niveau_combo_box.SelectedItem.ToString();

            Dictionary<string, object> rules = new Dictionary<string, object>();
            rules["code_filiere"] = selected_filiere.code;
            rules["niveau"] = selected_niveau;

            foreach (Module module in Model.select<Module>(rules))
            {
                Dictionary<string, object> rules_matiere = new Dictionary<string, object>();
                rules["code_module"] = module.code;

                foreach (Matiere matiere in Model.select<Matiere>(rules_matiere))
                {
                    matiere_combo_box.Items.Add(matiere);
                }
            }
        }

        private void matiere_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Matiere selected_matiere = (Matiere)matiere_combo_box.SelectedItem;
        }

        private void rechercher_button_Click(object sender, EventArgs e)
        {

            data_table.Rows.Clear();
            Matiere selected_matiere = (Matiere)matiere_combo_box.SelectedItem;

            if (selected_matiere == null)
                return;

            float moy = .0f;
            int tracker = 0;

            Dictionary<string, object> rules = new Dictionary<string, object>();
            rules["code_matiere"] = selected_matiere.code;

            foreach (Note note in Model.select<Note>(rules)) {

                ++tracker;
                moy += note.note;

                DataRow row = data_table.NewRow();
                row["Code"] = note.code_eleve;
                row["Note"] = note.note;
                // querying the "Eleve"

                Dictionary<string, object> rules_eleve = new Dictionary<string, object>();
                rules["code"] = note.code_eleve;
                foreach (Eleve eleve in Model.select<Eleve>(rules_eleve)) {
                    row["Nom"] = eleve.nom;
                    row["Prenom"] = eleve.nom;
                }
                moy /= tracker;

                moy_text_box.Text = moy.ToString();

                data_table.Rows.Add(row);
            }
        }

        private void notes_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
