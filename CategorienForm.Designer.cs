namespace FileShare
{
    partial class CategorienForm
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
            this.listBoxCategorien = new System.Windows.Forms.ListBox();
            this.textBoxNieuweCategorie = new System.Windows.Forms.TextBox();
            this.buttonAccepteer = new System.Windows.Forms.Button();
            this.buttonCategorieToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategorien
            // 
            this.listBoxCategorien.FormattingEnabled = true;
            this.listBoxCategorien.Location = new System.Drawing.Point(13, 13);
            this.listBoxCategorien.Name = "listBoxCategorien";
            this.listBoxCategorien.Size = new System.Drawing.Size(259, 147);
            this.listBoxCategorien.TabIndex = 0;
            this.listBoxCategorien.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorien_SelectedIndexChanged);
            // 
            // textBoxNieuweCategorie
            // 
            this.textBoxNieuweCategorie.Location = new System.Drawing.Point(12, 166);
            this.textBoxNieuweCategorie.Name = "textBoxNieuweCategorie";
            this.textBoxNieuweCategorie.Size = new System.Drawing.Size(179, 20);
            this.textBoxNieuweCategorie.TabIndex = 1;
            this.textBoxNieuweCategorie.Text = "nieuwe categorie";
            this.textBoxNieuweCategorie.TextChanged += new System.EventHandler(this.textBoxNieuweCategorie_TextChanged);
            // 
            // buttonAccepteer
            // 
            this.buttonAccepteer.Location = new System.Drawing.Point(13, 188);
            this.buttonAccepteer.Name = "buttonAccepteer";
            this.buttonAccepteer.Size = new System.Drawing.Size(75, 23);
            this.buttonAccepteer.TabIndex = 2;
            this.buttonAccepteer.Text = "OK";
            this.buttonAccepteer.UseVisualStyleBackColor = true;
            this.buttonAccepteer.Click += new System.EventHandler(this.buttonAccepteer_Click);
            // 
            // buttonCategorieToevoegen
            // 
            this.buttonCategorieToevoegen.Location = new System.Drawing.Point(197, 166);
            this.buttonCategorieToevoegen.Name = "buttonCategorieToevoegen";
            this.buttonCategorieToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonCategorieToevoegen.TabIndex = 3;
            this.buttonCategorieToevoegen.Text = "Toevoegen";
            this.buttonCategorieToevoegen.UseVisualStyleBackColor = true;
            this.buttonCategorieToevoegen.Click += new System.EventHandler(this.buttonCategorieToevoegen_Click);
            // 
            // CategorienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.buttonCategorieToevoegen);
            this.Controls.Add(this.buttonAccepteer);
            this.Controls.Add(this.textBoxNieuweCategorie);
            this.Controls.Add(this.listBoxCategorien);
            this.Name = "CategorienForm";
            this.Text = "Kies Categorien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategorien;
        private System.Windows.Forms.TextBox textBoxNieuweCategorie;
        private System.Windows.Forms.Button buttonAccepteer;
        private System.Windows.Forms.Button buttonCategorieToevoegen;

    }
}