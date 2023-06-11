/*
 * LINK: https://www.codewars.com/kata/563089b9b7be03472d00002b/train/csharp
 * 
 * Define a method/function that removes from a given array of integers all the values contained in a second array.
 * 
 * Examples (input -> output):
 *      [1, 1, 2, 3, 1, 2, 3, 4], [1, 3] -> [2, 2, 4]
 *      [1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8], [1, 3, 4, 2] -> [5, 6, 7, 8]
 *      [8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3], [2, 4, 3] -> [8, 7, 6, 5, 1]
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Remove_All_The_Marked_Elements_of_a_List
{
    public class RemoveElementsList
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < integerList.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < valuesList.Length; j++)
                {
                    if (integerList[i] == valuesList[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    newList.Add(integerList[i]);
            }

            return newList.ToArray();
        }
    }
}
