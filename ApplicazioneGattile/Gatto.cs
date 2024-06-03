using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicazioneGattile
{
    internal class Gatto
    {
        public enum Genere
        {
            maschio,
            femmina
        }
        private string _codiceIdentificativo;
        private string _nome;
        private string _razza;
        private Genere _sesso;
        private Data _dataArrivo;
        private Data _dataUscita;
        private Data _dataNascita;
        private string _descrizione;
        public string CodiceIdentificativo
        {
            get { return _codiceIdentificativo;}
            private set { _codiceIdentificativo = value; }
        }
        public string Nome
        {
            get { return _nome;}
            private set
            {
                if (string.IsNullOrEmpty(_nome))
                    throw new Exception("il nome non puo essere null o vuoto");
                _nome = value;
            }
        }
        public string Razza
        {
            get { return _razza; }
            private set
            {
                if (string.IsNullOrEmpty(_razza))
                    throw new Exception("la razza non puo essere null o vuota");
                _razza = value;
            }
        }
        public Genere Sesso { get; private set; }
        public Data DataArrivo { get; private set; }
        public Data DataUscita { get; private set; }
        public Data DataNascita { get; private set; }
        public string Descrizione
        {
            get { return _descrizione; }
            private set
            {
                if (string.IsNullOrEmpty(_descrizione))
                    throw new Exception("La descrizione non puo essere vuota o null");
                _descrizione = value;
            }
        }
        public Gatto(string nome, string razza, Genere sesso, Data dataArrivo, string descrizione, Data dataNascita = null, Data dataUscita = null)
        {
            Nome = nome;
            Razza = razza;
            Sesso = sesso;
            DataArrivo = dataArrivo;
            DataUscita = dataUscita;
            DataNascita = dataNascita;
            Descrizione = descrizione;
            Random random = new Random();
            char a = ' ';
            char b = ' ';
            char c = ' ';
            for(int i = 0; i < 3; i++)
            {
                int num = random.Next(0, 26);
                if (i == 0)
                    a = (char)('a' + num);
                if (i == 1)
                    b = (char)('a' + num);
                else
                    c = (char)('a' + num);
            }
            CodiceIdentificativo = $"{random.Next(10000, 99999)}{DateTime.Now.Month.ToString().Split()[0]}{DateTime.Now.Year}{a}{b}{c}";
        }
        public override bool Equals(object? obj)    
        {
            if (obj == null) return false;
            if (obj is Gatto)
            {
                Gatto g = (Gatto)obj;
                if (CodiceIdentificativo == g.CodiceIdentificativo)
                    return true;
                return false;
            }
            return false;
        }
    }
}
