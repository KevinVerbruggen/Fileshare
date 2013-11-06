namespace FileShare
{
    partial class BezoekersForm
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
            this.checkedListBoxGebruikers = new System.Windows.Forms.CheckedListBox();
            this.buttonBlokkeer = new System.Windows.Forms.Button();
            this.buttonAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxGebruikers
            // 
            this.checkedListBoxGebruikers.FormattingEnabled = true;
            this.checkedListBoxGebruikers.Location = new System.Drawing.Point(13, 13);
            this.checkedListBoxGebruikers.Name = "checkedListBoxGebruikers";
            this.checkedListBoxGebruikers.Size = new System.Drawing.Size(259, 199);
            this.checkedListBoxGebruikers.TabIndex = 0;
            this.checkedListBoxGebruikers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGebruikers_SelectedIndexChanged);
            // 
            // buttonBlokkeer
            // 
            this.buttonBlokkeer.Location = new System.Drawing.Point(197, 227);
            this.buttonBlokkeer.Name = "buttonBlokkeer";
            this.buttonBlokkeer.Size = new System.Drawing.Size(75, 23);
            this.buttonBlokkeer.TabIndex = 1;
            this.buttonBlokkeer.Text = "Blokkeer";
            this.buttonBlokkeer.UseVisualStyleBackColor = true;
            this.buttonBlokkeer.Click += new System.EventHandler(this.buttonBlokkeer_Click);
            // 
            // buttonAnnuleren
            // 
            this.buttonAnnuleren.Location = new System.Drawing.Point(13, 227);
            this.buttonAnnuleren.Name = "buttonAnnuleren";
            this.buttonAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuleren.TabIndex = 2;
            this.buttonAnnuleren.Text = "Annuleren";
            this.buttonAnnuleren.UseVisualStyleBackColor = true;
            this.buttonAnnuleren.Click += new System.EventHandler(this.buttonAnnuleren_Click);
            // 
            // BezoekersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonAnnuleren);
            this.Controls.Add(this.buttonBlokkeer);
            this.Controls.Add(this.checkedListBoxGebruikers);
            this.Name = "BezoekersForm";
            this.Text = "BezoekersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxGebruikers;
        private System.Windows.Forms.Button buttonBlokkeer;
        private System.Windows.Forms.Button buttonAnnuleren;
    }
}