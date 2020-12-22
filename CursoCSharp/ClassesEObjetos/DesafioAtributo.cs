using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {
    class DesafioAtributo {
        int a = 10;

        /*Um metodo nivel de classe não pode 
         * acessar um atributo de instacia
         */
        public static void Executar() {
            //Acessar variavel 'a' dentro do método Executar!
            
            var Desafio = new DesafioAtributo();
            Console.WriteLine(Desafio.a);
            
            //Acertei kkkkkk
        }
    }
}
