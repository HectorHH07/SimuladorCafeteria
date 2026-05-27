using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCafeteria
{
    internal class BebidaCaliente:Bebida
    {
        private float Temperatura;
        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        public BebidaCaliente(string nombre,string tamaño,float temperatura,float precio):base(nombre,tamaño,precio)
        {
            Temperatura=temperatura;
        }
        public override string Preparar()
        {
            return "Estamos preparando un : " + nombre +" Caliente a una temperatura de : " + Temperatura + "°Con Tamaño : " + tamaño;
        }
    }
}
