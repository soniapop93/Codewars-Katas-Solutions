/*
 * LINK: https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/train/csharp
 * 
 * This time no story, no theory. The examples below show you how to write function accum:
 * 
 * Examples:
 *      accum("abcd") -> "A-Bb-Ccc-Dddd"
 *      accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
 *      accum("cwAt") -> "C-Ww-Aaa-Tttt"
 *      
 * The parameter of accum is a string which includes only letters from a..z and A..Z.
 */     
        
namespace CodewarsKatas._7_kyu.Mumbling
{
    public class Mumbling
    {
        public static String Accum(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                string item = "";

                for (int j = 1; j <= i + 1; j++)
                {
                    if (j == 1)
                    {
                        item = item + s[i].ToString().ToUpper();
                    }
                    else
                    {
                        item = item + s[i].ToString().ToLower();
                    }
                }
                result = result + item + "-";
            }
            return result.Remove(result.Length - 1, 1);
        }
    }
}
