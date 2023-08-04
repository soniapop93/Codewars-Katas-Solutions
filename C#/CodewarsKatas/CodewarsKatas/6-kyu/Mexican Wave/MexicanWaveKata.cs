/*
 * LINK: https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp
 * 
 * In this simple Kata your task is to create a function that turns a string into a Mexican Wave. 
 * You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 
 * 
 *  1.  The input string will always be lower case but maybe empty.
 *  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
 * 
 * Example:
 *      wave("hello") => {"Hello", "hEllo", "heLlo", "helLo", "hellO"}
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Mexican_Wave
{
    public class MexicanWaveKata
    {
        public static List<string> Wave(string str)
        {
            List<string> resultWave = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                string itemWave = "";

                bool shouldAdd = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (j == i)
                    {
                        if (str[j] >= 97 && str[j] <= 122)
                        {
                            itemWave += ((char)(str[j] - 32)).ToString();
                        }
                        else if (str[j].ToString().Equals(" "))
                        {
                            shouldAdd = false;
                            break;
                        } 
                    }
                    else
                    {
                        itemWave += str[j];
                    }
                }
                
                if (shouldAdd)
                {
                    resultWave.Add(itemWave);
                }
            }

            return resultWave;
        }
    }
}
