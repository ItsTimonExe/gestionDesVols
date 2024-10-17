using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDesVols
{
    internal class passager
    {
        private string id;
        private string nom;
        private string prenom;
        private List<billet> billets;


        public passager(string id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.billets = new List<billet>(); 
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

        public string ToString()
        {
            return "Passager [id=" + id + ", nom=" + nom + ", prenom=" + prenom + "]";
        }
        public void ajouterBillet(billet b)
        {
            this.billets.Add(b);
        }
        public int rechercherBillet(billet b)
        {

            return this.billets.IndexOf(b);
        }

    }
}
