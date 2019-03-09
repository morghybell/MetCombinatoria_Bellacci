using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static int Fattoriale(int n)
        {
            //inizializzo le variabile di ritorno
            int fattoriale = 1;

            //Inserisco una if di controllo poichè i numeri superiori a 20 generano come fattoriale un numero superiore a 32 bit
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
