using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {

        public class Conta
        {
            double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if(valor > Saldo)
                {
                    throw new ArgumentException("Saldo insuficiente");
                }

                Saldo -= valor;
            }
        }

        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                int.Parse("abc");

                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //Pai de todas (Generica)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
