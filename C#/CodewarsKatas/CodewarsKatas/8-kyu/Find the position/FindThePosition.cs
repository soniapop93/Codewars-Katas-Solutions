/*
 * LINK: https://www.codewars.com/kata/5808e2006b65bff35500008f/train/csharp
 * 
 * When provided with a letter, return its position in the alphabet.
 * 
 * Input :: "a"
 * 
 * Ouput :: "Position of alphabet: 1"
 */

namespace CodewarsKatas._8_kyu.NewFolder
{
    public class FindThePosition
    {
        public static string Position(char alphabet)
        {
            int count = 0;

            for (int i = 97; i < 123; i++)
            {
                count++;
                if (i == alphabet)
                {
                    break;
                }
            }

            return "Position of alphabet: " + count.ToString();
        }
    }
}
