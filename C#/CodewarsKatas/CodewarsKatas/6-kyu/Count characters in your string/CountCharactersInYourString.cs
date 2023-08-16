/*
 * LINK: https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp
 * 
 * The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
 * 
 * What if the string is empty? Then the result should be empty object literal, {}.
 * 
 */


namespace CodewarsKatas._6_kyu.Count_characters_in_your_string
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (result.ContainsKey(str[i]))
                {
                    result[str[i]] = result[str[i]] + 1;
                }
                else
                {
                    result[str[i]] = 1;
                }
            }

            return result;
        }
    }
}
