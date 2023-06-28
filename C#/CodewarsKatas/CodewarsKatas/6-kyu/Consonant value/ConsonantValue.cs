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

namespace CodewarsKatas._6_kyu.Consonant_value
{
    public class ConsonantValue
    {
        public static int Solve(string s)
        {
            int result = 0;
            List<string> vowels = new List<string>() { "a", "e", "i", "o", "u" };
            List<int> ints = new List<int>();
            List<string> consonantsString = new List<string>();

            for (int i = 0; i < s.Length; i++) 
            {
                if (!vowels.Contains(s[i].ToString()))
                {
                    consonantsString.Add(s[i].ToString());
                }
            }



            for (int i = 0; i < consonantsString.Count; i++)
            {
                int counter = 1;
                for (int j = 97; j < 123; j++)
                {
                    if (consonantsString[i] == ((char)j).ToString())
                    {
                        ints.Add(counter);
                        break;
                    }
                    counter++;
                }
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
