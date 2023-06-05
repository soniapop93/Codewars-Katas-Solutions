/*
 * LINK: https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
 * 
 * Build a function that returns an array of integers from n to 1 where n>0.
 * 
 * Example : n=5 --> [5,4,3,2,1]
 */

using System.Collections.Generic;

namespace CodewarsKatas._8_kyu.Reversed_sequence
{
    public class ReversedSequence
    {
        public static int[] ReverseSeq(int n)
        {
            List<int> result = new List<int>();
            for (int i = n; i > 0; i--)
            {
                result.Add(i);
            }
            return result.ToArray();
        }
    }
}
