﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, z1, z2;
            Console.WriteLine("введите альфа:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("результат1:");
            z1 = (Math.Sin(Math.PI / 2 + 3 * (a))) / (1 - Math.Sin(3 * a - Math.PI));
            Console.WriteLine(z1);

        }
    }
}
