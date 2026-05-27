using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCafeteria
{
    internal class Bebida
    {
        protected string nombre;
        protected string tamaño;
        protected float precio;
        
        public float Precio
        {
            get { return precio; }
            set
            {
                if(value>0)
                {
                    precio = value;
                }
                else
                {
                    precio = -1;
                }
            }
        }
       public Bebida()
        {
            nombre = "";
            tamaño = "";
            precio = 0;
        }
        public Bebida(string nombre, string tamaño, float precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }
        //Metodo para simular la preparacion
        public virtual string Preparar()
        {
            return "Estamos preparando un :" + nombre + "De tamaño:" + tamaño;
        }
        //Metodo para aplicar descuento
        public void AplicarDescuento(float porcentaje)
        {
            precio = precio * (1 - (porcentaje / 100));
        }
       
       
    }
}
