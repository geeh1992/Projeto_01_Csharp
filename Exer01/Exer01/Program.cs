using System;
namespace Exer01
{
    class NoPrincipal
    {
        public NoPrincipal Proximo
        {
            set { proximo = value; }
            get { return proximo; }
        }
        public NoPrincipal Anterior
        {
            set { anterior = value; }
            get { return anterior; }
    
}
    public double Nos
    {
        set { no = value; }
        get { return no; }
    }
    public NoPrincipal? proximo = null;
    public NoPrincipal? anterior = null;
    public double no;
}
    
   
class Program
{
    static void Main(string[] args)
    {
        var pilhaP = new Pilha();
        pilhaP.Empilhar(1);
        pilhaP.Empilhar(2);
        pilhaP.Empilhar(3);
        pilhaP.Empilhar(4);
        pilhaP.Empilhar(5);
        pilhaP.Empilhar(6);
        pilhaP.Empilhar(7);
        pilhaP.Empilhar(8);
        pilhaP.Empilhar(9);
        pilhaP.Empilhar(10);
        Imprimir(pilhaP);
        var filaF = new Fila();
        filaF.Inserir(10);
        filaF.Inserir(9);
        filaF.Inserir(8);
        filaF.Inserir(7);
        filaF.Inserir(6);
        filaF.Inserir(5);
        filaF.Inserir(4);
        filaF.Inserir(3);
        filaF.Inserir(2);
        filaF.Inserir(1);
        ImprimirFila(filaF);
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        pilhaP.Desempilhar();
        Imprimir(pilhaP);
        ImprimirFila(filaF);
        Console.ReadKey();
    }
    public static void Imprimir(Pilha pilhaP)
    {
        var NoAtual = pilhaP.Inicio;
        while (NoAtual != null)
           
    {
            Console.Write($"{NoAtual.Nos} ");
            NoAtual = NoAtual.Proximo;
        }
        Console.WriteLine();
    }
    public static void ImprimirFila(Fila filaF)
    {
        var NoAtual = filaF.Inicio;
        while (NoAtual != null)
        {
            Console.Write($"{NoAtual.Nos} ");
            NoAtual = NoAtual.Proximo;
        }
                   Console.WriteLine();
    }
  }
}