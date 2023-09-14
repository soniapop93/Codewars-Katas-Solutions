/*
 * LINK: https://www.codewars.com/kata/59d398bb86a6fdf100000031/train/csharp
 * 
 * I will give you an integer (N) and a string. Break the string up into as many substrings of N as you can without spaces. If there are leftover characters, include those as well.
 * 
 * Example: 
 * 
 * n = 5;
 * 
 * str = "This is an example string";
 * 
 * Return value:
 * Thisi
 * sanex
 * ample
 * strin
 * g
 * 
 * Return value as a string: "Thisi"+"\n"+"sanex"+"\n"+"ample"+"\n"+"strin"+"\n"+"g"
 */
namespace CodewarsKatas._6_kyu.String_Breakers
{
    public class StringBreakersKata
    {
        public static string StringBreakers(int n, string str)
        {
            string result = "";

            str = str.Replace(" ", "");

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count++;
                result += str[i];

                if (count == n)
                {
                    result += "\n";
                    count = 0;
                }
            }

            if ((result.Substring(result.Length - 1)).Equals("\n"))
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
    }
}
