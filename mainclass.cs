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
        public static List<File> AlleFiles = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        static Computer myComputer = new Computer();
        static DBconnect connectie = DBconnect.Instantie;

        public static void InitialiseerApp()
        {
            //hier worden alle datatables aangemaakt en gevuld
            DataTable bestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable categorienTabel;
            categorienTabel = connectie.SelectMultiple("Categorie", "*");

            foreach (DataRow row in bestandenTabel.Rows)
            {
                AlleFiles.Add(new File(Convert.ToInt32(row["BestandID"]), Convert.ToString(row["Naam"]), Convert.ToInt32(row["BezoekerID"]), Convert.ToString(row["Locatie"])));
            }
        }

        public void VerwijderBestand(int bestandID){
            connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
            connectie.Delete("Vote", "BestandID = " + bestandID );
            connectie.Delete("Flag", "BestandID = " + bestandID );
            connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);
            myComputer.FileSystem.DeleteFile(@"\\FILESHARE-SERVER\" + geselecteerdBestand.GetLocatie(), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
            connectie.Delete("Bestand", "BestandID = " + bestandID);
        }

        public static void UploadBestand(string uploadBestandLocatie){
            int bestandID = GetMaxBestandID() + 1;
            myComputer.FileSystem.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            connectie.Insert("Bestand", System.IO.Path.GetFileName(uploadBestandLocatie)+ ", " + bestandID.ToString() + ", " + localUser.BezoekerID.get(), "Naam, Locatie, bezoekerID");
        }

        public void DownloadBestand(int bestandID){
            myComputer.FileSystem.CopyFile(@"\\FILESHARE-SERVER\" + GetGeselecteerdBestandID, @"%USERPROFILE%\Downloads\" + GetGeselecteerdBestandNaam();
        }
    }
}
