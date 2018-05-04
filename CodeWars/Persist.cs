using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{

    #region task content
        //Write a function Persistence which returns how many time is needed to multiply each digit of number to get one digit number.
    #endregion

    public static class Persist
    {
        public static int Persistence(long n)
        {
            int i = 0;
            while(n > 9)
            {
                i++;
                long p = 1;
                while (n != 0)
                {
                    p *= n % 10;
                    n /= 10;
                }
                n = p;
            }
            return i;
        }

        public static void Test()
        {
            Console.WriteLine("4 | " + Persist.Persistence(4));
            Console.WriteLine("25 | " + Persist.Persistence(25));
            Console.WriteLine("39 | " + Persist.Persistence(39));
            Console.WriteLine("999 | " + Persist.Persistence(999));
        }
    }
}
