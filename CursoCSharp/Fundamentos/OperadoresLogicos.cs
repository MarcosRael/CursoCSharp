using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = true;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);

        }
    }
}
