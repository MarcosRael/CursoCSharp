using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEObjetos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            //OP 1
            //if (cilindrada > 0) {
            //   Cilindrada = cilindrada;
            //}

            //OP 2
            //Cilindrada = Math.Abs(cilindrada);

            //OP3
            Cilindrada = cilindrada;

        }

    }

    class GetSet {
        public static void Executar() {

            var moto1 = new Moto("Honda", "Titan ESDI", 150);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Yamaha");
            moto2.SetModelo("Xj6");
            moto2.SetCilindrada(600);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());

        }
    }
}
