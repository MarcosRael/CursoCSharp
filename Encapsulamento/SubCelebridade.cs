using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string infoPublica = "Tenho um instagram!";

        // Herança
        protected string corDoOlhos = "Verde";

        // mesmo projeto (assembly)
        internal ulong numeroCelular = 5551123123;

        //Herança ou mesmo projeto
        protected internal string jeitoDeFalar = "Uso muitas gírias";

        //mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string segredoFamilia = "Bla Bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDoOlhos);
            Console.WriteLine(numeroCelular);
            Console.WriteLine(jeitoDeFalar);
            Console.WriteLine(segredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);

        }

    }
}

