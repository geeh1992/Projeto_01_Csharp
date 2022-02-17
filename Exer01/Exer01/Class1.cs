using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer01
{
    class Pilha
    {
        public void Empilhar(double no)
        {
            var Noo = new NoPrincipal { Nos = no };
            if (inicio == null)
                inicio = topo = Noo;
            else
            {
                topo.Proximo = Noo;
                Noo.Anterior = topo;
                topo = Noo;
            }
            qtde++;
        }
        public void Desempilhar()
        {
            if (inicio == null)
                throw new Exception("Sem elemento a ser removido.");
            if (inicio == topo)
                inicio = topo = null;
            else
            {
                topo.Anterior.Proximo = null;
                topo = topo.Anterior;
            }
            qtde--;
        }
        public NoPrincipal Topo { get { return topo; } }
        public NoPrincipal Inicio { get { return inicio; } }
        public int Qtde { get { return qtde; } }
        public NoPrincipal topo = null;
        public NoPrincipal inicio = null;
        public int qtde = 0;
    }
}
