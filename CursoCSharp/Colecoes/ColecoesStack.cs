using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            //Pilha primeiro a entrar é o ultimo a sair
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}, ");
            }

            //Retorna e remove o primeiro item da Pilha 
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}, ");
            }

            //Apenas retorna o primeiro item da Pilha
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }
}
