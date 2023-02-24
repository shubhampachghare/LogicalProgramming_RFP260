using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseNumber
{
    public class ReverseNumber1
    {
        public void CheckPalindrome()
        {
            int sum = 0;
            int temp = 0;
            int remainder;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());


            while (number != 0)
            {
                remainder = number % 10;
                sum = sum * 10 + remainder;
                number = number / 10;
            }


            Console.WriteLine("Reverse number is:   " + sum);
        }
    }
}