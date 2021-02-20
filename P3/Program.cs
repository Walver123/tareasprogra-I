using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, r, r1, r2;
            Console.WriteLine("Ingrese cantidad de horas trabajadas");
            a = int.Parse(Console.ReadLine());
            if (a <= 40)
            {
                r = a * 16;
                Console.Write("Total de sueldo" + r);
            }
            else
            {
                r = a - 40;
                r1 = r * 20;
                r2 = r1 + 640;
                Console.Write("sueldo:" + r2);
            }
        }
    }
}
