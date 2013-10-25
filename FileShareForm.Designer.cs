namespace FileShare
{
    partial class FileShareForm
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
            this.listViewBestanden = new System.Windows.Forms.ListView();
            this.buttonDownloaden = new System.Windows.Forms.Button();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.buttonUpvote = new System.Windows.Forms.Button();
            this.buttonDownvote = new System.Windows.Forms.Button();
            this.buttonUploaden = new System.Windows.Forms.Button();
            this.listBoxCategorie = new System.Windows.Forms.ListBox();
            this.buttonVernieuwen = new System.Windows.Forms.Button();
            this.buttonVerwijderen2 = new System.Windows.Forms.Button();
            if (mainclass.localUser.Admin == true)
            {
                this.buttonFlags = new System.Windows.Forms.Button();
            }
            this.SuspendLayout();
            // 
            // listViewBestanden
            // 
            this.listViewBestanden.Location = new System.Drawing.Point(13, 13);
            this.listViewBestanden.Name = "listViewBestanden";
            this.listViewBestanden.Size = new System.Drawing.Size(555, 448);
            this.listViewBestanden.TabIndex = 0;
            this.listViewBestanden.UseCompatibleStateImageBehavior = false;
            this.listViewBestanden.SelectedIndexChanged += new System.EventHandler(this.listViewBestanden_SelectedIndexChanged);
            // 
            // buttonDownloaden
            // 
            this.buttonDownloaden.Location = new System.Drawing.Point(591, 49);
            this.buttonDownloaden.Name = "buttonDownloaden";
            this.buttonDownloaden.Size = new System.Drawing.Size(185, 31);
            this.buttonDownloaden.TabIndex = 1;
            this.buttonDownloaden.Text = "Downloaden";
            this.buttonDownloaden.UseVisualStyleBackColor = true;
            this.buttonDownloaden.Click += new System.EventHandler(this.buttonDownloaden_Click);
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Location = new System.Drawing.Point(591, 189);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijder.TabIndex = 2;
            this.buttonVerwijder.Text = "Bestand Verwijderen";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
            // 
            // buttonUpvote
            // 
            this.buttonUpvote.Location = new System.Drawing.Point(591, 99);
            this.buttonUpvote.Name = "buttonUpvote";
            this.buttonUpvote.Size = new System.Drawing.Size(185, 31);
            this.buttonUpvote.TabIndex = 4;
            this.buttonUpvote.Text = "Rate up";
            this.buttonUpvote.UseVisualStyleBackColor = true;
            this.buttonUpvote.Click += new System.EventHandler(this.buttonUpvote_Click);
            // 
            // buttonDownvote
            // 
            this.buttonDownvote.Location = new System.Drawing.Point(591, 136);
            this.buttonDownvote.Name = "buttonDownvote";
            this.buttonDownvote.Size = new System.Drawing.Size(185, 31);
            this.buttonDownvote.TabIndex = 5;
            this.buttonDownvote.Text = "Rate down";
            this.buttonDownvote.UseVisualStyleBackColor = true;
            this.buttonDownvote.Click += new System.EventHandler(this.buttonDownvote_Click);
            // 
            // buttonUploaden
            // 
            this.buttonUploaden.Location = new System.Drawing.Point(591, 12);
            this.buttonUploaden.Name = "buttonUploaden";
            this.buttonUploaden.Size = new System.Drawing.Size(185, 31);
            this.buttonUploaden.TabIndex = 6;
            this.buttonUploaden.Text = "Uploaden";
            this.buttonUploaden.UseVisualStyleBackColor = true;
            this.buttonUploaden.Click += new System.EventHandler(this.buttonUploaden_Click);
            // 
            // listBoxCategorie
            // 
            this.listBoxCategorie.FormattingEnabled = true;
            this.listBoxCategorie.Location = new System.Drawing.Point(591, 314);
            this.listBoxCategorie.Name = "listBoxCategorie";
            this.listBoxCategorie.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCategorie.Size = new System.Drawing.Size(185, 147);
            this.listBoxCategorie.TabIndex = 7;
            this.listBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorie_SelectedIndexChanged);
            // 
            // buttonVernieuwen
            // 
            this.buttonVernieuwen.Location = new System.Drawing.Point(591, 277);
            this.buttonVernieuwen.Name = "buttonVernieuwen";
            this.buttonVernieuwen.Size = new System.Drawing.Size(185, 31);
            this.buttonVernieuwen.TabIndex = 8;
            this.buttonVernieuwen.Text = "Lijst Vernieuwen";
            this.buttonVernieuwen.UseVisualStyleBackColor = true;
            this.buttonVernieuwen.Click += new System.EventHandler(this.buttonVernieuwen_Click);
            // 
            // buttonVerwijderen2
            // 
            this.buttonVerwijderen2.Location = new System.Drawing.Point(591, 226);
            this.buttonVerwijderen2.Name = "buttonVerwijderen2";
            this.buttonVerwijderen2.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijderen2.TabIndex = 9;
            this.buttonVerwijderen2.Text = "Categorie Verwijderen";
            this.buttonVerwijderen2.UseVisualStyleBackColor = true;
            this.buttonVerwijderen2.Click += new System.EventHandler(this.buttonVerwijderen2_Click);
            // 
            // buttonFlags
            // 
            this.buttonFlags.Location = new System.Drawing.Point(514, 437);
            this.buttonFlags.Name = "buttonFlags";
            this.buttonFlags.Size = new System.Drawing.Size(54, 24);
            this.buttonFlags.TabIndex = 10;
            this.buttonFlags.Text = "flags";
            this.buttonFlags.UseVisualStyleBackColor = true;
            this.buttonFlags.Click += new System.EventHandler(this.buttonFlags_Click);
            // 
            // FileShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 473);
            this.Controls.Add(this.buttonFlags);
            this.Controls.Add(this.buttonVerwijderen2);
            this.Controls.Add(this.buttonVernieuwen);
            this.Controls.Add(this.listBoxCategorie);
            this.Controls.Add(this.buttonUploaden);
            this.Controls.Add(this.buttonDownvote);
            this.Controls.Add(this.buttonUpvote);
            this.Controls.Add(this.buttonVerwijder);
            this.Controls.Add(this.buttonDownloaden);
            this.Controls.Add(this.listViewBestanden);
            this.Name = "FileShareForm";
            this.Text = "FileShare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBestanden;
        private System.Windows.Forms.Button buttonDownloaden;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpvote;
        private System.Windows.Forms.Button buttonDownvote;
        private System.Windows.Forms.Button buttonUploaden;
        private System.Windows.Forms.ListBox listBoxCategorie;
        private System.Windows.Forms.Button buttonVernieuwen;
        private System.Windows.Forms.Button buttonVerwijderen2;
        private System.Windows.Forms.Button buttonFlags;
    }
}

