using System;
using System.Collections.Generic;
using System.Text;

namespace Controlled_iterations
{
    class Factorial
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"{factorial1(i)} ");
            }
        }
        static int factorial1(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
                return number * factorial1(number - 1);

        }

    }
}
