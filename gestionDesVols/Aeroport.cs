using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDesVols
{
    internal class Aeroport
    {
        private string code;
        private string nom;
        private string pays;

        public string Code
        {
            get { return code; }
            private set { code = value; }
        }

        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }

        public string Pays
        {
            get { return pays; }
            private set { pays = value; }
        }

        public Aeroport(string code, string nom, string pays)
        {
            this.Code = code;
            this.Nom = nom;
            this.Pays = pays;
        }
    }
}
