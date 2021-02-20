using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Ingrese una letra (a,A)");
            a = Console.ReadLine();
            if (a == "A")
            {
                Console.Write("Es mayuscula");
            }
            else
            {
                Console.Write("Es minuscula");
            }
        }
    }
}