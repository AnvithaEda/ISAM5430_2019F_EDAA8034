using System;
using System.Collections.Generic;
using System.Text;

namespace Controlled_iterations
{
    class C2
    {
        static void Main(string[] args)
        {
            //doubling the previous number
            for (int i = 1; i < 100; i = i * 2)
            {
                Console.Write(i + "  ");

            }
            Console.ReadLine();

            //halved previous integer
            for (int i = 100; i >0;)
            {
                Console.Write(i + "  ");
                i = (i+2)/ 2;
                i--;
               
            }
            Console.ReadLine();

            //halved previous number without truncating
            for (float i = 100; i > 1;)
            {
                Console.Write(i + "  ");
                i = (i + 2) / 2;
                i--;

            }
            Console.ReadLine();



        }
    }
}
