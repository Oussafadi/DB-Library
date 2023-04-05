using System.Data;

namespace THE_APPLICATION
{
    partial class Consultation_des_notes_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filiere_label = new System.Windows.Forms.Label();
            this.matiere_label = new System.Windows.Forms.Label();
            this.filiere_combo_box = new System.Windows.Forms.ComboBox();
            this.matiere_combo_box = new System.Windows.Forms.ComboBox();
            this.rechercher_button = new System.Windows.Forms.Button();
            this.niveau_label = new System.Windows.Forms.Label();
            this.niveau_combo_box = new System.Windows.Forms.ComboBox();
            this.moy_label = new System.Windows.Forms.Label();
            this.moy_text_box = new System.Windows.Forms.TextBox();
            this.notes_grid = new System.Windows.Forms.DataGridView();
            this.data_table = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(this.notes_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // filiere_label
            // 
            this.filiere_label.AutoSize = true;
            this.filiere_label.Location = new System.Drawing.Point(31, 31);
            this.filiere_label.Name = "filiere_label";
            this.filiere_label.Size = new System.Drawing.Size(34, 13);
            this.filiere_label.TabIndex = 0;
            this.filiere_label.Text = "Filiere";
            // 
            // matiere_label
            // 
            this.matiere_label.AutoSize = true;
            this.matiere_label.Location = new System.Drawing.Point(31, 64);
            this.matiere_label.Name = "matiere_label";
            this.matiere_label.Size = new System.Drawing.Size(42, 13);
            this.matiere_label.TabIndex = 1;
            this.matiere_label.Text = "Matiere";
            // 
            // filiere_combo_box
            // 
            this.filiere_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_combo_box.FormattingEnabled = true;
            this.filiere_combo_box.Location = new System.Drawing.Point(114, 28);
            this.filiere_combo_box.Name = "filiere_combo_box";
            this.filiere_combo_box.Size = new System.Drawing.Size(156, 21);
            this.filiere_combo_box.TabIndex = 2;
            this.filiere_combo_box.SelectedIndexChanged += new System.EventHandler(this.filiere_combo_box_SelectedIndexChanged);
            // 
            // matiere_combo_box
            // 
            this.matiere_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matiere_combo_box.FormattingEnabled = true;
            this.matiere_combo_box.Location = new System.Drawing.Point(114, 61);
            this.matiere_combo_box.Name = "matiere_combo_box";
            this.matiere_combo_box.Size = new System.Drawing.Size(156, 21);
            this.matiere_combo_box.TabIndex = 3;
            this.matiere_combo_box.SelectedIndexChanged += new System.EventHandler(this.matiere_combo_box_SelectedIndexChanged);
            // 
            // rechercher_button
            // 
            this.rechercher_button.Location = new System.Drawing.Point(401, 59);
            this.rechercher_button.Name = "rechercher_button";
            this.rechercher_button.Size = new System.Drawing.Size(161, 23);
            this.rechercher_button.TabIndex = 4;
            this.rechercher_button.Text = "Rechercher";
            this.rechercher_button.UseVisualStyleBackColor = true;
            this.rechercher_button.Click += new System.EventHandler(this.rechercher_button_Click);
            // 
            // niveau_label
            // 
            this.niveau_label.AutoSize = true;
            this.niveau_label.Location = new System.Drawing.Point(341, 31);
            this.niveau_label.Name = "niveau_label";
            this.niveau_label.Size = new System.Drawing.Size(41, 13);
            this.niveau_label.TabIndex = 5;
            this.niveau_label.Text = "Niveau";
            // 
            // niveau_combo_box
            // 
            this.niveau_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niveau_combo_box.FormattingEnabled = true;
            this.niveau_combo_box.Location = new System.Drawing.Point(401, 28);
            this.niveau_combo_box.Name = "niveau_combo_box";
            this.niveau_combo_box.Size = new System.Drawing.Size(161, 21);
            this.niveau_combo_box.TabIndex = 6;
            this.niveau_combo_box.SelectedIndexChanged += new System.EventHandler(this.niveau_combo_box_SelectedIndexChanged);
            // 
            // moy_label
            // 
            this.moy_label.AutoSize = true;
            this.moy_label.Location = new System.Drawing.Point(20, 313);
            this.moy_label.Name = "moy_label";
            this.moy_label.Size = new System.Drawing.Size(104, 13);
            this.moy_label.TabIndex = 8;
            this.moy_label.Text = "Moyenne de la class";
            // 
            // moy_text_box
            // 
            this.moy_text_box.Location = new System.Drawing.Point(170, 310);
            this.moy_text_box.Name = "moy_text_box";
            this.moy_text_box.ReadOnly = true;
            this.moy_text_box.Size = new System.Drawing.Size(100, 20);
            this.moy_text_box.TabIndex = 9;
            // 
            // notes_grid
            // 
            this.notes_grid.AllowUserToAddRows = false;
            this.notes_grid.AllowUserToDeleteRows = false;
            this.notes_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notes_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notes_grid.Location = new System.Drawing.Point(23, 114);
            this.notes_grid.Name = "notes_grid";
            this.notes_grid.ReadOnly = true;
            this.notes_grid.Size = new System.Drawing.Size(625, 165);
            this.notes_grid.TabIndex = 10;
            this.notes_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notes_grid_CellContentClick);
            // 
            // Consultation_des_notes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 356);
            this.Controls.Add(this.notes_grid);
            this.Controls.Add(this.moy_text_box);
            this.Controls.Add(this.moy_label);
            this.Controls.Add(this.niveau_combo_box);
            this.Controls.Add(this.niveau_label);
            this.Controls.Add(this.rechercher_button);
            this.Controls.Add(this.matiere_combo_box);
            this.Controls.Add(this.filiere_combo_box);
            this.Controls.Add(this.matiere_label);
            this.Controls.Add(this.filiere_label);
            this.Name = "Consultation_des_notes_form";
            this.Text = "Consultation des notes";
            ((System.ComponentModel.ISupportInitialize)(this.notes_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filiere_label;
        private System.Windows.Forms.Label matiere_label;
        private System.Windows.Forms.ComboBox filiere_combo_box;
        private System.Windows.Forms.ComboBox matiere_combo_box;
        private System.Windows.Forms.Button rechercher_button;
        private System.Windows.Forms.Label niveau_label;
        private System.Windows.Forms.ComboBox niveau_combo_box;
        private System.Windows.Forms.Label moy_label;
        private System.Windows.Forms.TextBox moy_text_box;
        private System.Windows.Forms.DataGridView notes_grid;

    }
}