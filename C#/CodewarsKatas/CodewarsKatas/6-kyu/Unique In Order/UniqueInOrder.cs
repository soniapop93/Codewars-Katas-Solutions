/*
 * LINK: https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
 * 
 * Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value 
 * next to each other and preserving the original order of elements.
 * 
 * For example:
 * 
 * uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
 * uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
 * uniqueInOrder([1,2,2,3,3])       == {1,2,3}
 */

using System.Collections.Generic;
using System.Linq;

namespace CodewarsKatas._6_kyu.Unique_In_Order
{
    public class UniqueInOrder
    {
        public static IEnumerable<T> unique<T>(IEnumerable<T> iterable)
        {
            List<T> itemsResult = new List<T>();

            int index = 0;

            while (index < iterable.Count())
            {
                if (itemsResult.Count() == 0 || !iterable.ElementAt(index).Equals(itemsResult.Last()))
                {
                    itemsResult.Add(iterable.ElementAt(index));
                }
                index++;
            }

            return itemsResult;
        }
    }
}
