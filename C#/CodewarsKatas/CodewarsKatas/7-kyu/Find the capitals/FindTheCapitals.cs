/*
 * LINK: https://www.codewars.com/kata/539ee3b6757843632d00026b/train/csharp
 * 
 * Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.
 * 
 * Example: "CodEWaRs" --> [0,3,4,6]
 * 
 */

namespace CodewarsKatas._7_kyu.Find_the_capitals
{
    public class FindTheCapitals
    {
        public static int[] Capitals(string word)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 65 && word[i] <= 90)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
    }
}
