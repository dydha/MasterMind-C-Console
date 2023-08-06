using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Menu
    {
        public static  void Show() //Méthode qui affiche le menu.
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Voici les couleurs disponibles\n");
            foreach (KeyValuePair<int, string> kvp in Constants.Colors)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
            Console.WriteLine($"\nChoisir quatre couleurs, entrer les index de couleurs. ex: 1564. Vous avez {Constants.MaxTour} essais.");
            Console.ResetColor();
        }
    }
}
