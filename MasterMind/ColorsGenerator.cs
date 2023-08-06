using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class ColorsGenerator
    {
        private static readonly Random _rand = new();
        public static int[] Generate() //Méthode qui génère aléatoirement les couleurs à deviner.
        {
            int[] colorsList = new int[Constants.RowColorsNumber];
            for (int i = 0; i < colorsList.Length; i++)
            {
                int randNum = _rand.Next(1, Constants.Colors.Count + 1);
                colorsList[i] = randNum;
            }
            return colorsList;
        }
    }
}
