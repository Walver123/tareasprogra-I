﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, num;
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<(num + 1); i++)
            {
                if (num % i==0)
                {
                    a++;
                }
            }
            if (a !=2)
            {
                Console.WriteLine(num + " No es primo");
            }
            else
            {
                Console.WriteLine(num + " Si es primo");
            }
        }

    }
}