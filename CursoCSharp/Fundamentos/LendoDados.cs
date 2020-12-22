using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture); //comando para deixar variante a forma de colocar o ponto ou virgula

            Console.WriteLine($"{nome}-----{idade}-----R${salario}");


        }
    }
}
