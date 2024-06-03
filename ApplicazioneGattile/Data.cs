using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicazioneGattile
{
    internal class Data
    {
        private int _giorno;
        private int _mese;
        private int _anno;
        public int Giorno
        {
            get { return _giorno; }
            private set 
            {
                if(value < 1 && value > 31)
                    throw new ArgumentException("il giorno deve essere un numero compreso tra 1 e 31");
                _giorno = value;
            }
        }
        public int Mese
        {
            get { return _mese; }
            private set
            {
                if (value < 1 && value > 12)
                    throw new ArgumentException("il mese deve essere un numero compreso tra 1 e 12");
                _mese = value;
            }
        }
        public int Anno
        {
            get { return _anno; }
            private set
            {
                if (value < 2000)
                    throw new ArgumentException("L'anno minimo accettabile è il 2000");
                _anno = value;
            }
        }
        public Data(int giorno, int mese, int anno)
        {
            Giorno = giorno;
            Mese = mese;
            Anno = anno;
            if ((mese == 4 || mese == 6 || mese == 9 || mese == 11) && giorno == 31)
                throw new ArgumentException("il mese selezionato ha solo 30 giorni");
            if (anno % 4 == 0 && mese == 2 && giorno > 29)
                throw new ArgumentException("nei mesi bisestili il mese di febbraio ha solo 29 giorni e non di piu");
        }
        public Data(string Data)
        {
            Giorno = Convert.ToInt32(Data.Split('/')[0]);
            Mese = Convert.ToInt32(Data.Split('/')[1]);
            Anno = Convert.ToInt32(Data.Split('/')[2]);
        }
        public override string ToString()
        {
            return $"{Giorno}/{Mese}/{Anno}";
        }
    }
}
