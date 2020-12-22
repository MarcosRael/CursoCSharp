using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {
    /*Utilizando Metodos STATIC torna acesivel a partir da classe, sem
     * precisar instaciar um objeto para utilizar o metodo
     */

    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }

    }
    
    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);

            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
