/*
 * LINK: https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b/train/csharp
 * 
 * In this kata you will create a function that takes in a list and returns a list with the reverse order.
 * 
 * Examples (Input -> Output)
 *      [1, 2, 3, 4]  -> [4, 3, 2, 1]
 *      [9, 2, 0, 7]  -> [7, 0, 2, 9]
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Reverse_List_Order
{
    public class ReverseListOrder
    {
        public static List<int> ReverseList(List<int> list)
        {
            List<int> newList = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
    }
}
