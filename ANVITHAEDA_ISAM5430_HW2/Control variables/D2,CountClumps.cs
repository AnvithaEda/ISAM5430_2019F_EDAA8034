using System;
using System.Collections.Generic;
using System.Text;

namespace Control_variables
{
    class D2_CountClumps
    {

        public static void Main()
        {
            // Write your codes here  
            int clump = 0, prev = -1;
            Console.WriteLine("enter the variables");
            int cur = int.Parse(Console.ReadLine());
            for(int i=0;i<cur;i++)
            {
                if(cur==prev)
                {
                    clump++;

                }
            }

           
          

        }
    }
}
