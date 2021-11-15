using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataDuDiamant;
using System;

namespace TestKataDuDiamant
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Print_diamant_retourne_A_si_A_en_entre()
        {
            var diamantDeLettre = new DiamantDeLettre();
            string resultatPrintDiamant;

            resultatPrintDiamant = diamantDeLettre.PrintDiamantDeLettre('A');

            Assert.AreEqual("A", resultatPrintDiamant);

        }

        [TestMethod]
        public void Print_diamant_exception_si_char_pas_une_lettre()
        {
            var diamantDeLettre = new DiamantDeLettre();
            string resultatPrintDiamant;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => diamantDeLettre.PrintDiamantDeLettre('1'));

        }

        [TestMethod]
        public void Print_diamant_exception_si_parametre_est_un_symbole()
        {
            var diamantDeLettre = new DiamantDeLettre();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => diamantDeLettre.PrintDiamantDeLettre('~'));

        }

        [TestMethod]
        public void Print_diamant_retourne_2x_1_nb_ligne_vs_position_alphabetique()
        {
            var diamantDeLettre = new DiamantDeLettre();
            string resultatPrintDiamant;

            resultatPrintDiamant = diamantDeLettre.PrintDiamantDeLettre('C');

            string[] lignesResultat = resultatPrintDiamant.Split("\n\r");

            Assert.AreEqual(8, lignesResultat.Length);

        }

    }
}
