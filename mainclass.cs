using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace FileShare
{
    class mainclass
    {
        public static List<File> AlleFiles = new List<File>();
        public static List<File> EigenBestanden = new List<File>();
        public static List<File> GeFlagteBestanden = new List<File>();
        public static List<File> AlleGebruikers = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        private static DBconnect connectie = DBconnect.Instantie;
        public static User localUser;

        public static void InitialiseerApp()
        {
            //hier worden alle datatables aangemaakt en gevuld
            DataTable bestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable eigenBestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "BezoekerID = ");
            DataTable geFlagteBestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable alleGebruikersTabel;
            bestandenTabel = connectie.SelectMultiple("account", "*");      

            DataTable categorienTabel;
            categorienTabel = connectie.SelectMultiple("Categorie", "*");

            foreach (DataRow row in bestandenTabel.Rows)
            {
                // TODO: Voeg categorieën toe aan een file ipv de new list.
                AlleFiles.Add(new File(Int32.Parse(row["BestandID"].ToString()), row["Naam"].ToString(), new List<int>(), Int32.Parse(row["BezoekerID"].ToString())));
            }
            foreach (DataRow row in alleGebruikersTabel.Rows)
            {
                // TODO: Voeg categorieën toe aan een file ipv de new list.
                AlleFiles.Add(new File(Int32.Parse(row["BezoekerID"].ToString()), row["Gebruikersnaam"].ToString(),, I(row["BezoekerID"].ToString())));
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

        //public void VerwijderBestand(int bestandID){
        //    List<File> shortList = AlleFiles.Where(o => o.BestandID == bestandID).ToList();

        //    if (shortList.Count > 0)
        //    {
        //        connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
        //        connectie.Delete("Vote", "BestandID = " + bestandID);
        //        connectie.Delete("Flag", "BestandID = " + bestandID);
        //        connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);

        //        File f = shortList[0];
        //        My.Computer.FileSystem.DeleteFile(@"\\FILESHARE-SERVER\" + f.GetLocatie, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
        //        connectie.Delete("Bestand", "BestandID = " + bestandID);
        //    }
        //    else
        //    {
        //        // TODO: Melding, iets is fout gegaan (Bestand bestond al niet meer voor verwijderen)
        //    }
        //}

        //public void UploadBestand(int bestandID){
        //   My.Computer.Network.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + GetCountBestanden());
        //}

        //public void DownloadBestand(int bestandID){
        //    My.Computer.Network.CopyFile(@"\\FILESHARE-SERVER\" + GetGeselecteerdBestandID, @"%USERPROFILE%\Downloads\" + GetGeselecteerdBestandNaam());
        //}
    }
}
