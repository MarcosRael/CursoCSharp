using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            double nota = 0.0;
            double notaDeCorte = 7.0;

            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out nota);

            Console.WriteLine("Nota Invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota Invalida? {0}", nota < 0.0);
            Console.WriteLine("Pefeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por media? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
