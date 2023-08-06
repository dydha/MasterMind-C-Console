using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Report
    {
        public static void Show(int tour, int[] tab, int cbp, int bc) //Méthode qui affiche les informations spécifiques à un tour.
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string report = $"\tTour  {tour}, Choix : {tab[0]}-{Constants.Colors[tab[0]]} {tab[1]}-{Constants.Colors[tab[1]]} {tab[2]}-{Constants.Colors[tab[2]]} {tab[3]}-{Constants.Colors[tab[3]]}\n\t{bc} bonne(s) couleur(s) dont {cbp}  bien placée(s). ";
            Console.WriteLine(new String('*', 60));
            Console.WriteLine(report);
            Console.WriteLine($"\n\t Il vous reste {Constants.MaxTour - tour} essai(s)");
            Console.WriteLine(new String('*', 60));
            Console.ResetColor();
        }
    }
}
