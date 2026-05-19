using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCafeteria
{
    internal class Bebida
    {
        private string nombre;
        private string tamaño;
        private double precio;
        //constructor para inicializar los productos
        public Bebida(string nombre, string tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }
        //Metodo para simular la preparacion
        public void Preparar()
        {
            Console.WriteLine($"Preparando un {nombre} tamaño {tamaño}");
        }
        //Metodo para aplicar descuento
        public void AplicarDescuento(double porcentaje)
        {
            if (porcentaje >0 && porcentaje <=100)
            {
                double descuento = precio * (porcentaje / 100);
                precio=descuento;
                Console.WriteLine($"Se aplico un {porcentaje}% de descuento a {nombre}");
            }
            else
            {
                Console.WriteLine("Porcentaje de descuento no aceptado");
            }
        }
        //Metodo para mostrar descripcion
        public void MostrarDescripcion()
        {
            Console.WriteLine($"Esto es un {nombre} de tamaño {tamaño} con un costo de ${precio}");
        }
    }
}
