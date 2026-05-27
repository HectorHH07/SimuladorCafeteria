using System;
using System.Collections.Generic;

namespace SimuladorCafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de la lista genérica basada en la superclase
            List<Bebida> pedido = new List<Bebida>();

            // Agregamos bebidas calientes y frías
            pedido.Add(new BebidaCaliente("Café Americano", "Grande", 90.5f, 45.00f));
            pedido.Add(new BebidaFria("Frappé de Capuchino", "Mediano", 5, 60.00f));
            pedido.Add(new BebidaCaliente("Chocolate Caliente", "Grande", 85.0f, 50.00f));
            pedido.Add(new BebidaFria("Té Helado", "Pequeño", 3, 35.00f));
            pedido.Add(new BebidaCaliente("Latte", "Mediano", 92.0f, 55.00f));

            Console.WriteLine("PREPARACIÓN DE BEBIDAS \n");

            // Producción polimórfica
            foreach (Bebida bebida in pedido)
            {
                Console.WriteLine(bebida.Preparar());

                
                if (bebida is BebidaCaliente caliente)
                {
                    if (caliente.temperatura > 88)
                    {
                        Console.WriteLine(" ¡Cuidado la  bebida  esta muy caliente!");
                    }
                }

                Console.WriteLine();

            }

            // Sumatoria económica
            float total = 0;
             foreach (Bebida bebida in pedido)
            {
                total += bebida.Precio;
            }


            
            Console.WriteLine("\nEl total del pedido es: $" + total);
        }
    }

}