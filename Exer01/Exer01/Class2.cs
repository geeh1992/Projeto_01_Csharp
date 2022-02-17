using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer01
{
    class Fila
    {
        public void Inserir(int no)
        {
            var novoNo = new NoPrincipal { Nos = no };
            if (inicio == null)
                inicio = novoNo;
            else
            {
                var fim = inicio;
                while (fim.Proximo != null)
                    fim = fim.Proximo;
                fim.Proximo = novoNo;
            }

            tamanho++;
        }
        public void Remover()
        {
            if (inicio == null)
                throw new Exception("Não tem elementos para remover.");
            inicio = inicio.Proximo;
            tamanho--;
        }
        public NoPrincipal Inicio { get { return inicio; } }
        public NoPrincipal Fim { get { return fim; } }
        public int Tamanho { get { return tamanho; } }
        public NoPrincipal inicio = null;
        public NoPrincipal fim = null;
        public int tamanho = 0;
    }
}
