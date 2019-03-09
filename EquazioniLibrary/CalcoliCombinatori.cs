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

            //inserisco un for per fare il calcolo del fattoriale
            for (int i = 1; i <= n; i = i + 1)
            {
                fattoriale = fattoriale * i;
            }

            return fattoriale;
        }
    }
}
