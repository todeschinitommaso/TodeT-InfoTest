using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodeT_InfoTest
{
    public abstract class TodeT_Disoccupato : TodeT_Candidato
    {
        private int _TodeT_voto;

        private bool _TodeT_lode;

        //PROPERTIES
        public int Voto
        {
            get
            {
                return _TodeT_voto;
            }
            set
            {
                if (value >= 0 && value <= 110)
                    _TodeT_voto = value;
                else
                    throw new Exception("Voto non valido");
            }
        }
        public bool Lode
        {
            get
            {
                return _TodeT_lode;
            }
            set
            {
                if (_TodeT_voto == 110)
                {
                    try
                    {
                        _TodeT_lode = value;
                    }
                    catch
                    {
                        throw new Exception("Lode non valida");
                    }
                }
                else
                    throw new Exception("Lode non disponibile");
            }
        }

        //COSTRUTTORE SENZA PARAMETRI
        public TodeT_Disoccupato()
        {
            Voto = 0;
            Lode = false;
        }

        //COSTRUTORE CON PARAMETRI
        public TodeT_Disoccupato(int voto, bool lode)
        {
            Voto = voto;
            Lode = lode;
        }

        //METODO PUNTEGGIO
        public override int punteggio()
        {
            int a = (Voto * 100) / 110;
            if (Lode == true)
                a += 5;

            return a;
        }

        //METODO ISIDONEO
        public override bool isIdoneo()
        {
            if(punteggio() >= 72) 
                return true;

            return false;
        }
    }
}
