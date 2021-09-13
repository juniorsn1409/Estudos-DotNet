using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var pilha = new Pilha();

            pilha.Empilha(1);
            pilha.Empilha(2);
            pilha.Empilha(3);

            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
        }
    }
}
