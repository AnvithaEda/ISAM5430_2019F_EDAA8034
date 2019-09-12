using System;
using System.Collections.Generic;
using System.Text;

namespace Controlled_iterations
{
    class C3
    {
        public static void Main(int end)
        {
            int i = 0;
            while (fib(i) <= end)
            {
                Console.WriteLine(fib(i));
                i++;
            }
        }

        public static int fib(int n)
        {
            if (n <= 1)
                return n;
           else
                return fib(n - 1) + fib(n - 2);

        }
    }
}
