﻿using System;
namespace Factor
{
    class Program
    {
        public static void Main()
        {
            int i = 2, n;
            Console.WriteLine("Enter value of n: ");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                if (n < 10 && i <= n)
                {
                    Console.WriteLine(n + " doesn't have single digital factor other than one");
                    break;
                }
                if (n % i == 0)
                {
                    Console.WriteLine(i + " is smallest factor");
                    break;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
