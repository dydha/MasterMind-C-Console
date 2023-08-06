using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class PlayerGuess
    {
        public  static void Check(int[] devinette, int[] tab, ref int cbp, ref int bc) //Méthode qui vérifie les entrées utilisateur
        {                                                           //Et met à jour le cbp et bc
            List<int> devinetteClone = devinette.ToList();//Je clone le tableau des couleurs à deviner et je le transformer en liste

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == devinetteClone[i])
                    cbp++;
            }

            foreach (int i in tab)
            {
                if (devinetteClone.Contains(i)) // Si un index entré par l'utilisateur existe dans le clone du tableau des couleurs à deviner
                {                               //Cette couleur(index) est supprimée de devinetteClone
                    bc++;
                    devinetteClone.Remove(i);
                }
            }
        }
    }
}
