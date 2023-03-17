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
            this.label2 = new System.Windows.Forms.Label();
            this.moy_text_box = new System.Windows.Forms.TextBox();
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
            this.filiere_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // matiere_label
            // 
            this.matiere_label.AutoSize = true;
            this.matiere_label.Location = new System.Drawing.Point(31, 69);
            this.matiere_label.Name = "matiere_label";
            this.matiere_label.Size = new System.Drawing.Size(42, 13);
            this.matiere_label.TabIndex = 1;
            this.matiere_label.Text = "Matiere";
            // 
            // filiere_combo_box
            // 
            this.filiere_combo_box.FormattingEnabled = true;
            this.filiere_combo_box.Location = new System.Drawing.Point(114, 28);
            this.filiere_combo_box.Name = "filiere_combo_box";
            this.filiere_combo_box.Size = new System.Drawing.Size(121, 21);
            this.filiere_combo_box.TabIndex = 2;
            // 
            // matiere_combo_box
            // 
            this.matiere_combo_box.FormattingEnabled = true;
            this.matiere_combo_box.Location = new System.Drawing.Point(114, 69);
            this.matiere_combo_box.Name = "matiere_combo_box";
            this.matiere_combo_box.Size = new System.Drawing.Size(121, 21);
            this.matiere_combo_box.TabIndex = 3;
            // 
            // rechercher_button
            // 
            this.rechercher_button.Location = new System.Drawing.Point(340, 69);
            this.rechercher_button.Name = "rechercher_button";
            this.rechercher_button.Size = new System.Drawing.Size(121, 23);
            this.rechercher_button.TabIndex = 4;
            this.rechercher_button.Text = "Rechercher";
            this.rechercher_button.UseVisualStyleBackColor = true;
            // 
            // niveau_label
            // 
            this.niveau_label.AutoSize = true;
            this.niveau_label.Location = new System.Drawing.Point(280, 31);
            this.niveau_label.Name = "niveau_label";
            this.niveau_label.Size = new System.Drawing.Size(41, 13);
            this.niveau_label.TabIndex = 5;
            this.niveau_label.Text = "Niveau";
            // 
            // niveau_combo_box
            // 
            this.niveau_combo_box.FormattingEnabled = true;
            this.niveau_combo_box.Location = new System.Drawing.Point(340, 28);
            this.niveau_combo_box.Name = "niveau_combo_box";
            this.niveau_combo_box.Size = new System.Drawing.Size(121, 21);
            this.niveau_combo_box.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Moyenne de la class";
            // 
            // moy_text_box
            // 
            this.moy_text_box.Location = new System.Drawing.Point(181, 350);
            this.moy_text_box.Name = "moy_text_box";
            this.moy_text_box.Size = new System.Drawing.Size(100, 20);
            this.moy_text_box.TabIndex = 9;
            // 
            // Consultation_des_notes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 403);
            this.Controls.Add(this.moy_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau_combo_box);
            this.Controls.Add(this.niveau_label);
            this.Controls.Add(this.rechercher_button);
            this.Controls.Add(this.matiere_combo_box);
            this.Controls.Add(this.filiere_combo_box);
            this.Controls.Add(this.matiere_label);
            this.Controls.Add(this.filiere_label);
            this.Name = "Consultation_des_notes_form";
            this.Text = "Consultation des notes";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox moy_text_box;
    }
}