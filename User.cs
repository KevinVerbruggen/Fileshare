using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class User //Een gebruiker/bezoeker
    {
        DBconnect connectie = DBconnect.Instantie;
        //Benodigde variabelen.
        private int bezoekerID;
        private Boolean admin;


        //Properties vaststellen
        public int BezoekerID
        {
            set { bezoekerID = value; }
            get { return bezoekerID; }
        }

        public Boolean Admin
        {
            set { admin = value; }
            get { return admin;}
        }


        //De constructor. Met deze functie worden de variabelen met de waardes van een huurder uit de database gevuld. 
        public User(int bezoekerID, Boolean admin)
        {
            this.bezoekerID = bezoekerID;
            this.admin = admin;
        }



        //De functie om een gebruiker een nieuwe categorie te laten aanmaken.
        public void CreeerCategorie(string naam, int parentID) 
        {
            mainclass.AlleCategorieen.Add(new Categorie(naam, parentID));
            connectie.Insert("Categorie", naam + ", " + parentNaam);
        }

        //De functie om een stem te geven aan een bestand.
        public void Vote(Boolean upvote, int bestandID) 
        {
            string sUpvote = "Y";
            if(!upvote) 
            {
                sUpvote = "N";
            }

            connectie.Delete("vote", "BezoekerID = '" + mainclass.GetFileByID(bestandID).GetUserID + "' AND BestandID = '" + bestandID + "'");
            connectie.Insert("vote", String.Format("{0}, {1}, '{2}'", bestandID, mainclass.GetFileByID(bestandID).GetUserID, sUpvote), "BestandID, BezoekerID, Upvote");
        }

        //De functie om een categorie te verwijderen.
        public void VerwijderCategorie(int id) 
        {
            if (this.admin == true) //Indien de gebruiker de admin is,
            {
                //alle bestanden die alleen in deze categorie zitten en de categorie zelf verwijderen.
                foreach (Categorie item in mainclass.AlleCategorieen)
	            {
		            if(item.CategorieID == id) 
                    {
                        foreach (File bestand in Files)
                        {
                            mainclass.VerwijderBestand(bestand.BestandID, bezoekerID);
                        }
                    }
	            }

            }
            else //Voor elke andere gebruiker,
            { //deze opdracht negeren
                return;
            }
        }
    }
}
