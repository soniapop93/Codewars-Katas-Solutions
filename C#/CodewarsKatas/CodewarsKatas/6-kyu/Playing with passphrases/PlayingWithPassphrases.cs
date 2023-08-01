/*
 * LINK: https://www.codewars.com/kata/559536379512a64472000053/train/csharp
 * 
 * Everyone knows passphrases. One can choose passphrases from poems, songs, movies names and so on 
 * but frequently they can be guessed due to common cultural references. 
 * You can get your passphrases stronger by different means. One is the following:
 *  
 * choose a text in capital letters including or not digits and non alphabetic characters,
 * 
 * shift each letter by a given number but the transformed letter must be a letter (circular shift),
 * replace each digit by its complement to 9,
 * keep such as non alphabetic and non digit characters,
 * downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
 * reverse the whole result.
 * 
 * Example:
 *      your text: "BORN IN 2015!", shift 1
 * 
 *      1 + 2 + 3 -> "CPSO JO 7984!"
 * 
 *      4 "CpSo jO 7984!"
 * 
 *      5 "!4897 Oj oSpC"
 */

namespace CodewarsKatas._6_kyu.Playing_with_passphrases
{
    public class PlayingWithPassphrases
    {
        public static string playPass(string s, int n)
        {
            string result = "";

            string tempString = "";

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 65 && s[i] <= 90) ||
                    (s[i] >= 97 && s[i] <= 122))
                {
                    if (((s[i] + n) > 90) && (s[i] < 97) ||
                       ((s[i] + n) > 122))
                    {
                        tempString += ((char)((s[i] - 26) + n)).ToString();
                    }
                    else
                    {
                        tempString += ((char)(s[i] + n)).ToString();
                    }

                }
                else if (s[i] >= 48 && s[i] <= 57)
                {
                    tempString += (9 - Int32.Parse(s[i].ToString()));
                }
                else
                {
                    tempString += s[i];
                }
            }

            string replaceLettersTempString = "";

            for (int i = 0; i < tempString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (tempString[i] >= 97 && tempString[i] <= 122)
                    {
                        replaceLettersTempString += ((char)(tempString[i] - 32)).ToString();
                    }
                    else
                    {
                        replaceLettersTempString += tempString[i];
                    }
                }
                else
                {
                    if (tempString[i] >= 65 && tempString[i] <= 90)
                    {
                        replaceLettersTempString += ((char)(tempString[i] + 32)).ToString();
                    }
                    else
                    {
                        replaceLettersTempString += tempString[i];
                    }
                }
            }

            for (int i = replaceLettersTempString.Length - 1; i >= 0; i--)
            {
                result += replaceLettersTempString[i];
            }

            return result;
        }
    }
}
