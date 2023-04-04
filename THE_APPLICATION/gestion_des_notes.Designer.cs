using DataAccess;
using MODELES;
using System.Collections.Generic;

namespace THE_APPLICATION
{
    partial class gestion_des_notes
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
            this.code = new System.Windows.Forms.Label();
            this.matiere = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codbox = new System.Windows.Forms.TextBox();
            this.notebox = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.bkp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(42, 34);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(88, 16);
            this.code.TabIndex = 0;
            this.code.Text = "Code Eleve";
            this.code.Click += new System.EventHandler(this.label1_Click);
            // 
            // matiere
            // 
            this.matiere.AutoSize = true;
            this.matiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matiere.Location = new System.Drawing.Point(42, 108);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(59, 16);
            this.matiere.TabIndex = 1;
            this.matiere.Text = "Mateire";
            this.matiere.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(42, 188);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(40, 16);
            this.note.TabIndex = 2;
            this.note.Text = "Note";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(165, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // codbox
            // 
            this.codbox.Location = new System.Drawing.Point(165, 34);
            this.codbox.Name = "codbox";
            this.codbox.Size = new System.Drawing.Size(126, 20);
            this.codbox.TabIndex = 4;
            // 
            // notebox
            // 
            this.notebox.Location = new System.Drawing.Point(165, 188);
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(126, 20);
            this.notebox.TabIndex = 5;
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(414, 99);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(136, 29);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(414, 30);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(136, 29);
            this.Nouveau.TabIndex = 7;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(414, 179);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(136, 29);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(619, 30);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(136, 29);
            this.Supprimer.TabIndex = 9;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Location = new System.Drawing.Point(619, 103);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(136, 29);
            this.Rechercher.TabIndex = 10;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // bkp
            // 
            this.bkp.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkp.Location = new System.Drawing.Point(619, 179);
            this.bkp.Name = "bkp";
            this.bkp.Size = new System.Drawing.Size(136, 29);
            this.bkp.TabIndex = 11;
            this.bkp.Text = "backup";
            this.bkp.UseVisualStyleBackColor = true;
            this.bkp.Click += new System.EventHandler(this.bkp_Click);
            // 
            // gestion_des_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.bkp);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.codbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.code);
            this.Name = "gestion_des_notes";
            this.Text = "gestion_des_notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label matiere;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox codbox;
        private System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button bkp;
    }
}