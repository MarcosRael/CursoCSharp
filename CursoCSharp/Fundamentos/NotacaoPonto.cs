using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace(" World!", " Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;

            /*Nas navegações notação ponto é necessário haver alguns cuidados 
             * com variaveis do tipo null, para isso é importante utilizar '?'*/
            Console.WriteLine(valorImportante?.Length);


        }
    }
}
