using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {
    class Params {
        
        public static void Recepcionar(params string[] pessoas) {
            int index = 0;
            foreach (var pessoa in pessoas) {
                index++;
                Console.WriteLine("{0} - Olá {1}", index, pessoa);
            }
        }
        
        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Adriano","Marcos", "Joice");
        }
    }
}
