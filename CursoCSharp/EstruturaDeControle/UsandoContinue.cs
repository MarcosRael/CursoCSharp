using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 0; i <= intervalo; i++) {

                if (i % 2 == 1) {
                    //Faz com que reinie o laço se repetção 
                    continue;
                }

                Console.WriteLine( i + " ");
            }
        }
    }
}
