using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Path;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.Devices;

namespace FileShare
{
    class mainclass
    {
        string servernaam = "FILESHARE-SERVER";

        public static List<File> AlleFiles = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        static Computer myComputer = new Computer();
        static DBconnect connectie = DBconnect.Instantie;
        public static User localUser = new User(0, true);
        FileShareForm form = new FileShareForm();

        public int GetGeselecteerdBestandID;
        public List<int> GetGeselecteerdeCategorieID;

        public static void InitialiseerApp()
        {
            //hier worden alle datatables aangemaakt en gevuld
            DataTable bestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable categorienTabel;
            categorienTabel = connectie.SelectMultiple("Categorie", "*");
            DataTable bestandCategorie;
            bestandCategorie = connectie.SelectMultiple("BestandCategorie", "");
            DataTable bestandFlags;
            bestandFlags = connectie.SelectMultiple("Bestand", "DISTINCT(*)", "BestandID IN (SELECT BestandID FROM Flags)");
            foreach (DataRow row in bestandenTabel.Rows)
            {
                AlleFiles.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
            foreach (DataRow row in categorienTabel.Rows)
            {
                AlleCategorieen.Add(new Categorie(Convert.ToInt32(row["CategorieID"]), Convert.ToString(row["naam"]), Convert.ToInt32(row["ParentID"])));
            }
        }

        public int GetMaxBestandID() {
            return Convert.ToInt32(connectie.Select("Bestanden", "MAX(BestandID)", ""));
        }

        public int GetGeselecteerdBestandUploaderID() {
            return Convert.ToInt32(connectie.Select("Bestanden", "uploaderID", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public string GetGeselecteerdBestandNaam() { 
            return Convert.ToString(connectie.Select("Bestanden", "Bestandsnaam", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public string GetGeselecteerdBestandLocatie() { 
            return Convert.ToString(connectie.Select("Bestanden", "Locatie", "BestandsID = " + GetGeselecteerdBestandID));
        }

        public void VerwijderBestand(int bestandID){
            connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
            connectie.Delete("Vote", "BestandID = " + bestandID );
            connectie.Delete("Flag", "BestandID = " + bestandID );
            connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);
            myComputer.FileSystem.DeleteFile(@"\\"+ servernaam + @"\" + GetGeselecteerdBestandLocatie(), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
            connectie.Delete("Bestand", "BestandID = " + bestandID);
        }

        public void UploadBestand(string uploadBestandLocatie, List<int> categorieID){
            int bestandID = GetMaxBestandID() + 1;
            string bestandsnaam = System.IO.Path.GetFileName(uploadBestandLocatie);
            myComputer.FileSystem.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            connectie.Insert("Bestand", bestandsnaam + ", " + bestandID.ToString() + ", " + localUser.BezoekerID.get(), "Naam, Locatie, bezoekerID");
            mainclass.bestandenTabel.Rows.Add(bestandsnaam, bestandID, localUser.BezoekerID.get());
            foreach (int i in categorieID) 
            {
                connectie.Insert("BestandCategorie", bestandID + ", " + i, "BestandID, CategorieID");
            }
        }

        public void DownloadBestand(int bestandID){
            myComputer.FileSystem.CopyFile(@"\\FILESHARE-SERVER\" + Convert.ToInt32(GetGeselecteerdBestandID), @"%USERPROFILE%\Downloads\" + GetGeselecteerdBestandNaam());
        }

    }
}
