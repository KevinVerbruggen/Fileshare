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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbGebruikersnaam.TextLength > 0 && tbWachtwoord.TextLength > 0)
            {
                DataRow inlog = DBconnect.Instantie.SingleSelect("account", "gebruikersnaam, wachtwoord", "gebruikersnaam = '" + tbGebruikersnaam.Text + "' AND wachtwoord = '" + tbWachtwoord.Text + "'");
                if (inlog != null)
                {
                    FileShareForm f = new FileShareForm();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Onjuiste gebruikersnaam en/of wachtwoord\nProbeer het opnieuw");
                }
            }
            else
            {
                MessageBox.Show("Voer uw gebruikersnaam of wachtwoord in");
            }

            
        }
    }
}
