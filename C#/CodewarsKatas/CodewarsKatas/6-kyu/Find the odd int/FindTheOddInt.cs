/*
 * LINK: https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
 * 
 * Given an array of integers, find the one that appears an odd number of times.
 * 
 * There will always be only one integer that appears an odd number of times.
 * 
 * Examples
 *      [7] should return 7, because it occurs 1 time (which is odd).
 *      [0] should return 0, because it occurs 1 time (which is odd).
 *      [1,1,2] should return 2, because it occurs 1 time (which is odd).
 *      [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
 *      [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
 * 
 */

namespace CodewarsKatas._6_kyu.Find_the_odd_int
{
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {

            for (int i = 0; i < seq.Length; i++)
            {
                int oddNr = 0;

                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[j] == seq[i])
                    {
                        oddNr++;
                    }
                }

                if (oddNr % 2 != 0)
                {
                    return seq[i];
                }
            }

            return -1;
        }
    }
}
