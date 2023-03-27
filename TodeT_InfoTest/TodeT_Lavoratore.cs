using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodeT_InfoTest
{
    public abstract class TodeT_Lavoratore : TodeT_Candidato
    {
        private int _TodeT_esperienze;

        //PROPERTIES
        public int Esperienze
        {
            get
            {
                return _TodeT_esperienze;
            }
            set
            {
                if (value >= 0 && value <= 5)
                    _TodeT_esperienze = value;
                else
                    throw new Exception("Numero di esperienze non accettato");
            }
        }

        //COSTRUTTORE SENZA PARAMETRI
        public TodeT_Lavoratore()
        {
            Esperienze = 0;
        }

        //COSTRUTTORE CON PARAMETRI
        public TodeT_Lavoratore(int esperienze, int matricola, string nome) : base(matricola, nome)
        {
            Esperienze = esperienze;
        }

        //METODO PUNTEGGIO
        public override int punteggio()
        {
            int a = Esperienze * 20;
            return a;
        }

        //METODO ISIDONEO
        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
                return true;

            return false;
        }
    }
}
