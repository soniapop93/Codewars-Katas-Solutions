/*
 * LINK: https://www.codewars.com/kata/59c633e7dcc4053512000073/train/csharp
 * 
 * Given a lowercase string that has alphabetic characters only and no spaces, return the highest value of consonant substrings. Consonants are any letters of the alphabet except "aeiou".
 * 
 * We shall assign the following values: a = 1, b = 2, c = 3, .... z = 26.
 * 
 * For example, for the word "zodiacs", let's cross out the vowels. We get: "z o d ia cs"
 * 
 * -- The consonant substrings are: "z", "d" and "cs" and the values are z = 26, d = 4 and cs = 3 + 19 = 22. The highest is 26.
 * solve("zodiacs") = 26
 * 
 * For the word "strength", solve("strength") = 57
 * -- The consonant substrings are: "str" and "ngth" with values "
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Consonant_value
{
    public class ConsonantValue
    {
        public static int Solve(string s)
        {
            
            s = s.ToLower();
            int result = 0;
            List<string> vowels = new List<string>() { "a", "e", "i", "o", "u" };
            List<int> ints = new List<int>();
            List<string> consonantsString = new List<string>();

            string tempStr = "";
            for (int i = 0; i < s.Length; i++) 
            {
                if (!vowels.Contains(s[i].ToString()))
                {
                    tempStr += s[i];
                }
                else
                {
                    if(tempStr != "")
                    {
                        consonantsString.Add(tempStr);
                    }
                    tempStr = "";
                }
            }
            if (tempStr != "")
            {
                consonantsString.Add(tempStr);
            }


            for (int i = 0; i < consonantsString.Count; i++)
            {
                string item = consonantsString[i];
                int res = 0;
                for (int j = 0; j < item.Length; j++)
                {
                    int counter = 1;
                    for (int k = 97; k < 123; k++)
                    {
                        if (item[j].ToString() == ((char)k).ToString())
                        {
                            res += counter;
                            break;
                        }
                        counter++;
                    }
                }
                ints.Add(res);
            }

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] > result)
                {
                    result = ints[i];
                }
            }
            return result;
        }
    }
}
