using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            string Retorno = "Não contem nome.";

            if (!String.IsNullOrWhiteSpace(Nome)) {
                Retorno =  string.Format($"Olá me chamo {Nome} e tenho {Idade} anos.");
            }
          
            return Retorno;
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
