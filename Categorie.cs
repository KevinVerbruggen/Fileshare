using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class Categorie
    {
        public int categorieID;
        public string naam;
        public int? parentID;
        private List<File> files = new List<File>();

        public List<File> Files{
            set { files = value; }
            get { return files; }
        }
        public Categorie(string naam)
        {
            this.naam = naam;
            this.parentID = null;
        }

        public Categorie(string naam, int? parentID)
        {
            this.naam = naam;
            this.parentID = parentID;
        }

        public Categorie(int categorieID, string naam, int? parentID)
        {
            this.categorieID = categorieID;
            this.naam = naam;
            this.parentID = parentID;
        }
    }
}
