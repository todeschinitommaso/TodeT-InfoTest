using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodeT_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //STRUTTURA DINAMICA
        public List<TodeT_Candidato> lista = new List<TodeT_Candidato>();

        //AGGIUNTA
        public void Aggiunta(TodeT_Candidato a)
        {
            lista.Add(a);
        }

        //VISUALIZZA
        public string[] Visualizza(List<TodeT_Candidato> a)
        {
            string[] s = new string[999];
            int n = 0;
            foreach(TodeT_Candidato c in lista)
            {
                s[n] = c.ToString();
                n++;
            }

            return s;   
        }

        //MODIFICA
        public void Modifica(int nmatricola, string nome)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Matricola == nmatricola)
                {
                    lista[i].Nome = nome;
                }
            }
        }

    }
}
