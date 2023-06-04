/*
 * LINK: https://www.codewars.com/kata/5ba38ba180824a86850000f7/train/csharp
 * 
 * Remove the duplicates from a list of integers, keeping the last ( rightmost ) occurrence of each element.

*  Example:
*       For input: [3, 4, 4, 3, 6, 3]
*       
*       remove the 3 at index 0
*       remove the 4 at index 1
*       remove the 3 at index 3
*       Expected output: [4, 6, 3]
*  
*  More examples can be found in the test cases.
*  
*  Good luck!
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Simple_remove_duplicates
{
    public class SimpleRemoveDuplicates
    {
        public static int[] solve(int[] arr)
        {
            List<int> arrAfterRemovingDuplicates = new List<int>();


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (!arrAfterRemovingDuplicates.Contains(arr[i]))
                {
                    arrAfterRemovingDuplicates.Add(arr[i]);
                }
            }

            List<int> result = new List<int>();
            for (int j = arrAfterRemovingDuplicates.Count - 1; j >= 0; j--)
            {
                result.Add(arrAfterRemovingDuplicates[j]);
            }

            return result.ToArray();
        }
    }
}
