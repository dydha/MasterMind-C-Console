using MasterMind.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Input
    {
        public static string GetReadResult() //Méthode qui retourne l'entrée utilisateur génère une exception si cette entrée n'est pas au bon format.
        {
            string? inputColors = Console.ReadLine(); // Les couleurs devinées par l'utilisateur.
            if (string.IsNullOrEmpty(inputColors))
                throw new NullInputException();
            else if (!int.TryParse(inputColors, out int value))
                throw new NotNumberException();
            else if (inputColors.Length != 4)
                throw new LengthException();

            foreach (char c in inputColors)
            {
                if (int.Parse(c.ToString()) > Constants.Colors.Count)
                    throw new IndexNotExistException();
            }
            return inputColors;
        }

    }
}
