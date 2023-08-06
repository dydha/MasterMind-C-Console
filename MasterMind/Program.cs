using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;
using Timer = System.Timers.Timer;
using MasterMind.Exceptions;
using MasterMind;

class Program
{
    static void Main(string[] args)
    {
        //Méthode pour commencer le jeu.
        do
        {
           
            Game.Start();
            Console.WriteLine("Voulez-vous recommencer ? (o/n)");
            
            while(true)
            {
                string? input = Console.ReadLine()?.ToLower();
                if (input == "n")
                    return;
                else if (input == "o")
                {
                    Console.Clear();
                    break;
                }
                else
                    Console.WriteLine("Caractère invalide!");
            }
           

        } while(true);
    }
}
