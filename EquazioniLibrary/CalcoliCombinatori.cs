using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static long Fattoriale(long n)
        {
            //inizializzo le variabile di ritorno
            long fattoriale = 1;

            //Inserisco una if di controllo poichè i numeri superiori a 20 generano un errore di overflow
            if (n > 20)
            {
                fattoriale = 0;
            }
            else
            {
                //inserisco un for per fare il calcolo del fattoriale
                for (int i = 1; i <= n; i++)
                {
                    fattoriale = fattoriale * i;
                }
            }

            return fattoriale;
        }
    }
}
