using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Devices;

namespace FileShare
{
    class mainclass
    {
        string servernaam = "FILESHARE-SERVER";

        public static List<File> AlleFiles = new List<File>();
        public static List<File> EigenBestanden = new List<File>();
        public static List<File> GeFlagteBestanden = new List<File>();
        public static List<File> AlleGebruikers = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        private static DBconnect connectie = DBconnect.Instantie;
        private static Computer myComputer = new Computer();
        public static User localUser;

        public int GetGeselecteerdBestandID = FileShareForm.ListBoxBestanden.SelectedItems[0];
        public List<int> GetGeselecteerdeCategorieID;

        public static void InitialiseerApp()
        {
            //hier worden alle datatables aangemaakt en gevuld
            DataTable bestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable eigenBestandenTabel;
            eigenBestandenTabel = connectie.SelectMultiple("Bestand", "*", "BezoekerID = ");
            DataTable geFlagteBestandenTabel;
            geFlagteBestandenTabel = connectie.SelectMultiple("Bestand", "*", "BestandID IN (SELECT DISTINCT(BestandID) FROM Flags)");
            DataTable alleGebruikersTabel;
            alleGebruikersTabel = connectie.SelectMultiple("account", "*");      

            DataTable categorienTabel;
            categorienTabel = connectie.SelectMultiple("Categorie", "*");

            foreach (DataRow row in bestandenTabel.Rows)
            {
                AlleFiles.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
            foreach (DataRow row in categorienTabel.Rows)
            {
                AlleCategorieen.Add(new Categorie(Convert.ToInt32(row["CategorieID"]), Convert.ToString(row["naam"]), Convert.ToInt32(row["ParentID"])));
            }
        }

        public bool StringToBool(string str) 
        {
            if (str.Equals('Y')) 
            {
                return true;
            }
            else if (str.Equals('N'))
            {
                return false;
            }
            else {
                return false;
            }
        }

        public static File GetFileByID(int bestandID)
        {
            List<File> shortList = AlleFiles.Where(o => o.BestandID == bestandID).ToList();

            if (shortList.Count > 0)
            {
                return shortList[0];
            }
            else
            {
                return null;
            }
        }

        public int GetMaxBestandID()
        {
            return Convert.ToInt32(connectie.SingleSelect("Bestanden", "MAX(BestandID)", ""));
        }

        public int GetGeselecteerdBestandUploaderID()
        {
            return Convert.ToInt32(connectie.SingleSelect("Bestanden", "uploaderID", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public string GetGeselecteerdBestandNaam()
        {
            return Convert.ToString(connectie.SingleSelect("Bestanden", "Bestandsnaam", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public string GetGeselecteerdBestandLocatie()
        {
            return Convert.ToString(connectie.SingleSelect("Bestanden", "Locatie", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public void VerwijderBestand(int bestandID, int userID){
            List<File> shortList = AlleFiles.Where(o => o.BestandID == bestandID).ToList();
            File f = shortList[0];
            if (shortList.Count > 0 && (localUser.Admin == true || f.BezoekerID == GetGeselecteerdBestandUploaderID))
            {
                connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
                connectie.Delete("Vote", "BestandID = " + bestandID);
                connectie.Delete("Flag", "BestandID = " + bestandID);
                connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);

                myComputer.FileSystem.DeleteFile(@"\\FILESHARE-SERVER\" + f.GetLocatie, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                connectie.Delete("Bestand", "BestandID = " + bestandID);
            }
            else
            {
                // TODO: Melding, iets is fout gegaan (Bestand bestond al niet meer voor verwijderen)
            }
        }

        public void UploadBestand(string uploadBestandLocatie, List<int> categorieID, List<int> bestandZichtbaarheid)
        {
            int bestandID = GetMaxBestandID() + 1;
            string bestandsnaam = System.IO.Path.GetFileName(uploadBestandLocatie);
            myComputer.FileSystem.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            connectie.Insert("Bestand", bestandsnaam + ", " + bestandID.ToString() + ", " + localUser.BezoekerID.get(), "Naam, Locatie, bezoekerID");
            AlleFiles.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            foreach (int i in categorieID)
            {
                connectie.Insert("BestandCategorie", bestandID + ", " + i, "BestandID, CategorieID");
            }
            foreach (int i in bestandZichtbaarheid)
            {
                connectie.Insert("BestandZichtbaarheid", bestandID + ", " + i, "BestandID, bezoekerID");
            }
        }

        public void DownloadBestand(int bestandID)
        {
            myComputer.FileSystem.CopyFile(@"\\FILESHARE-SERVER\" + Convert.ToInt32(GetGeselecteerdBestandID), @"%USERPROFILE%\Downloads\" + GetGeselecteerdBestandNaam());
        }
    }
}
