using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodeT_InfoTest
{
    internal class TodeT_Candidato
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
            Nome=null;
        }
        public TodeT_Candidato(string nome)
        {
            Matricola = 0;
            Nome = nome;
        }

        //COSTRUTTORE CON DUE PARAMETRI
        public TodeT_Candidato(int matricola, string nome)
        {
            Matricola=matricola;
            Nome = nome;
        }

        //METODO ASTRATTO ISIDONEO
        public static bool isIdoneo(bool a)
        {
            return a;
        }

        //METODO ASTRATTO PUNTEGGIO
        public static int punteggio(int i)
        {
            return i;
        }
    }
}
