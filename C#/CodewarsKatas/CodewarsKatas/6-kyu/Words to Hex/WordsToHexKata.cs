/*
 * LINK: https://www.codewars.com/kata/596e91b48c92ceff0c00001f/train/csharp
 * 
 * Gary likes pictures but he also likes words and reading. He has had a desire for a long time to see what words and 
 * books would look like if they could be seen as images.
 * 
 * For this task you are required to take a continuous string that can consist of any combination of words or characters 
 * and then convert the words that make up this string into hexadecimal values that could then be read as colour values.
 * 
 * A word is defined as a sequence of ASCII characters between two white space characters or the first or last word of a sequence of words.
 * 
 * Each word will represent a hexadecimal value by taking the first three letters of each word and find the ASCII character code 
 * for each character. This will then give you one hexadecimal value that represents the colours red, green or blue. 
 * You will then combine these values into one readable RGB hexadecimal value, e.g. #ffffff.
 * 
 * If your word consists of less than 3 letters, you should use the hexidecimal value 00, ie "It" would return a value #497400.
 * 
 * Your answer should be an array of hexadecimal values that correspond to each word that made up your original string.
 * 
 * Example
 * The following string would be given:
 * 
 *      "Hello, my name is Gary and I like cheese."
 * 
 * This string would return the following array:
 * 
 *      ['#48656c', '#6d7900', '#6e616d','#697300','#476172','#616e64','#490000','#6c696b','#636865']
 * 
 */

using Microsoft.VisualBasic;

namespace CodewarsKatas._6_kyu.Words_to_Hex
{
    public class WordsToHexKata
    {
        public static string[] WordsToHex(string words)
        {
            List<string> finalList = new List<string>();

            if (!words.Contains(" "))
            {
                string newHex = "#";

                for (int j = 0; j < words.Length; j++)
                {
                    newHex += Conversion.Hex(Convert.ToByte(words[j]));
                    finalList.Add(newHex);
                }
                return finalList.ToArray();
            }


            string[] splittedWords = words.Split(" ");

            for (int i = 0; i < splittedWords.Length; i++)
            {
                string newHex = "#";

                for (int j = 0; j < splittedWords[i].Length; j++)
                {
                    newHex += Conversion.Hex(Convert.ToByte(splittedWords[i][j]));
                    finalList.Add(newHex);
                }
            }
            return finalList.ToArray();
        }
    }
}
