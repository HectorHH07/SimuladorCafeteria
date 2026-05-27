namespace SimuladorCafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida[] bebidas = new Bebida[3];
            
            //solicitamos datos de la bebida
            Console.WriteLine("Bebidas\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Bebida{i + 1}");

                Console.Write("Nombre de la bebida:");
                string nombre=Console.ReadLine();
                Console.Write("Tamaño (Pequeño,Mediano,Grande):");
                string tamaño = Console.ReadLine();
                Console.Write("Precio:$");
                float precio = float.Parse(Console.ReadLine());

                bebidas[i] = new Bebida(nombre, tamaño, precio);
                Console.WriteLine($"Bebida{i + 1} registrada con exito:\n");
            }
            //Aplicamos el descuneto
            Console.WriteLine("Descuento");
            bebidas[0].AplicarDescuento(15);
            bebidas[1].AplicarDescuento(10);
            bebidas[2].AplicarDescuento(5);
            Console.WriteLine();
            //Preparamos las bebidas
            Console.WriteLine("Preparando Bebidas");
            for (int i = 0; i < 3; i++)
            {
                bebidas[i].Preparar();
            }
            //Mostramos descrpcion de las bebidas
           /* Console.WriteLine("Descripcion de Bebidas");           
            for(int i = 0;i < 3; i++)
            {
                bebidas[i].MostrarDescripcion();
            }
           */

            
        }
    }
}
