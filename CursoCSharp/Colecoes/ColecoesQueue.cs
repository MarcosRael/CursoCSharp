using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            //Adicionar um item na fila
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");


            //Busca o primeiro item da fila
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //Remove o primeiro item da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);


            foreach(var item in fila)
            {
                Console.WriteLine(item);
            }

            //Precisa importar collections sem o generic
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}
