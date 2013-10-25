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

            buttonVernieuwen_Click(null, null);
        }

        private void buttonUploaden_Click(object sender, EventArgs e)
        {
            //OpenFileDialog
            //mainclass.UploadBestand();
        }

        private void buttonDownloaden_Click(object sender, EventArgs e)
        {
            
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
            //mainclass.localUser.VerwijderBestand(mainclass.GetGeselecteerdBestandID);
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
            // mainclass.localUser.VerwijderCategorie(mainclass.GetGeselecteerdeCategorieID);
        }

        private void FileShareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
