using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCafeteria
{
    internal class BebidaFria:Bebida
    {
        private int CantidadHielo;

        public BebidaFria(string nombre, string tamaño, int CantidadHielo, float precio) : base(nombre, tamaño, precio)
        {
            this.CantidadHielo = CantidadHielo;
        }
        public override string Preparar()
        {
            return "Estamos preparando un :" + nombre + "Helado con:" + CantidadHielo + "Cubos de hielo"+"de tamaño" + tamaño;
        }
    }
}
