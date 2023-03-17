namespace THE_APPLICATION
{
    partial class Bilan_annuel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFiliere = new System.Windows.Forms.ComboBox();
            this.comboBoxEtudiant = new System.Windows.Forms.ComboBox();
            this.comboBoxNiveau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMoy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niveau";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(529, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxFiliere
            // 
            this.comboBoxFiliere.BackColor = System.Drawing.Color.Aquamarine;
            this.comboBoxFiliere.FormattingEnabled = true;
            this.comboBoxFiliere.Location = new System.Drawing.Point(169, 29);
            this.comboBoxFiliere.Name = "comboBoxFiliere";
            this.comboBoxFiliere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiliere.TabIndex = 4;
            // 
            // comboBoxEtudiant
            // 
            this.comboBoxEtudiant.BackColor = System.Drawing.Color.Aquamarine;
            this.comboBoxEtudiant.FormattingEnabled = true;
            this.comboBoxEtudiant.Location = new System.Drawing.Point(169, 72);
            this.comboBoxEtudiant.Name = "comboBoxEtudiant";
            this.comboBoxEtudiant.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEtudiant.TabIndex = 5;
            // 
            // comboBoxNiveau
            // 
            this.comboBoxNiveau.BackColor = System.Drawing.Color.Aquamarine;
            this.comboBoxNiveau.FormattingEnabled = true;
            this.comboBoxNiveau.Location = new System.Drawing.Point(529, 28);
            this.comboBoxNiveau.Name = "comboBoxNiveau";
            this.comboBoxNiveau.Size = new System.Drawing.Size(119, 21);
            this.comboBoxNiveau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moyenne annuelle";
            // 
            // textBoxMoy
            // 
            this.textBoxMoy.Location = new System.Drawing.Point(381, 295);
            this.textBoxMoy.Name = "textBoxMoy";
            this.textBoxMoy.Size = new System.Drawing.Size(112, 20);
            this.textBoxMoy.TabIndex = 8;
            // 
            // Bilan_annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNiveau);
            this.Controls.Add(this.comboBoxEtudiant);
            this.Controls.Add(this.comboBoxFiliere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bilan_annuel";
            this.Text = "Bilan_annuel";
            this.Load += new System.EventHandler(this.Bilan_annuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFiliere;
        private System.Windows.Forms.ComboBox comboBoxEtudiant;
        private System.Windows.Forms.ComboBox comboBoxNiveau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMoy;
    }
}