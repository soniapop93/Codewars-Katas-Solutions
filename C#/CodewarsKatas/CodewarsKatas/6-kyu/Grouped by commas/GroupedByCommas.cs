/*
 * LINK: https://www.codewars.com/kata/5274e122fc75c0943d000148/train/csharp
 * 
 * Finish the solution so that it takes an input n (integer) and returns a string that is the decimal representation 
 * of the number grouped by commas after every 3 digits.
 * 
 * Assume: 0 <= n < 2147483647
 * 
 * Examples
 *        1  ->           "1"
 *       10  ->          "10"
 *      100  ->         "100"
 *     1000  ->       "1,000"
 *    10000  ->      "10,000"
 *   100000  ->     "100,000"
 *  1000000  ->   "1,000,000"
 * 35235235  ->  "35,235,235"
 */

namespace CodewarsKatas._6_kyu.Grouped_by_commas
{
    public class GroupedByCommas
    {
        public static string GroupByCommas(int n)
        {
            string result = "";

            int count = 0;

            while (n > 0)
            {
                int digit = n % 10;

                result = digit.ToString() + result;

                count++;

                if (count == 3 && n / 10 > 0)
                {
                    result = "," + result;
                    count = 0;
                }
                n = n / 10;
                
            }

            return result;
        }
    }
}
