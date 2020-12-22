using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + (area + 1000));


            //Tipo internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Minha idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O menor valor que posso representar é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Meu salario se deus quiser é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int é " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1999.96f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000_000;
            Console.WriteLine("Valor Apple " +valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);


        }
    }
}
