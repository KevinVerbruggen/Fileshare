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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "hoi",
            "hoi2",
            "hoi3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("kjhkjh");
            this.ListBoxBestanden = new System.Windows.Forms.ListBox();
            this.buttonDownloaden = new System.Windows.Forms.Button();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.buttonUpvote = new System.Windows.Forms.Button();
            this.buttonDownvote = new System.Windows.Forms.Button();
            this.buttonUploaden = new System.Windows.Forms.Button();
            this.listBoxCategorie = new System.Windows.Forms.ListBox();
            this.buttonVernieuwen = new System.Windows.Forms.Button();
            this.buttonVerwijderen2 = new System.Windows.Forms.Button();
            this.labelIngelogdAls = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxBestanden
            // 
            this.ListBoxBestanden.Location = new System.Drawing.Point(324, 137);
            this.ListBoxBestanden.Name = "ListBoxBestanden";
            this.ListBoxBestanden.Size = new System.Drawing.Size(205, 238);
            this.ListBoxBestanden.TabIndex = 0;
            this.ListBoxBestanden.SelectedIndexChanged += new System.EventHandler(this.ListBoxBestanden_SelectedIndexChanged);
            // 
            // buttonDownloaden
            // 
            this.buttonDownloaden.Location = new System.Drawing.Point(591, 66);
            this.buttonDownloaden.Name = "buttonDownloaden";
            this.buttonDownloaden.Size = new System.Drawing.Size(185, 31);
            this.buttonDownloaden.TabIndex = 1;
            this.buttonDownloaden.Text = "Downloaden";
            this.buttonDownloaden.UseVisualStyleBackColor = true;
            this.buttonDownloaden.Click += new System.EventHandler(this.buttonDownloaden_Click);
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Location = new System.Drawing.Point(591, 199);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijder.TabIndex = 2;
            this.buttonVerwijder.Text = "Bestand Verwijderen";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
            // 
            // buttonUpvote
            // 
            this.buttonUpvote.Location = new System.Drawing.Point(591, 111);
            this.buttonUpvote.Name = "buttonUpvote";
            this.buttonUpvote.Size = new System.Drawing.Size(185, 31);
            this.buttonUpvote.TabIndex = 4;
            this.buttonUpvote.Text = "Upvote";
            this.buttonUpvote.UseVisualStyleBackColor = true;
            this.buttonUpvote.Click += new System.EventHandler(this.buttonUpvote_Click);
            // 
            // buttonDownvote
            // 
            this.buttonDownvote.Location = new System.Drawing.Point(591, 148);
            this.buttonDownvote.Name = "buttonDownvote";
            this.buttonDownvote.Size = new System.Drawing.Size(185, 31);
            this.buttonDownvote.TabIndex = 5;
            this.buttonDownvote.Text = "Downvote";
            this.buttonDownvote.UseVisualStyleBackColor = true;
            this.buttonDownvote.Click += new System.EventHandler(this.buttonDownvote_Click);
            // 
            // buttonUploaden
            // 
            this.buttonUploaden.Location = new System.Drawing.Point(591, 29);
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
            this.listBoxCategorie.Location = new System.Drawing.Point(591, 332);
            this.listBoxCategorie.Name = "listBoxCategorie";
            this.listBoxCategorie.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCategorie.Size = new System.Drawing.Size(185, 147);
            this.listBoxCategorie.TabIndex = 7;
            this.listBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorie_SelectedIndexChanged);
            // 
            // buttonVernieuwen
            // 
            this.buttonVernieuwen.Location = new System.Drawing.Point(591, 284);
            this.buttonVernieuwen.Name = "buttonVernieuwen";
            this.buttonVernieuwen.Size = new System.Drawing.Size(185, 31);
            this.buttonVernieuwen.TabIndex = 8;
            this.buttonVernieuwen.Text = "Lijst Vernieuwen";
            this.buttonVernieuwen.UseVisualStyleBackColor = true;
            this.buttonVernieuwen.Click += new System.EventHandler(this.buttonVernieuwen_Click);
            // 
            // buttonVerwijderen2
            // 
            this.buttonVerwijderen2.Location = new System.Drawing.Point(591, 236);
            this.buttonVerwijderen2.Name = "buttonVerwijderen2";
            this.buttonVerwijderen2.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijderen2.TabIndex = 9;
            this.buttonVerwijderen2.Text = "Categorie Verwijderen";
            this.buttonVerwijderen2.UseVisualStyleBackColor = true;
            this.buttonVerwijderen2.Click += new System.EventHandler(this.buttonVerwijderen2_Click);
            // 
            // labelIngelogdAls
            // 
            this.labelIngelogdAls.AutoSize = true;
            this.labelIngelogdAls.Location = new System.Drawing.Point(591, 10);
            this.labelIngelogdAls.Name = "labelIngelogdAls";
            this.labelIngelogdAls.Size = new System.Drawing.Size(70, 13);
            this.labelIngelogdAls.TabIndex = 10;
            this.labelIngelogdAls.Text = "Ingelogd als: ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 437);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 109;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 469);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListBoxBestanden);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelIngelogdAls);
            this.Controls.Add(this.buttonVerwijderen2);
            this.Controls.Add(this.buttonVernieuwen);
            this.Controls.Add(this.listBoxCategorie);
            this.Controls.Add(this.buttonUploaden);
            this.Controls.Add(this.buttonDownvote);
            this.Controls.Add(this.buttonUpvote);
            this.Controls.Add(this.buttonVerwijder);
            this.Controls.Add(this.buttonDownloaden);
            this.Name = "FileShareForm";
            this.Text = "FileShare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileShareForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxBestanden;
        private System.Windows.Forms.Button buttonDownloaden;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpvote;
        private System.Windows.Forms.Button buttonDownvote;
        private System.Windows.Forms.Button buttonUploaden;
        private System.Windows.Forms.ListBox listBoxCategorie;
        private System.Windows.Forms.Button buttonVernieuwen;
        private System.Windows.Forms.Button buttonVerwijderen2;
        private System.Windows.Forms.Label labelIngelogdAls;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

