using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class Categorie
    {
        public string naam;
        public int parentID;
        private List<File> Files = new List<File>();

        public void Categorie(string naam, int parentID)
        { 
            this.naam = naam;
            this.parentID = parentID;
        }
    }
}
