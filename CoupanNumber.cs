using System;
using System.Collections.Generic;
using System.Text;

namespace CouponNumber
{
    public class Coupon
    {
        public void GetCouponNum()
        {
            Console.WriteLine("Enter the number of coupons to be generated");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> listNumbers = new List<int>();
            int number;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                do
                {
                    number = random.Next(100, 1000);

                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
                Console.WriteLine("coupon {0}-[{1}]", i, number);

            }

        }
    }
}