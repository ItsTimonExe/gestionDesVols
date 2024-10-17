using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDesVols
{
    internal class billet
    {
        private int numPlace;
        private double prix;

        public billet(int numPlace, double prix)
        {
            this.numPlace = numPlace;
            this.prix = prix;
        }

        public int NumPlace
        {
            get { return numPlace; }
            set { numPlace = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public override string ToString()
        {
            return "Billet [numPlace=" + numPlace + ", prix=" + prix + "]";
        }
    }
}

