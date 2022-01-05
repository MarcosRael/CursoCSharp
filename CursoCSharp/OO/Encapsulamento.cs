using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento; //Nome do mesmo namespace

namespace CursoCSharp.OO
{

    public class FilhoNãoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNãoReconhecido....");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDoOlhos);
            //Console.WriteLine(numeroCelular);
            Console.WriteLine(jeitoDeFalar);
            //Console.WriteLine(segredoFamilia);
            //Console.WriteLine(usaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();


        public void MeusAcessos()
        {

            Console.WriteLine("AmigoDistante....");

            Console.WriteLine(amiga.infoPublica);
            //Console.WriteLine(amiga.corDoOlhos);
            //Console.WriteLine(amiga.numeroCelular);
            //Console.WriteLine(amiga.jeitoDeFalar);
            //Console.WriteLine(amiga.segredoFamilia);
            //Console.WriteLine(amiga.usaMuitoPhotoshop);
        }
    }


    class Encapsulamento
    {
        public static void Executar()
        {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();


            new FilhoNãoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
