using System;
using System.Collections.Generic;
using System.Linq;
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
            get { return admin; }
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
            mainclass.Categorieen.Add(new Categorie(naam, parentID));
            connectie.Insert("Categorie", naam+", "+parentNaam);
        }

        //De functie om een stem te geven aan een bestand.
        public void Vote(Boolean upvote) 
        {
            Vote(mainclass.geselecteerdBestand.GetUserID(), mainclass.geselecteerdBestand.GetBestandID(), upvote);
        }

        //De functie om een bestand te uploaden.
        public void UploadFile() 
        { 
        }

        //De functie om een categorie te verwijderen.
        public void VerwijderCategorie() 
        {
            if (this.admin == true) //Indien de gebruiker de admin is,
            {//alle bestanden die alleen in deze categorie zitten en de categorie zelf verwijderen.
                for (int i=0; i<mainclass.geselecteerdeCategorieBestanden.length; i++)
                {
                    VerwijderBestand(mainclass.geselecteerdeCategorieBestanden[i], this.bezoekerID);
                }
                connectie.Delete("categorie", "categorieID="+geselecteerdeCategorie.GetCategorieID[]);
            }
            else //Voor elke andere gebruiker,
            { //deze opdracht negeren
                return;
            }
        }

        //De functie om een bestand te verwijderen.
        public void VerwijderBestand(int bestandID) 
        {
            if (this.bezoekerID == mainclass.GetGeselecteerdBestandUploaderID && this.admin == true) //Als de gebruiker de uploader of admin is,
            { //dan het bestand verwijderen.
                mainclass.VerwijderBestand(bestandID);
            }
            else //Als dit wel niet geval is,
            { //het bestand niet verwijderen.
                return;
            }
        }
    }
}
