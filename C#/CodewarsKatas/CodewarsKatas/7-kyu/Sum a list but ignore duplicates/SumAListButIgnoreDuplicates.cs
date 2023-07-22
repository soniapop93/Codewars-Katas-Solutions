/*
 * LINK: https://www.codewars.com/kata/5993fb6c4f5d9f770c0000f2/train/csharp 
 * 
 * Please write a function that sums a list, but ignores any duplicate items in the list.
 * 
 * For instance, for the list [3, 4, 3, 6] , the function should return 10.
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Sum_a_list_but_ignore_duplicates
{
    public class SumAListButIgnoreDuplicates
    {
        public static int SumNoDuplicates(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i]) 
                    {
                        count++;
                    }
                }
                if (count < 2)
                {
                    sum += arr[i];
                } 
            }



            return sum;
        }
    }
}
