/*
 * LINK: https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/train/csharp
 * 
 * Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
 * 
 * Examples
 * "This is an example!" ==> "sihT si na !elpmaxe"
 * "double  spaces"      ==> "elbuod  secaps"
 */

namespace CodewarsKatas._7_kyu.Reverse_Words
{
    public class ReverseWordsKata
    {
        public static string ReverseWords(string str)
        {
            string result = "";

            string[] splittedStr = str.Split(" ");

            for (int i = 0; i < splittedStr.Length; i++)
            {
                string temp = "";

                for (int j = splittedStr[i].Length - 1; j >= 0; j-- )
                {
                    temp += splittedStr[i][j];
                }

                result += temp + " ";
            }

            return result.Substring(0, result.Length - 1);
        }
    }
}
