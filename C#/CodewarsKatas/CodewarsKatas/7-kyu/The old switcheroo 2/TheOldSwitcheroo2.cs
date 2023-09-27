/*
 * LINK: https://www.codewars.com/kata/55d6a0e4ededb894be000005/train/csharp
 * 
 *This is a follow up from my kata The old switcheroo
 * 
 * Write the function :
 * 
 * public static string Encode(string str)
 * that takes in a string str and replaces all the letters with their respective positions in the English alphabet.
 * 
 * Encode("abc") == "123" // a is 1st in English alpabet, b is 2nd and c is 3rd
 * Encode("codewars") == "315452311819"
 * Encode("abc-#@5") == "123-#@5"
 * String are case sensitive.

 * Bonus point if you don't use ToLower() 
 */

namespace CodewarsKatas._7_kyu.The_old_switcheroo_2
{
    public class TheOldSwitcheroo2
    {
        public static string Encode(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    int index = 1;
                    
                    for (int j = 65; j <= 90; j++)
                    {
                        if (str[i] == j)
                        {
                            result += index.ToString();
                            break;
                        }
                        index++;
                    }
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    int index = 1;

                    for (int j = 97; j <= 122; j++)
                    {
                        if (str[i] == j)
                        {
                            result += index.ToString();
                            break;
                        }
                        index++;
                    }
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
