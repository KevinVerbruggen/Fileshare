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
    public partial class BezoekersForm : Form
    {
        public BezoekersForm()
        {
            InitializeComponent();
            foreach (User user in mainclass.AlleGebruikers)
            {
                checkedListBoxGebruikers.Items.Add(user.Gebruikersnaam, false);
            }
        }

        private void checkedListBoxGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBlokkeer_Click(object sender, EventArgs e)
        {
            if (checkedListBoxGebruikers.CheckedItems.Count > 0)
            {
                foreach (int i in checkedListBoxGebruikers.CheckedIndices)
                {
                    mainclass.localUser.Blokkeer(i);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Je hebt geen gebruikers geselecteerd.");
            }
        }

        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
