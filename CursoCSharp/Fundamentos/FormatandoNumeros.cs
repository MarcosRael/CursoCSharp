using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //formatando casa decimais
            Console.WriteLine(valor.ToString("C")); //formatando para moeda
            Console.WriteLine(valor.ToString("P")); //formatando para por cento
            Console.WriteLine(valor.ToString("#.##")); //formatando casas decimais 

            //Inializando uma variavel com a cultura do Brasil
            CultureInfo culturaBrasil = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2",culturaBrasil));

             //Inializando uma variavel com a cultura do Brasil
            CultureInfo culturaEUA = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2",culturaEUA));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // preenchimento de zeros a esquerda






        }
    }
}
