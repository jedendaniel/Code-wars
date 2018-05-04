using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Kata
    {
        #region DescendingOrder
            //Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order.Essentially, rearrange the digits to create the highest possible number.
            //Examples:
            //Input: 21445 Output: 54421
            //Input: 145263 Output: 654321
            //Input: 1254859723 Output: 9875543221    
        

        public static int DescendingOrder(int num)
        {
            List<char> list = num.ToString().ToList();
            list.Sort();
            list.Reverse();
            string res = "";
            foreach (char c in list)
            {
                res += c;
            }
            return int.Parse(res);
        }

        public static void DescendingOrderTest()
        {
            System.Console.WriteLine(DescendingOrder(321456));
            System.Console.WriteLine(DescendingOrder(21445));
            System.Console.WriteLine(DescendingOrder(12548));
        }

        public static int DescendingOrderBest(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
        #endregion
    }
}
