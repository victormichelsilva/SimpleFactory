using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PizzaMussarela : Pizza
    {
        public PizzaMussarela() 
        {
            Nome = "Mussarela";
        }

        public override void Preparar() 
        {
            Console.WriteLine($"Preparando pizza de {Nome}.");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Emabalando pizza de {Nome}.");
        }
    }
}
