using System;
using System.Collections.Generic;
using System.Text;

namespace KataDuDiamant
{
    public class DiamantDeLettre
    {

        public string PrintDiamantDeLettre(char lettre)
        {
            char lettreMajuscule = Char.ToUpper(lettre);
            if (!(lettreMajuscule >= 'A' && lettreMajuscule <= 'Z'))
            {
                throw new ArgumentOutOfRangeException("Le parametre n'est pas une lettre");
            }


            int positionLettre = (int)lettre - 64;
            string retour = "";

            if (positionLettre == 1)
            {
                return "A";
            }
                
            for (int i = 1; i <= positionLettre*2-1 ; i++)
            {
                retour += " \n\r";
            }


            return retour;
        }

    }
}
