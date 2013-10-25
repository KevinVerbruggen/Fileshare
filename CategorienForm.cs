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
    public partial class CategorienForm : Form
    {
        string uploadBestandLocatie;
        public CategorienForm(string uploadBestandLocatie)
        {
            InitializeComponent();
            this.uploadBestandLocatie = uploadBestandLocatie;
        }

        private void listBoxCategorien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNieuweCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAccepteer_Click(object sender, EventArgs e)
        {
            
            mainclass.UploadBestand(this.uploadBestandLocatie, listBoxCategorien.SelectedItems);
        }

        private void buttonCategorieToevoegen_Click(object sender, EventArgs e)
        {
            if (textBoxNieuweCategorie.Text != "nieuwe categorie" && textBoxNieuweCategorie.Text != "") 
            {
                mainclass.CategorieToevoegen(textBoxNieuweCategorie.Text);
            }
        }
    }
}
