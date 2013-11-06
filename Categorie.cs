using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class Categorie
    {
        private int categorieID;
        private string naam;
        private int? parentID;
        private List<File> files = new List<File>();

        public int CategorieID 
        {
            set { categorieID = value; }
            get { return categorieID; }
        }

        public string Naam 
        {
            set { naam = value; }
            get { return naam; }
        }

        public int? ParentID 
        {
            set { parentID = value; }
            get { return parentID; }
        }

        public List<File> Files
        {
            set { files = value; }
            get { return files; }
        }

        public Categorie(string naam)
        {
            this.naam = naam;
            this.parentID = null;
        }

        public Categorie(string naam, int parentID)
        {
            this.naam = naam;
            this.parentID = parentID;
        }

        public Categorie(int categorieID, string naam) 
        {
            this.categorieID = categorieID;
            this.naam = naam;
        }
        public Categorie(int categorieID, string naam, int? parentID)
        {
            this.categorieID = categorieID;
            this.naam = naam;
            this.parentID = parentID;
        }
    }
}
