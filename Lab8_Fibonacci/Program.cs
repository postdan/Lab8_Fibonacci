using System;

namespace Lab8_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("For Fibonacci sequence, insert N:");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int n);
            ulong fiboN = 0;
            ulong n1 = 1;
            ulong n2 = 0;
            int i = 2;
            Console.WriteLine($"For n={n}, Fibonacci sequence is:");
            if (n == 0)
            {
                Console.WriteLine($"F(0) = 0");
            }
                if (n > 0)
            {
                Console.WriteLine($"F(0) = 0");
                Console.WriteLine($"F(1) = 1");
            }
            while (i<=n)
            {
                fiboN = n2 + n1;
                n2 = n1;
                n1 = fiboN;
                Console.WriteLine($"F({i}) = {fiboN}");
                i++;
            }
        }
    }
}
