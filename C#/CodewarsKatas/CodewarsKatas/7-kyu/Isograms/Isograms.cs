/*
 * LINK: https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp
 * 
 * An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
 * 
 * Example: (Input --> Output)
 * 
 * "Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
 * 
 * isIsogram "Dermatoglyphics" = true
 * isIsogram "moose" = false
 * isIsogram "aba" = false
 * 
 */

namespace CodewarsKatas._7_kyu.Isograms
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            bool result = true;

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j].ToString().ToLower().Equals(str[i].ToString().ToLower()))
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
