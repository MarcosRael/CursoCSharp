using System;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno:");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N):");
            entrada = Console.ReadLine();

            //Primeira Maneira
            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //Segunda Maneira
            //bomComportamento = entrada == "S" || entrada == "s";

            //Terceira Maneira
            //Compressão das logicas acima
            bomComportamento = entrada.ToLower().Trim() == "s";

            //Verifica se o aluno ganhará o quadro de honra
            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
