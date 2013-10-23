using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace FileShare
{
    class mainclass
    {
        public static List<File> AlleFiles = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();

        public static void InitialiseerApp()
        {
            DBconnect connectie = DBconnect.Instantie;

            //hier worden alle datatables aangemaakt en gevuld
            DataTable bestandenTabel;
            bestandenTabel = connectie.SelectMultiple("Bestand", "*");
            DataTable categorienTabel;
            categorienTabel = connectie.SelectMultiple("Categorie", "*");

            foreach (DataRow row in bestandenTabel.Rows)
            {
                AlleFiles.Add(new File(Int32.Parse(row["BestandID"].ToString()), row["Naam"].ToString(), Int32.Parse(row["BezoekerID"].ToString())));
            }
        }

        public void VerwijderBestand(int bestandID){
            connectie.Delete("BestandZichtbaarheid", "BestandID = " + bestandID);
            connectie.Delete("Vote", "BestandID = " + bestandID );
            connectie.Delete("Flag", "BestandID = " + bestandID );
            connectie.Delete("Bestand_Categorie", "BestandID = " + bestandID);
            My.Computer.FileSystem.DeleteFile(@"\\FILESHARE-SERVER\" + mainclass.geselecteerdBestand.GetLocatie(), _FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing);
            connectie.Delete("Bestand", "BestandID = " + bestandID);
        }

        public void UploadBestand(int bestandID){
           My.Computer.Network.CopyFile(mainclass.uploadBestandLocatie, @"\\FILESHARE-SERVER\" + mainclass.GetCountBestanden());
        }

        public void DownloadBestand(int bestandID){
            My.Computer.Network.CopyFile(@"\\FILESHARE-SERVER\" + mainclass.GetGeselecteerdBestandID, @"%USERPROFILE%\Downloads\" + mainclass.GetGeselecteerdBestandNaam();
        }
    }
}
