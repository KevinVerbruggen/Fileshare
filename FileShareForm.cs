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
        public List<int> GeselecteerdeBestandenIDs;
        public List<int> GeselecteerdeCategorieIDs;
        
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

            foreach (File bestand in mainclass.AlleFiles)
            {
                ListBoxBestanden.Items.Add(bestand.Naam);
            }
            foreach (Categorie categorie in mainclass.AlleCategorieen)
            {
                listBoxCategorie.Items.Add(categorie.Naam);
            }
            foreach (File bestand in mainclass.EigenBestanden)
            {
                ListBoxEigenBestanden.Items.Add(bestand.Naam);
            }
            foreach (File bestand in mainclass.GeFlagteBestanden)
            {
                ListBoxFlagBestanden.Items.Add(bestand.Naam);
            }

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

            buttonVernieuwen_Click(null, null);
        }

        public void VulLijstGeselecteerdeBestandenIDs() 
        {
            GeselecteerdeBestandenIDs.Clear();
            foreach (int i in ListBoxBestanden.SelectedItems) 
            {
                GeselecteerdeBestandenIDs.Add(ListBoxBestanden.SelectedIndices[i]);
            }
        }

        public void VulLijstGeselecteerdeCategorieIDs() 
        {
            GeselecteerdeCategorieIDs.Clear();
            foreach (int i in listBoxCategorie.SelectedIndices) 
            {
                GeselecteerdeCategorieIDs.Add(listBoxCategorie.SelectedIndices[i]);
            }
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
            if (uploadBestandLocatie == "")
            {
                return;
            }else
            {
                CategorienForm kiesCategorienForm = new CategorienForm(uploadBestandLocatie);
            }
        }

         private void buttonDownloaden_Click(object sender, EventArgs e)
        {
            mainclass.DownloadBestand(GeselecteerdeBestandenIDs);
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
            VulLijstGeselecteerdeBestandenIDs();
            foreach (int i in GeselecteerdeBestandenIDs)
            {
                mainclass.VerwijderBestand(GeselecteerdeBestandenIDs[i], mainclass.localUser.BezoekerID);
            }
        }

        private void buttonVernieuwen_Click(object sender, EventArgs e)
        {
            listBoxCategorie.Items.Clear();
            ListBoxBestanden.Items.Clear();
            mainclass.InitialiseerApp();
            listBoxCategorie.Items.AddRange(mainclass.AlleCategorieen.ToArray());
            ListBoxBestanden.Items.AddRange(mainclass.AlleFiles.ToArray());
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            VulLijstGeselecteerdeCategorieIDs();
            mainclass.VerwijderCategorie(GeselecteerdeCategorieIDs);
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
                mainclass.localUser.Rapporteren(GeselecteerdeBestandenIDs);
                MessageBox.Show("Bestand is downvoted");
            }
        }

        private void buttonNieuweCategorie_Click(object sender, EventArgs e)
        {
        //    NieuweCategorieForm nieuweCategorieForm = new NieuweCategorieForm();
        }

        private void listBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
