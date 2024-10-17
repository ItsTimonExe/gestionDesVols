using System;
using System.Collections.Generic;

namespace gestionDesVols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vol> vols = new List<Vol>();
            List<Aeroport> aeroports = new List<Aeroport>();
            List<passager> passagers = new List<passager>();

            int choix;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Ajouter un vol");
                Console.WriteLine("2. Ajouter un aéroport");
                Console.WriteLine("3. Ajouter un passager");
                Console.WriteLine("4. Afficher les vols");
                Console.WriteLine("5. Afficher les aéroports");
                Console.WriteLine("6. Afficher les passagers");
                Console.WriteLine("0. Quitter");
                Console.Write("Entrez votre choix: ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        AjouterVol(vols);
                        break;
                    case 2:
                        AjouterAeroport(aeroports);
                        break;
                    case 3:
                        AjouterPassager(passagers);
                        break;
                    case 4:
                        AfficherVols(vols);
                        break;
                    case 5:
                        AfficherAeroports(aeroports);
                        break;
                    case 6:
                        AfficherPassagers(passagers);
                        break;
                    case 0:
                        Console.WriteLine("Au revoir!");
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
            } while (choix != 0);
        }
    }
}
