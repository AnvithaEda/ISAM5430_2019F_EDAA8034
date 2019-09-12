using System;
using System.Collections.Generic;
using System.Text;

namespace Controlled_iterations
{
    class C1
    {
        static void Main(string[] args)

        {
            //for priting integers in reverse order
            for (int i = 20; i >= 0; i--)

            {
                Console.Write(i + " ");

            }
            Console.ReadLine();


            //for priting even numbers
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();



            //multiples of 10
            for (int i = 1; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();


            /*for odd numbers and not dividible by 3*/
            for (int i = 0; i < 20; i++)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();

            //2 digit integer squares
            for (int i = 4; i < 10; i++)
            {
                int n = i * i;

                {
                    Console.Write(n + " ");
                }

            }
            Console.ReadLine();

            //numbers divisible by 3 and 5 but not both
            for (int i = 1; i < 100; i++)
            {
                if ((i % 3 != 0) && (i % 5 != 0))
                {
                    Console.Write(i + " ");
                }

            }
            Console.ReadLine();

            //priniting lowcase letters
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");
            }
            Console.ReadLine();


        }
    }
}
