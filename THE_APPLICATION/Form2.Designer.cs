namespace THE_APPLICATION
{
    partial class Form2
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
            this.NouveauBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.Gestion_nnotesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FiliereCombobox = new System.Windows.Forms.ComboBox();
            this.NiveauCombobox = new System.Windows.Forms.ComboBox();
            this.PrenomTxt = new System.Windows.Forms.TextBox();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckCode = new System.Windows.Forms.CheckBox();
            this.CheckNom = new System.Windows.Forms.CheckBox();
            this.CheckFiliere = new System.Windows.Forms.CheckBox();
            this.CheckPrenom = new System.Windows.Forms.CheckBox();
            this.CheckNiveau = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NouveauBtn
            // 
            this.NouveauBtn.Location = new System.Drawing.Point(602, 13);
            this.NouveauBtn.Name = "NouveauBtn";
            this.NouveauBtn.Size = new System.Drawing.Size(158, 23);
            this.NouveauBtn.TabIndex = 0;
            this.NouveauBtn.Text = "Nouveau";
            this.NouveauBtn.UseVisualStyleBackColor = true;
            this.NouveauBtn.Click += new System.EventHandler(this.NouveauBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.Location = new System.Drawing.Point(602, 56);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(158, 23);
            this.AjouterBtn.TabIndex = 1;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = true;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(602, 96);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(158, 23);
            this.ModifierBtn.TabIndex = 2;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.Location = new System.Drawing.Point(602, 137);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(158, 23);
            this.SupprimerBtn.TabIndex = 3;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = true;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.Location = new System.Drawing.Point(602, 179);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(158, 23);
            this.RechercherBtn.TabIndex = 4;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = true;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // Gestion_nnotesBtn
            // 
            this.Gestion_nnotesBtn.Location = new System.Drawing.Point(602, 219);
            this.Gestion_nnotesBtn.Name = "Gestion_nnotesBtn";
            this.Gestion_nnotesBtn.Size = new System.Drawing.Size(158, 23);
            this.Gestion_nnotesBtn.TabIndex = 5;
            this.Gestion_nnotesBtn.Text = "Gestion notes";
            this.Gestion_nnotesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filiere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Niveau";
            // 
            // FiliereCombobox
            // 
            this.FiliereCombobox.FormattingEnabled = true;
            this.FiliereCombobox.Location = new System.Drawing.Point(258, 166);
            this.FiliereCombobox.Name = "FiliereCombobox";
            this.FiliereCombobox.Size = new System.Drawing.Size(209, 21);
            this.FiliereCombobox.TabIndex = 11;
            this.FiliereCombobox.SelectedIndexChanged += new System.EventHandler(this.FiliereCombobox_SelectedIndexChanged_1);
            // 
            // NiveauCombobox
            // 
            this.NiveauCombobox.FormattingEnabled = true;
            this.NiveauCombobox.Location = new System.Drawing.Point(258, 214);
            this.NiveauCombobox.Name = "NiveauCombobox";
            this.NiveauCombobox.Size = new System.Drawing.Size(209, 21);
            this.NiveauCombobox.TabIndex = 12;
            // 
            // PrenomTxt
            // 
            this.PrenomTxt.Location = new System.Drawing.Point(258, 115);
            this.PrenomTxt.Name = "PrenomTxt";
            this.PrenomTxt.Size = new System.Drawing.Size(212, 20);
            this.PrenomTxt.TabIndex = 13;
            // 
            // NomTxt
            // 
            this.NomTxt.Location = new System.Drawing.Point(258, 70);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(212, 20);
            this.NomTxt.TabIndex = 14;
            // 
            // CodeTxt
            // 
            this.CodeTxt.Location = new System.Drawing.Point(258, 19);
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(212, 20);
            this.CodeTxt.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 229);
            this.dataGridView1.TabIndex = 16;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // CheckCode
            // 
            this.CheckCode.AutoSize = true;
            this.CheckCode.Location = new System.Drawing.Point(491, 22);
            this.CheckCode.Name = "CheckCode";
            this.CheckCode.Size = new System.Drawing.Size(15, 14);
            this.CheckCode.TabIndex = 17;
            this.CheckCode.UseVisualStyleBackColor = true;
           // this.CheckCode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckNom
            // 
            this.CheckNom.AutoSize = true;
            this.CheckNom.Location = new System.Drawing.Point(491, 73);
            this.CheckNom.Name = "CheckNom";
            this.CheckNom.Size = new System.Drawing.Size(15, 14);
            this.CheckNom.TabIndex = 18;
            this.CheckNom.UseVisualStyleBackColor = true;
            // 
            // CheckFiliere
            // 
            this.CheckFiliere.AutoSize = true;
            this.CheckFiliere.Location = new System.Drawing.Point(491, 173);
            this.CheckFiliere.Name = "CheckFiliere";
            this.CheckFiliere.Size = new System.Drawing.Size(15, 14);
            this.CheckFiliere.TabIndex = 19;
            this.CheckFiliere.UseVisualStyleBackColor = true;
            // 
            // CheckPrenom
            // 
            this.CheckPrenom.AutoSize = true;
            this.CheckPrenom.Location = new System.Drawing.Point(491, 122);
            this.CheckPrenom.Name = "CheckPrenom";
            this.CheckPrenom.Size = new System.Drawing.Size(15, 14);
            this.CheckPrenom.TabIndex = 20;
            this.CheckPrenom.UseVisualStyleBackColor = true;
            // 
            // CheckNiveau
            // 
            this.CheckNiveau.AutoSize = true;
            this.CheckNiveau.Location = new System.Drawing.Point(491, 217);
            this.CheckNiveau.Name = "CheckNiveau";
            this.CheckNiveau.Size = new System.Drawing.Size(15, 14);
            this.CheckNiveau.TabIndex = 21;
            this.CheckNiveau.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 500);
            this.Controls.Add(this.CheckNiveau);
            this.Controls.Add(this.CheckPrenom);
            this.Controls.Add(this.CheckFiliere);
            this.Controls.Add(this.CheckNom);
            this.Controls.Add(this.CheckCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CodeTxt);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.PrenomTxt);
            this.Controls.Add(this.NiveauCombobox);
            this.Controls.Add(this.FiliereCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gestion_nnotesBtn);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.NouveauBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NouveauBtn;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.Button Gestion_nnotesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FiliereCombobox;
        private System.Windows.Forms.ComboBox NiveauCombobox;
        private System.Windows.Forms.TextBox PrenomTxt;
        private System.Windows.Forms.TextBox NomTxt;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox CheckCode;
        private System.Windows.Forms.CheckBox CheckNom;
        private System.Windows.Forms.CheckBox CheckFiliere;
        private System.Windows.Forms.CheckBox CheckPrenom;
        private System.Windows.Forms.CheckBox CheckNiveau;
    }
}