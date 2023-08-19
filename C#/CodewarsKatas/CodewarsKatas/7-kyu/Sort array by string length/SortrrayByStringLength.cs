/*
 * LINK: https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c/train/csharp
 * 
 * Write a function that takes an array of strings as an argument and returns a sorted array containing the same strings, ordered from shortest to longest.
 * 
 * For example, if this array were passed as an argument:
 * 
 * ["Telescopes", "Glasses", "Eyes", "Monocles"]
 * 
 * Your function would return the following array:
 * 
 * ["Eyes", "Glasses", "Monocles", "Telescopes"]
 * 
 * All of the strings in the array passed to your function will be different lengths, 
 * so you will not have to decide how to order multiple strings of the same length.
 */

namespace CodewarsKatas._7_kyu.Sort_array_by_string_length
{
    public class SortrrayByStringLength
    {
        public static string[] SortByLength(string[] array)
        {
            List<string> sortedResult = new List<string>();

            SortedDictionary<int, string> items = new SortedDictionary<int, string>();

            for (int i = 0; i < array.Length; i++)
            {
                items[array[i].Length] = array[i];
            }

            foreach (KeyValuePair<int, string> item in items)
            {
                sortedResult.Add(item.Value);
            }

            return sortedResult.ToArray();
        }
    }
}
