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
        public void TestFattoriale(long a, long b)
        {
            //richiamo la Library e confronto i risultati
            long risultato_calcolato = EquazioniLibrary.CalcoliCombinatori.Fattoriale(a);

            //confronto il risultato del test con quello ottenuto dalla library
            Assert.AreEqual(risultato_calcolato, b);
        }

        /*
            Ho scelto il tipo di dato Long poichè il Fattoriale
            è calcolabile sono con i numeri Naturali. 

            A causa di questa restrizione però il massimo numero di cui 
            è possibile calcolare il Fattoriale in questo programma è 20.
            Una volta superato questo numero il Fattoriale calcolato
            và in overflow. 
        */
    }
}
