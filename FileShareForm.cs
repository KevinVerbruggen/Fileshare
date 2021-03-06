﻿using System;
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
        OpenFileDialog op;
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
            buttonVernieuwen_Click(null, null);

            if (mainclass.localUser.Admin == true)
            {
                tcAlleBestanden.TabPages.Remove(tabPage2);
            }
            else
            {
                tcAlleBestanden.TabPages.Remove(tabPage3);
                tcAlleBestanden.TabPages.Remove(tabPage4);
                buttonGebruikerBlokkeren.Hide();
            }
        }

        public void VulLijstGeselecteerdeBestandenIDs() 
        {
            if (GeselecteerdeBestandenIDs != null)
            {
                GeselecteerdeBestandenIDs.Clear();
            }
            foreach (int i in ListBoxBestanden.SelectedIndices) 
            {
                GeselecteerdeBestandenIDs.Add(ListBoxBestanden.SelectedIndices[i]);
            }
        }

        private void buttonUploaden_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK) {
                CategorienForm ca = new CategorienForm(op.SafeFileName, op.FileName);
                ca.Show();
            }
        }

         private void buttonDownloaden_Click(object sender, EventArgs e)
        {
            VulLijstGeselecteerdeBestandenIDs();
            if (GeselecteerdeBestandenIDs != null)
            {
                mainclass.DownloadBestand(GeselecteerdeBestandenIDs);
            }
            else {
                MessageBox.Show("Je hebt geen Bestand geselecteerd");
            }
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
            mainclass.InitialiseerApp();
            listBoxCategorie.Items.Clear();
            ListBoxBestanden.Items.Clear();
            ListBoxEigenBestanden.Items.Clear();
            ListBoxFlagBestanden.Items.Clear();
            ListBoxAlleGebruikers.Items.Clear();

            //mainclass.vulTabellen();
            listBoxCategorie.Items.AddRange(mainclass.AlleCategorieen.ToArray());
            ListBoxEigenBestanden.Items.AddRange(mainclass.EigenBestanden.ToArray());  
            ListBoxAlleGebruikers.Items.AddRange(mainclass.AlleGebruikers.ToArray());
            ListBoxFlagBestanden.Items.AddRange(mainclass.GeFlagteBestanden.ToArray());
            listBoxBestandenVernieuwen();
        }

        private void listBoxBestandenVernieuwen() {
            if (listBoxCategorie.SelectedIndices.Count > 0)
            {
                ListBoxBestanden.Items.Clear();
                ListBoxBestanden.Items.AddRange(mainclass.GeselecteerdeCategorieBestanden.ToArray());
            }
            else
            {
                ListBoxBestanden.Items.AddRange(mainclass.AlleFiles.ToArray());
            }
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            mainclass.VerwijderCategorie(listBoxCategorie.SelectedIndex);
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

        private void buttonGebruikerBlokkeren_Click(object sender, EventArgs e)
        {
            if (ListBoxAlleGebruikers.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleGebruikers[ListBoxAlleGebruikers.SelectedIndex].BezoekerID;
                mainclass.localUser.Blokkeer(id);
                MessageBox.Show("Gebruiker is geblokkeerd");
            }
        }

        private void buttonGebruikerBlokkeren_Click_1(object sender, EventArgs e)
        {
            BezoekersForm bezoekersForm = new BezoekersForm();
        }

        private void listBoxCategorie_MouseClick(object sender, MouseEventArgs e)
        {
            mainclass.VulLijstGeselecteerdeCategorieBestanden(listBoxCategorie.SelectedIndex);
            listBoxBestandenVernieuwen();
        }
    }
}
