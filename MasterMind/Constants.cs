using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Constants
    {
        public static  int MaxTour = 8; //Nombre maximum de tour.
        public static int RowColorsNumber = 4;// Le nombre de couleur à deviner 
        public static Dictionary<int, string> Colors = new() //Dictionnaire de couleurs.
        {
            {1,"Blanc"}, {2,"Orange"}, {3,"Rose"}, {4,"Violet"}, {5,"Jaune"}, {6,"Vert"}, {7,"Rouge"}, {8,"Bleu"}
        };
    }
}
