﻿using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Pizzaria =========\n");
            Console.WriteLine("Informe a pizza: (C)alabreza ou (M)ussarela");

            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida.ToUpper());

                pizza.Preparar();
                pizza.Assar(30);
                pizza.Embalar();

                Console.WriteLine("\nPizza concluída com sucesso!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
