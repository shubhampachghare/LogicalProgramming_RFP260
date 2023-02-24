using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectNumber
{
    public class PerfectNumber1
    {
        public void number()
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter a number:  ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n; i++)
            {

                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("Sum is:  " + sum);
                }
            }


            if (n == sum)
            {
                Console.WriteLine(" Perfect number:  " + n);
            }
            else

                Console.WriteLine("Not Perfect number");

        }
    }
}