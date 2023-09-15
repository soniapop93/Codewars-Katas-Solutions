/*
 * LINK: https://www.codewars.com/kata/5168b125faced29f66000005/train/csharp
 * 
 * Complete the solution so that it returns the number of times the search_text is found within the full_text. Overlap is not permitted : "aaa" contains 1 instance of "aa", not 2.
 * 
 * Usage example:
 * 
 * full_text = "aa_bb_cc_dd_bb_e", search_text = "bb"
 *     ---> should return 2 since "bb" shows up twice
 * 
 * 
 * full_text = "aaabbbcccc", search_text = "bbb"
 *     ---> should return 1
 */

namespace CodewarsKatas._7_kyu.Return_Substring_Instance_Count
{
    public class ReturnSubstringInstanceCount
    {
        public static int SubstringCount(string fullText, string searchText)
        {
            int count = 0;

            int index = fullText.IndexOf(searchText, 0);

            while (index != -1)
            {
                index = fullText.IndexOf(searchText, index + searchText.Length);
                count++;
            }

            return count;
        }
    }
}
