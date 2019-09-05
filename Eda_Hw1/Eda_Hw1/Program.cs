using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eda_Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator:(+,-,/,*)");
            string op = Console.ReadLine();
            if (op == "+")
            {
                int sum;
                sum = num1 + num2;
                Console.WriteLine($"sum is {sum}");
            }
            if (op == "-")
            {
                int subtract;
                subtract = num1 - num2;
                Console.WriteLine($"subtraction is {subtract}");
            }
            if (op == "*")
            {
                int multiplication;
                multiplication = num1 * num2;
                Console.WriteLine($"multiplication is {multiplication}");
            }
            if (op == "/")
            {
                int division;
                division = num1 / num2;
                Console.WriteLine($"division is {division}");
            }
        }
    }
}
