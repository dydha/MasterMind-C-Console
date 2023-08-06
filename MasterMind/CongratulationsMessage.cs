using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace MasterMind
{
    class CongratulationsMessage
    {
        public static void Show() //Méthode qui affiche le message de félicitations
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string message = "Félicitations! Vous avez gagné!";
            int delay = 100; // Délai entre chaque frame de l'animation (en millisecondes)

            Console.Clear();

            // Animation d'entrée
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(delay);
            }

            // Animation de zoom
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', i) + message);
                Thread.Sleep(delay);
            }

            // Animation de sortie
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Clear();
                Console.Write(message.Substring(0, i));
                Thread.Sleep(delay);
            }

            Console.ResetColor();

        }
        
    }
}
