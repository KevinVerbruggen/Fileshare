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
        public FileShareForm()
        {
            InitializeComponent();
            mainclass.InitialiseerApp();
        }

        private void buttonUploaden_Click(object sender, EventArgs e)
        {
            //OpenFileDialog
            mainclass.UploadBestand();
        }

        private void buttonDownloaden_Click(object sender, EventArgs e)
        {

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

        }

        private void listViewBestanden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVernieuwen_Click(object sender, EventArgs e)
        {
            this.listBoxCategorie.Items.Clear();
            this.listViewBestanden.Items.Clear();
            mainclass.bestandenTabel.clear();
            mainclass.categorienTabel.clear();
            //mainclass.vulTabellen();
            this.listBoxCategorie.Items.AddRange(mainclass.GetCategorieenLijst());
            this.listViewBestanden.Items.AddRange(mainclass.GetBestandenLijst());
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            mainclass.localUser.VerwijderCategorie(mainclass.GetGeselecteerdeCategorieID);
        }
    }
}
