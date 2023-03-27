using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodeT_InfoTest
{
    public abstract class TodeT_Candidato
    {
        private int _TodeT_matricola;

        private string _TodeT_nome;

        //PROPERTIES
        public int Matricola
        {
            get { return _TodeT_matricola; }
            set { _TodeT_matricola = value; }
        }
        public string Nome
        {
            get { return _TodeT_nome; }
            set { _TodeT_nome = value; }
        }

        //OOSTRUTTORE SENZA PARAMETRI
        public TodeT_Candidato()
        {
            Matricola = 0;
            Nome = null;
        }

        //COSTRUTTORE CON UN PARAMETRO
        public TodeT_Candidato(int matricola)
        {
            Matricola = matricola;
            Nome = null;
        }
        public TodeT_Candidato(string nome)
        {
            Matricola = 0;
            Nome = nome;
        }

        //COSTRUTTORE CON DUE PARAMETRI
        public TodeT_Candidato(int matricola, string nome)
        {
            Matricola = matricola;
            Nome = nome;
        }

        //METODO ASTRATTO
        public abstract bool isIdoneo();
        public abstract int punteggio();

        //TOSTRING
        public override string ToString()
        {
            string s = Matricola + ", " + Nome;
            return s;
        }

        //EQUALS
        public bool Equals(TodeT_Candidato a)
        {
            if (a == null)
                return false;

            if (this == a)
                return true;

            if (this.Matricola == a.Matricola || this.Nome == a.Nome)
                return true;

            else
                return false;
        }

        //COMPARETO
        public bool CompareTo(TodeT_Candidato a)
        {
            if (this.punteggio() == a.punteggio())
                return true;

            else
                return false;
        }

        //HASHCODE
        public override int GetHashCode()
        {
            return (Matricola, Nome).GetHashCode();
        }
    }
}


