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
        bool showFlags = false;
        public string uploadBestandLocatie;

        public FileShareForm()
        {
            InitializeComponent();
            mainclass.InitialiseerApp();
            foreach (File bestand in mainclass.AlleFiles)
            {
 
            }
            foreach (Categorie categorie in mainclass.AlleCategorieen)
            {
                listBoxCategorie.Items.Add(categorie.naam);
            }
        }

        private void buttonUploaden_Click(object sender, EventArgs e)
        {
            uploadBestandLocatie = "";
            OpenFileDialog kiesBestandDialog = new OpenFileDialog();
            kiesBestandDialog.Filter = "Text Files (.txt)|*.txt|Microsoft Word-bestanden (.doc, .docx)|*.doc, *.docx|Afbeeldingen (.jpg, .png, .bmp, .tif)|*.jpg, *.jpeg, *.png, *.bmp, *.dip, *.tif, *.tiff|Alle Bestanden (*.*)|*.*";
            kiesBestandDialog.Multiselect = false;
            if (kiesBestandDialog.ShowDialog() == DialogResult.OK);
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
            mainclass.DownloadBestand(mainclass.GetGeselecteerdBestandID);
        }

        private void buttonUpvote_Click(object sender, EventArgs e)
        {
            mainclass.localUser.Vote(true);
        }

        private void buttonDownvote_Click(object sender, EventArgs e)
        {
            mainclass.localUser.Vote(false);
        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            mainclass.localUser.VerwijderBestand(mainclass.GetGeselecteerdBestandID);
        }

        private void listBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainclass.GetGeselecteerdeCategorieID = Convert.ToInt32(listBoxCategorie.SelectedItems);
        }

        private void listViewBestanden_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainclass.GetGeselecteerdBestandID = Convert.ToInt32(listViewBestanden.SelectedItems[0]);
        }

        private void buttonVernieuwen_Click(object sender, EventArgs e)
        {
            this.listBoxCategorie.Items.Clear();
            this.listViewBestanden.Items.Clear();
            mainclass.bestandenTabel.clear();
            mainclass.categorienTabel.clear();
            this.listBoxCategorie.Items.AddRange(mainclass.GetCategorieenLijst());
            this.listViewBestanden.Items.AddRange(mainclass.GetBestandenLijst());
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            foreach (int i in mainclass.GetGeselecteerdeCategorieID)
            {
                mainclass.localUser.VerwijderCategorie(i);
            }
        }

        private void buttonFlags_Click(object sender, EventArgs e)
        {
            if (showFlags == false)
            {
                showFlags = true;
            }
            else 
            {
                showFlags = false;
            }
        }
    }
}
