using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; //conversão de forma implicita

            Console.WriteLine(quebrado);


            double nota = 9.7;
            int notaTrucada = (int)nota; //conversão explicita
            Console.WriteLine("Nota trucada:{0}", notaTrucada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); //Esse metodo ele tenta realizar a conversão se não conseguir retorna ZERO
            Console.WriteLine("Resultado 1: {0}", numero);

            //Otimizando o codigo anterior
            Console.Write("Digite segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);


        }
    }
}
