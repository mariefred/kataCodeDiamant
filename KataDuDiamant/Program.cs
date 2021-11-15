using System;

namespace KataDuDiamant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamant!");

            var diamantDeLettre = new DiamantDeLettre();
            string resultatPrintDiamant;

            resultatPrintDiamant = diamantDeLettre.PrintDiamantDeLettre('C');

            string[] lignesResultat = resultatPrintDiamant.Split("\n\r");
        }
    }
}
