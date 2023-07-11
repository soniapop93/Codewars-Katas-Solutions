/*
 * LINK: https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/csharp
 * 
 * You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.
 *   
 *   Examples
 *   [2, 4, 0, 100, 4, 11, 2602, 36]
 *   Should return: 11 (the only odd number)
 *   
 *   [160, 3, 1719, 19, 11, 13, -21]
 *   Should return: 160 (the only even number)
 * 
 */

namespace CodewarsKatas._6_kyu.Find_The_Parity_Outlier
{
    public class FindTheParityOutlier
    {
        public static int Find(int[] integers)
        {
            int countOdd = 0;
            int countEven = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            if (countEven > countOdd)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 != 0)
                    {
                        return integers[i];
                    }
                }
            }
            else if (countOdd > countEven)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 0)
                    {
                        return integers[i];
                    }
                }
            }

            return -1;
        }
    }
}
