using System;
using System.Collections.Generic;
using System.Text;

namespace Controlled_iterations
{
    class C4
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            float avg = 0;


            Console.WriteLine("enter the count of numbers you want to enter:");
            int count = int.Parse(Console.ReadLine());

            Console.Write("enter the numbers:");
            for (int i = 1; i <= count; i++)
            {

                num = int.Parse(Console.ReadLine());

                sum = num + sum;
                avg = sum / num;


                //int avg = sum /count;
                //Console.WriteLine(avg);

            }
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
