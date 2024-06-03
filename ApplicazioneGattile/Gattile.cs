using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicazioneGattile
{
    internal class Gattile
    {
        private List<Gatto> _gatti;
        private List<Gatto> _adozioni;
        public List<Gatto> Gatti { get; private set; }
        public List<Gatto> Adozioni { get; private set; }
        public void AggiungiGatti(Gatto g) { Gatti.Add(g);}
        public void AggiungiAdozioni(Gatto g) { Adozioni.Add(g); }
    }
}
