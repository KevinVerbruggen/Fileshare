using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class File
    {
        //Alle variabelen.
        private int bestandID;
        private string naam;
        private List<int> CategorieIDs;
        private int bezoekerID;
        private string locatie;

        //De constructor voor een nieuwe bestand.
        public File(int bestandID, string naam, List<int> CategorieIDs, int bezoekerID)
        {
            this.bestandID = bestandID;
            this.naam = naam;
            this.CategorieIDs = CategorieIDs;
            this.bezoekerID = bezoekerID;
        }

        //De constructor voor een al bestaand bestand.
        public File(int bestandID, string naam, List<int> CategorieIDs, int bezoekerID, string locatie)
        {
            this.bestandID = bestandID;
            this.naam = naam;
            this.CategorieIDs = CategorieIDs;
            this.bezoekerID = bezoekerID;
            this.locatie = locatie;
        }
    }
}
