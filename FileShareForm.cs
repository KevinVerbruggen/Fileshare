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
        public FileShareForm()
        {
            InitializeComponent();
            mainclass.InitialiseerApp();

            //Dit moet bij het inloggen geset worden
            mainclass.localUser = new User(1, false);

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

        //werkend
        private void buttonUpvote_Click(object sender, EventArgs e)
        {
            if (ListBoxBestanden.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleFiles[ListBoxBestanden.SelectedIndex].BestandID;
                mainclass.localUser.Vote(true, id);
            }
        }

        //werkend
        private void buttonDownvote_Click(object sender, EventArgs e)
        {
            if (ListBoxBestanden.SelectedItems.Count > 0)
            {
                int id = mainclass.AlleFiles[ListBoxBestanden.SelectedIndex].BestandID;
                mainclass.localUser.Vote(false, id);
            }
        }

        private void buttonVerwijder_Click(object sender, EventArgs e)
        {
            //mainclass.localUser.VerwijderBestand(mainclass.GetGeselecteerdBestandID);
        }

        private void listBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxBestanden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVernieuwen_Click(object sender, EventArgs e)
        {
            this.listBoxCategorie.Items.Clear();
            this.ListBoxBestanden.Items.Clear();
            //mainclass.vulTabellen();
            this.listBoxCategorie.Items.AddRange(mainclass.AlleCategorieen.ToArray());
            this.ListBoxBestanden.Items.AddRange(mainclass.AlleFiles.ToArray());
        }

        private void buttonVerwijderen2_Click(object sender, EventArgs e)
        {
            // mainclass.localUser.VerwijderCategorie(mainclass.GetGeselecteerdeCategorieID);
        }
    }
}
