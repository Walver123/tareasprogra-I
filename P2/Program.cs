using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Cliente
    {
        private float descuento;
        private float precio;
        public void Inicio()
        {
            Console.WriteLine("INGRESE PRECIO DEL PRODUCTO: ");
            precio = float.Parse(Console.ReadLine());

        }
        public void Descuento()
        {
            if (precio > 300)
            {
                float res = (precio * 20) / 100;
                descuento = precio - res;
                Console.WriteLine("--------TIENDA METROPLAZA JUTIAPA -------");
                Console.WriteLine("DESCUENTO DEL 20% POR SUPERAR Q. 300");
                Console.WriteLine("PRECIO ES: " + descuento);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("--------TIENDA METROPLAZA JUTIAPA -------");

                Console.WriteLine("PRECIO ES: " + precio);
                Console.ReadLine();

            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------TIENDA METROPLAZA JUTIAPA -------");
            Cliente clie = new Cliente();
            clie.Inicio();
            clie.Descuento();

        }

    }
}

