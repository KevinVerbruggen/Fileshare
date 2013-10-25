using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileShare
{
    public partial class FileShareForm : Form
    {
        public string uploadBestandLocatie;

        public string UserName
        {
            set 
            { 
                labelIngelogdAls.Text = "Ingelogd als: " + value;
            }
        }


        public FileShareForm()
        {
            InitializeComponent();
            mainclass.InitialiseerApp();
            if (labelIngelogdAls.Text.Contains("admin"))
            if (mainclass.localUser.Admin == true)
            {
                tcAlleBestanden.TabPages.Remove(tabPage2);
            }
            else
            {
                tcAlleBestanden.TabPages.Remove(tabPage3);
                tcAlleBestanden.TabPages.Remove(tabPage4);
            }
            //foreach (File bestand in mainclass.AlleFiles)
            //{
            //
            //}
            //foreach (Categorie categorie in mainclass.AlleCategorieen)
            //{
            //    listBoxCategorie.Items.Add(categorie.naam);
            //}

            buttonVernieuwen_Click(null, null);
        }

        private void buttonUploaden_Click(object sender, EventArgs e)
        {
            uploadBestandLocatie = "";
            OpenFileDialog kiesBestandDialog = new OpenFileDialog();
            kiesBestandDialog.Filter = "Text Files (.txt)|*.txt|Microsoft Word-bestanden (.doc, .docx)|*.doc, *.docx|Afbeeldingen (.jpg, .png, .bmp, .tif)|*.jpg, *.jpeg, *.png, *.bmp, *.dip, *.tif, *.tiff|Alle Bestanden (*.*)|*.*";
            kiesBestandDialog.Multiselect = false;
            if (kiesBestandDialog.ShowDialog() == DialogResult.OK)
            {
                uploadBestandLocatie = kiesBestandDialog.FileName;
            }
            if (uploadBestandLocatie != "")
            {
                CategorienForm kiesCategorienForm = new CategorienForm(uploadBestandLocatie);
            }
        }

         private void buttonDownloaden_Click(object sender, EventArgs e)
        {
            mainclass.DownloadBestand(ListBoxBestanden.SelectedItems[0]);
        }

        private void buttonUpvote_Click(object sender, EventArgs e)
        {
            if (ListBoxBestanden.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleFiles[ListBoxBestanden.SelectedIndex].BestandID;
                mainclass.localUser.Vote(true, id);
                MessageBox.Show("Bestand is upvoted");
            }
        }

        private void buttonDownvote_Click(object sender, EventArgs e)
        {
            if (ListBoxBestanden.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleFiles[ListBoxBestanden.SelectedIndex].BestandID;
                mainclass.localUser.Vote(false, id);
                MessageBox.Show("Bestand is downvoted");
            }
        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            mainclass.localUser.VerwijderBestand(ListBoxBestanden.SelectedItems[0]);
        }

        private void buttonVernieuwen_Click(object sender, EventArgs e)
        {
            listBoxCategorie.Items.Clear();
            ListBoxBestanden.Items.Clear();
            //mainclass.vulTabellen();
            listBoxCategorie.Items.AddRange(mainclass.AlleCategorieen.ToArray());
            ListBoxBestanden.Items.AddRange(mainclass.AlleFiles.ToArray());
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            mainclass.localUser.VerwijderCategorie(listBoxCategorie.SelectedItems[0]);
        }

        private void FileShareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonFlag_Click(object sender, EventArgs e)
        {
            if (ListBoxBestanden.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleFiles[ListBoxBestanden.SelectedIndex].BestandID;
                mainclass.localUser.Flag(id);
                MessageBox.Show("Bestand is downvoted");
            }
        }

        private void buttonNieuweCategorie_Click(object sender, EventArgs e)
        {
        //    NieuweCategorieForm nieuweCategorieForm = new NieuweCategorieForm();
        }
    }
}
