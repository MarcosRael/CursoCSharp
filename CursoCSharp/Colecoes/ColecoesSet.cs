using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
     
    class ColecoesSet {

      
        public static void Executar() {

            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>(); // HashSet é uma lista não indexada que não aceita repetição.

            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster",10)
            };

            //Adiciona varios itens
            carrinho.UnionWith(combo);//Realiza a união

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);//Não aceita inserir duas vezes a mesma estrutura.

            //Retorna o index do ultimo registro adicionado com esse objeto
            //Console.WriteLine(carrinho.LastIndexOf(livro));

            //Verifica se contém o objeto na lista
            var result = carrinho.Contains(livro);
            
        }
    }
}
