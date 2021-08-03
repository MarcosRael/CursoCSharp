using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    
    
    class ColecoesList {

        public static void Executar() {

            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster",10)
            };

            //Adiciona varios itens
            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            carrinho.Add(livro);
            carrinho.Add(livro);

            //Retorna o index do ultimo registro adicionado com esse objeto
            Console.WriteLine(carrinho.LastIndexOf(livro));

            //Verifica se contém o objeto na lista
            var result = carrinho.Contains(livro);
            
        }
    }
}
