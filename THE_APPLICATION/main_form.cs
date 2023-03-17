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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultation_des_notes_form = new Consultation_des_notes_form();
            consultation_des_notes_form.MdiParent = this;
            consultation_des_notes_form.Show();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Bilan_annuel bn =  new Bilan_annuel();
            bn.MdiParent = this;
            bn.Show();
        }
    }
}
