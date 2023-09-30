/*
 * LINK: https://www.codewars.com/kata/5a71939d373c2e634200008e/train/csharp
 * 
 * In this Kata, we are going to reverse a string while maintaining the spaces (if any) in their original place.
 * 
 * For example:
 * 
 * solve("our code") = "edo cruo"
 * -- Normal reversal without spaces is "edocruo". 
 * -- However, there is a space at index 3, so the string becomes "edo cruo"
 * 
 * solve("your code rocks") = "skco redo cruoy". 
 * solve("codewars") = "srawedoc"
 */

using System.Linq;

namespace CodewarsKatas._7_kyu.Simple_string_reversal
{
    public class SimpleStringReversal
    {
        public static String solve(String s)
        {
            String result = "";

            if (s.Contains(" "))
            {
                List<int> spaceIndexes = new List<int>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 32) // 32 is space in ASCII
                    {
                        spaceIndexes.Add(i);
                    }
                }

                s = s.Replace(" ", "");

                s = String.Join("", (s.ToArray().Reverse()));

                int spaceIndex = 0;

                int index = 0;

                for (int j = 0; j < spaceIndexes.Count; j++)
                {
                    for (int i = 0; i < spaceIndexes[j] - spaceIndex; i++)
                    {
                        result += s[index];
                        index++;
                    }

                    result += " ";

                    spaceIndex = spaceIndexes[j];
                }

                result += s.Substring(spaceIndex, s.Length);
            }
            else
            {
                result = String.Join("", (s.ToArray().Reverse()));
            }

            return result;
        }
    }
}
