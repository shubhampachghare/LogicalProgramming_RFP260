using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    public class FibonacciSeries
    {
        public void FibonacciSeries1()
        {

            {
                int a = 0, b = 1, c = 0, len;

                Console.Write("length:  ");
                len = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} {1} ", a, b);
                for (int i = 2; i < len; i++)
                {
                    c = a + b;
                    Console.Write("{0} ", c);
                    a = b;
                    b = c;
                }
            }
        }


    }
}