using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDesVols
{
    internal class Vol
    {
        private string numVol;
        private int nbrePlaces;
        private string[] places;
        private DateTime dateDepart;
        private DateTime dateArrivee;
        private List<passager> passagers;

        public string NumVol
        {
            get { return numVol; }
            set { numVol = value; }
        }

        public int NbrePlaces
        {
            get { return nbrePlaces; }
            set { nbrePlaces = value; }
        }

        public string[] Places
        {
            get { return places; }
            set { places = value; }
        }

        public DateTime DateDepart
        {
            get { return dateDepart; }
            set { dateDepart = value; }
        }

        public DateTime DateArrivee
        {
            get { return dateArrivee; }
            set { dateArrivee = value; }
        }

        public Vol(string numVol, int nbrePlaces, DateTime dateDepart, DateTime dateArrivee)
        {
            this.NumVol = numVol;
            this.NbrePlaces = nbrePlaces;
            this.Places = new string[nbrePlaces];
            this.DateDepart = dateDepart;
            this.DateArrivee = dateArrivee;
            this.passagers = new List<passager>();
        }

        public int NbPlacesLibres()
        {
            int freePlaces = 0;
            foreach (var place in Places)
            {
                if (string.IsNullOrEmpty(place))
                    freePlaces++;
            }
            return freePlaces;
        }

        public bool AttribuerPlace(int numPlace, string idPassager)
        {
            if (numPlace < NbrePlaces && Places[numPlace] == null)
            {
                Places[numPlace] = idPassager;
                return true;
            }
            return false;
        }

        public string GetOccupant(int numPlace)
        {
            if (numPlace < NbrePlaces)
            {
                return Places[numPlace];
            }
            return null;
        }

        public int ChercherPassager(string idPassager)
        {
            for (int i = 0; i < Places.Length; i++)
            {
                if (Places[i] == idPassager)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Afficher()
        {
            Console.WriteLine($"Vol {NumVol}: {NbrePlaces} places, Départ: {DateDepart}, Arrivée: {DateArrivee}");
        }
    }

}

