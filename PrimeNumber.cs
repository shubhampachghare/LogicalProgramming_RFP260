using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumber
{
    public class PrimeNumber1
    {
        public void Prime()
        {
            int i, n;
            Console.WriteLine("Enter a number:  ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    //count++;
                    break;
                }
            }

            if (i == n)
            {
                Console.WriteLine("Number is prime :  " + n);

            }
            else
            {
                Console.WriteLine("Number is not prime   ");
            }
        }
    }
}