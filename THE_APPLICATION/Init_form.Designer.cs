namespace THE_APPLICATION
{
    partial class Init_form
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
            this.folder_path_text = new System.Windows.Forms.TextBox();
            this.env_path_text = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.status_text = new System.Windows.Forms.TextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.folder_label = new System.Windows.Forms.Label();
            this.env_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folder_path_text
            // 
            this.folder_path_text.Location = new System.Drawing.Point(52, 69);
            this.folder_path_text.Name = "folder_path_text";
            this.folder_path_text.ReadOnly = true;
            this.folder_path_text.Size = new System.Drawing.Size(248, 20);
            this.folder_path_text.TabIndex = 0;
            // 
            // env_path_text
            // 
            this.env_path_text.Location = new System.Drawing.Point(52, 120);
            this.env_path_text.Name = "env_path_text";
            this.env_path_text.ReadOnly = true;
            this.env_path_text.Size = new System.Drawing.Size(248, 20);
            this.env_path_text.TabIndex = 1;
            this.env_path_text.TextChanged += new System.EventHandler(this.env_path_text_TextChanged);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(306, 69);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(71, 20);
            this.browse_button.TabIndex = 2;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // status_text
            // 
            this.status_text.Location = new System.Drawing.Point(52, 146);
            this.status_text.Name = "status_text";
            this.status_text.ReadOnly = true;
            this.status_text.Size = new System.Drawing.Size(248, 20);
            this.status_text.TabIndex = 3;
            // 
            // go_button
            // 
            this.go_button.Enabled = false;
            this.go_button.Location = new System.Drawing.Point(306, 146);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(71, 20);
            this.go_button.TabIndex = 5;
            this.go_button.Text = "Go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // folder_label
            // 
            this.folder_label.AutoSize = true;
            this.folder_label.Location = new System.Drawing.Point(49, 53);
            this.folder_label.Name = "folder_label";
            this.folder_label.Size = new System.Drawing.Size(60, 13);
            this.folder_label.TabIndex = 6;
            this.folder_label.Text = "Folder path";
            // 
            // env_label
            // 
            this.env_label.AutoSize = true;
            this.env_label.Location = new System.Drawing.Point(49, 104);
            this.env_label.Name = "env_label";
            this.env_label.Size = new System.Drawing.Size(52, 13);
            this.env_label.TabIndex = 7;
            this.env_label.Text = ".env path";
            // 
            // Init_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 231);
            this.Controls.Add(this.env_label);
            this.Controls.Add(this.folder_label);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.env_path_text);
            this.Controls.Add(this.folder_path_text);
            this.Name = "Init_form";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Init_form_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folder_path_text;
        private System.Windows.Forms.TextBox env_path_text;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox status_text;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Label folder_label;
        private System.Windows.Forms.Label env_label;
    }
}