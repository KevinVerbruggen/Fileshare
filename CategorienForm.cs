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
    public partial class CategorienForm : Form
    {
        string uploadBestandLocatie;
        List<int> bestandZichtbaarheid;

        public CategorienForm(string uploadBestandLocatie)
        {
            InitializeComponent();
            this.uploadBestandLocatie = uploadBestandLocatie;
            foreach (Categorie categorie in mainclass.AlleCategorieen)
            {
                checkedListBoxCategorien.Items.Add(categorie.naam, false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCategorien.CheckedItems.Count > 0)
            {
                FormBestandZichtbaarheid zichtbaarheidsForm = new FormBestandZichtbaarheid(uploadBestandLocatie, checkedListBoxCategorien.CheckedIndices);
                this.Close();
            }
            else if (checkedListBoxCategorien.CheckedItems.Count == 0)
            {
                MessageBox.Show("Je hebt geen categoriën geselecteerd.");
            }
            else
            {
                DialogResult doorgaanYN = MessageBox.Show("Je hebt meer dan 1 categorie geselecteerd. Weet je zeker dat je wilt doorgaan?", "Weet je het zeker?", MessageBoxButtons.YesNo);
                if (doorgaanYN == DialogResult.Yes) 
                {
                    FormBestandZichtbaarheid zichtbaarheidsForm = new FormBestandZichtbaarheid(uploadBestandLocatie, checkedListBoxCategorien.CheckedIndices);
                this.Close();
                }
            }
            
        }

        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            return;
        }

        private void buttonNieuweCategorie_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCategorien.CheckedItems.Count == 1)
            {
                mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text, this.checkedListBoxCategorien.CheckedIndices);
            }
            else {
                mainclass.localUser.CreeerCategorie(this.textBoxNieuweCategorie.Text);
            }

        }

        private void textBoxNieuweCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxCategorien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
