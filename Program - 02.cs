using System;
namespace prime
{
    class Pro
    {
        public static void Main()
        {
            int i, c, m = 1;
            Console.WriteLine("Enter a Value: ");
            int n = int.Parse(Console.ReadLine());
            c = 0; i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    if (i != n)
                        m = i;
                    c++;
                }
                i++;
            }
            if (c == 2)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine(m + "is largest factor" + n);
                Console.ReadLine();
            }
        }
    }
}
