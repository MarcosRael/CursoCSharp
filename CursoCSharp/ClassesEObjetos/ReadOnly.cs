using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {

    public class Cliente {
        public string Nome;
        //Somente valido no construtor da classe
        readonly DateTime Nascimento;
  

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class ReadOnly {
      
        

        public static void Executar() {
            var novoCliente = new Cliente("Ana Clara", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            //Erro ao tentar salvar outro valor na variavel 
            //ReadOnly no decorrer do programa
            //novoCliente.GetDataDeNascimento = new Cliente("Ana Clara", new DateTime(2000, 5, 22));

        }
    }
}
