using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class File
    {
        private DBconnect connectie = DBconnect.Instantie;

        private int bestandID;
        private string naam;
        private string categorie;
        private int bezoekerID;

        public File(int bestandID, string naam, string categorie, int bezoekerID)
        {

        }
    }
}
