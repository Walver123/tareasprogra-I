using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Ingrese un dia de la semana");
            a = Console.ReadLine();
            if (a == "lunes")
            {
                Console.Write("dia laboral");
            }
            if (a == "martes")
            {
                Console.Write("dia laboral");
            }
            if (a == "miercoles")
            {
                Console.Write("dia laboral");
            }
            if (a == "jueves")
            {
                Console.Write("dia laboral");
            }
            if (a == "viernes")
            {
                Console.Write("dia laboral");
            }
            if (a == "Sabado")
            {
                Console.Write("No es dia laboral");
            }
            if (a == "domingo")
            {
                Console.Write("No es dia laboral");

            }
        }
    }
}
            