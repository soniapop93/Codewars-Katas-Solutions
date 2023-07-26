/*
 * LINK: https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118/train/csharp
 * 
 * Define a function that removes duplicates from an array of non negative numbers and returns it as a result.
 * 
 * The order of the sequence has to stay the same.
 */

using System.Collections.Generic;

namespace CodewarsKatas._8_kyu.Remove_duplicates_from_list
{
    public class RemoveDuplicatesFromList
    {
        public static int[] distinct(int[] a)
        {
            List<int> sorted = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!sorted.Contains(a[i]))
                {
                    sorted.Add(a[i]);
                }
            }

            return sorted.ToArray();
        }
    }
}
