using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValordaFortuna()
        {
            return 1_407_033.65;
        }

    }

    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomefamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomefamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
 
    }

    class Sealed
    {

        public static void Executar()
        {

            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValordaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomefamilia());

        }
    }
}
