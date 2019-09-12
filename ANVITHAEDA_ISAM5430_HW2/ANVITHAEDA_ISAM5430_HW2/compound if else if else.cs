using System;
using System.Collections.Generic;
using System.Text;

namespace ANVITHAEDA_ISAM5430_HW2
{
    class compound_if_else_if_else
    {
        public void main(string[] args)

        {
            //enter the first number
            Console.WriteLine("enter the first number:");
            //input the number
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number:");
            int c = int.Parse(Console.ReadLine());
            if ((a < b && b < c) || (c < b && b < a))
            { 
                Console.WriteLine(b);

            }
            else if ((b < a && a < c) || (c < a && a < b))

            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }





        }
    }
}
