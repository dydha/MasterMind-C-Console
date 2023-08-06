using MasterMind.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Game
    {
        private static readonly CancellationTokenSource Cts = new(); //Déclaration de cancellationTokenSource.
        
        public static void Start()
        {
            int gameDurationInSeconds = 600; // Durée du jeu : 10 minutes
            Cts.Token.Register(OnGameTimerElapsed, Cts);

            // Minuteur pour arrêter le jeu après 10 minutes
            Cts.CancelAfter(gameDurationInSeconds * 1000);

            int[] devinette = ColorsGenerator.Generate(); //tableau contenant les couleurs à deviner.
            Console.WriteLine(string.Join(' ', devinette));
            int tour = 1; //Initialisation de tour à 1.
                          //---------------Menu-------------------------------------
            Menu.Show();
            //--------------- Fin Menu-------------------------------------
            while (tour <= Constants.MaxTour) //Tant que le nombre de tour est inférieur ou égale à 8.
            {
                while (true)
                {
                    try
                    {
                        string inputColors = Input.GetReadResult(); //Entrée utilisateur
                        
                        int cbp = 0; //nombre de couleurs bien placées.
                        int bc = 0;  //Nombre de bonnes couleurs.                                  
                        int[] tab = inputColors.ToString().Select(c => int.Parse(c.ToString())).ToArray(); // Je transforme l'entrée utilisateur en un tableau de int.
                        PlayerGuess.Check(devinette, tab, ref cbp, ref bc); //Méthode pour vérifier l'entrée utilisateur
                        Report.Show(tour, tab, cbp, bc); //Méthode qui affiche les information concernant le tour actuel.
                        if (cbp == tab.Length) // Si le nombre de couleurs bien placées est égale à la taille du tableau cela veut dire que l'utilisateur
                        {                       //a gagné la partie.
                            CongratulationsMessage.Show(); // Message de félicitations 
                             Console.WriteLine("Partie terminée!");
                            return; // On sort de l'application
                        }
                        break;
                    }

                    catch (IndexNotExistException ex)  //Exception capturée si l'index d'une couleur n'existe pas.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                    catch (LengthException ex)//Exception capturée si le nombre d'index entré par l'utilisateur est different de 4.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                    catch (NotNumberException ex) //Exception capturée si l'entrée utilisateur ne pas etre convertit  en Int.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                    catch (NullInputException ex) //Exception capturée si l'entrée est vide.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                }
                tour++; //Le tour est incrémenté à chaque itération.
                        // Si le nombre de tour est supérieur à au nombre de tour max,
                if (tour > Constants.MaxTour)  // cela veut dire l'utilisateur n'a pas gangé la partie et qu'il n'a pas plus d'essai 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Perdu !"); //Ce message est alors affiché.
                    Console.WriteLine("Partie terminée!");
                    Console.ResetColor();
                }
            }
        }

        private static void OnGameTimerElapsed(object state)
        {
            CancellationTokenSource tokenSource = (CancellationTokenSource)state;
            Console.WriteLine("Temps écoulé. Le jeu se termine automatiquement.");
            tokenSource.Dispose(); // Libère les ressources associées au jeton d'annulation
            Environment.Exit(0); // Quitte l'application avec un code de sortie 0 (succès).
        }
       
    }
}
