﻿namespace THE_APPLICATION
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.bilanToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filieresToolStripMenuItem,
            this.matieresToolStripMenuItem,
            this.etudiantsToolStripMenuItem,
            this.notesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // filieresToolStripMenuItem
            // 
            this.filieresToolStripMenuItem.Name = "filieresToolStripMenuItem";
            this.filieresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.filieresToolStripMenuItem.Text = "Filieres";
            // 
            // matieresToolStripMenuItem
            // 
            this.matieresToolStripMenuItem.Name = "matieresToolStripMenuItem";
            this.matieresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.matieresToolStripMenuItem.Text = "Matieres";
            // 
            // etudiantsToolStripMenuItem
            // 
            this.etudiantsToolStripMenuItem.Name = "etudiantsToolStripMenuItem";
            this.etudiantsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.etudiantsToolStripMenuItem.Text = "Etudiants";
            this.etudiantsToolStripMenuItem.Click += new System.EventHandler(this.etudiantsToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            this.affichageToolStripMenuItem.Click += new System.EventHandler(this.affichageToolStripMenuItem_Click);
            // 
            // bilanToolStripMenuItem
            // 
            this.bilanToolStripMenuItem.Name = "bilanToolStripMenuItem";
            this.bilanToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bilanToolStripMenuItem.Text = "Bilan";
            this.bilanToolStripMenuItem.Click += new System.EventHandler(this.bilanToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.backupToolStripMenuItem.Text = "Backup ";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}

