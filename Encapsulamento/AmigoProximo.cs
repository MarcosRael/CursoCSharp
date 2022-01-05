using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo....");

            Console.WriteLine(amiga.infoPublica);
            //Console.WriteLine(amiga.corDoOlhos);
            Console.WriteLine(amiga.numeroCelular);
            Console.WriteLine(amiga.jeitoDeFalar);
            //Console.WriteLine(amiga.segredoFamilia);
            //Console.WriteLine(amiga.usaMuitoPhotoshop);
        }
    }
}
