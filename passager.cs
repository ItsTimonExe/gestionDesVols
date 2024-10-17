using System;
using System.Collections.Generic;

namespace gestionDesVols
{
    internal class passager
    {
        private string id;
        private string nom;
        private string prenom;
        private List<billet> billets; // Ajout de la collection de billets

        public passager(string id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.billets = new List<billet>(); // Initialisation de la collection de billets
        }

        public string getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public override string ToString()
        {
            return "Passager [id=" + id + ", nom=" + nom + ", prenom=" + prenom + "]";
        }

        public void ajouterBillet(billet b)
        {
            this.billets.Add(b); // Ajout du billet à la collection
        }

        public int rechercherBillet(billet b)
        {
            return this.billets.IndexOf(b); // Recherche du billet dans la collection
        }
    }

    internal class billet
    {
        // Définition de la classe billet
    }
}
