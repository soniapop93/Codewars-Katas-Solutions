/*
 * LINK: https://www.codewars.com/kata/602db3215c22df000e8544f0/train/csharp
 * 
 * Your job is to write a function, which takes three integers a, b, and c as arguments, and returns 
 * True if exactly two of of the three integers are positive numbers (greater than zero), and False - otherwise.
 */

namespace CodewarsKatas._7_kyu.Two_numbers_are_positive
{
    public class TwoNumbersArePositive
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            int count = 0;

            if (a > 0)
            {
                count++;
            }
            if (b > 0)
            {
                count++;                
            }
            if (c > 0)
            {
                count++;
            }

            if (count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
