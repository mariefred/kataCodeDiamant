using System;

namespace KataDuDiamant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var diamantDeLettre = new DiamantDeLettre();
            string resultatPrintDiamant;

            resultatPrintDiamant = diamantDeLettre.PrintDiamantDeLettre('C');

            string[] lignesResultat = resultatPrintDiamant.Split("\n\r");
        }
    }
}
