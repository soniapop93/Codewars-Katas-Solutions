/*
 * LINK: https://www.codewars.com/kata/526dbd6c8c0eb53254000110/train/csharp
 * 
 * In this example you have to validate if a user input string is alphanumeric. The given string is not nil/null/NULL/None, so you don't have to check that.
 * 
 * The string has the following conditions to be alphanumeric:
 * 
 *      At least one character ("" is not valid)
 *      Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
 *      No whitespaces / underscore
 */

namespace CodewarsKatas._5_kyu.Not_very_secure
{
    public class NotVerySecure
    {
        public static bool Alphanumeric(string str)
        {
            bool isAlphanumeric = false;
            if (!str.Equals(""))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= 48 && str[i] <= 57) || (str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                    {
                        isAlphanumeric = true;
                    }
                    else
                    {
                        isAlphanumeric = false;
                        break;
                    }
                }
            }
            return isAlphanumeric;
        }
    }
}
