using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido....");
            
            Console.WriteLine(infoPublica);
            Console.WriteLine(corDoOlhos);
            Console.WriteLine(numeroCelular);
            Console.WriteLine(jeitoDeFalar);
            Console.WriteLine(segredoFamilia);
            //Console.WriteLine(usaMuitoPhotoshop);
            
        }
    }
}
