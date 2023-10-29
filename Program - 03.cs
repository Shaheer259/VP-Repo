using System;
namespace c
{
    class pro
    {
        public static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter value of n: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                i++;
                n = n / 10;
            }
            Console.WriteLine("Magnitude of given number is: " + i);
        }
    }
}
