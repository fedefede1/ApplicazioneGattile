using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicazioneGattile
{
    internal class Statistiche
    {
        public int AdozioniFallite(Gattile gattile)
        {
            int adozioniFallite = 0;
            bool gattoAdottato;
            foreach (Gatto gatto1 in gattile.Gatti)
            {
                gattoAdottato = false;
                foreach (Gatto gatto2 in gattile.Adozioni)
                {
                    if (gatto1 == gatto2)
                    {
                        gattoAdottato = true;
                        break;
                    }
                }
                if (gatto1.DataUscita == null &&  gattoAdottato == true)
                    adozioniFallite++;
            }
            return adozioniFallite;
        }
    }
}
