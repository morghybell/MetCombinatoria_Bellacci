using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(50, 0)]
        public void TestFattoriale(int a, int b)
        {
            //richiamo la Library e confronto i risultati
            int risultato_calcolato = EquazioniLibrary.CalcoliCombinatori.Fattoriale(a);
        }

        /*
            Ho scelto il tipo di dato Intero (Int) poichè il Fattoriale
            è calcolabile sono con i numeri Naturali.

            A causa di questa restrizione però il massimo numero di cui 
            è possibile calcolare il Fattoriale in questo programma è 20.
            Una volta superato questo numero il Fattoriale calcolato
            risulta come valore di lunghezza superiore a 32 bit.
        */
    }
}
