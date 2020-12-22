using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            /*
             * Percorre por todos os dados de um vetor ou coleção
             * sem a necessidade de haver um cursor para indicar
             * a posição correta de contagem 
             */
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
