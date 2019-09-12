using System;

namespace ANVITHAEDA_ISAM5430_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            if(first>second)
            {
                Console.WriteLine(first);
            }
            else if(second>first)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("both are same");
            }

        }
    }
}
