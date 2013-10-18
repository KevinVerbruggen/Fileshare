using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class mainclass
    {
        public static List<File> AlleFiles = new List<File>();
        public static List<Category> AlleCategorieen = new List<Category>();

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
                AlleFiles.Add(new File(Int32.Parse(row["BestandID"].ToString()), row["Naam"].ToString(), row["Categorie"].ToString(), Int32.Parse(row["BezoekerID"].ToString())));
            }
        }
    }
}
