using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace FileShare
{
    class mainclass
    {
        public static List<File> AlleFiles = new List<File>();
        public static List<Categorie> AlleCategorieen = new List<Categorie>();
        Computer myComputer = new Computer();

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

        public void UploadBestand(string uploadBestandLocatie){
            int bestandID = mainclass.GetMaxBestandID() + 1;
            myComputer.Network.CopyFile(uploadBestandLocatie, @"\\FILESHARE-SERVER\" + bestandID);
            connectie.Insert("Bestand", NieuwBestandNaam + ", " + bestandID.ToString() + ", " + mainclass.localUser.BezoekerID.get(), "Naam, Locatie, bezoekerID");
        }

        public void DownloadBestand(int bestandID){
            myComputer.Network.CopyFile(@"\\FILESHARE-SERVER\" + mainclass.GetGeselecteerdBestandID, @"%USERPROFILE%\Downloads\" + mainclass.GetGeselecteerdBestandNaam();
        }
    }
}
