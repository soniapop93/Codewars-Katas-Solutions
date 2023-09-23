/*
 * LINK: https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp
 * 
 * How can you tell an extrovert from an introvert at NSA?
 * Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
 * 
 * I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it?
 * According to Wikipedia, ROT13 is frequently used to obfuscate jokes on USENET.
 * 
 * For this task you're only supposed to substitute characters. Not spaces, punctuation, numbers, etc.
 * 
 * Test examples:
 * 
 * "EBG13 rknzcyr." -> "ROT13 example."
 * 
 * "This is my first ROT13 excercise!" -> "Guvf vf zl svefg EBG13 rkprepvfr!"
 * 
 */

namespace CodewarsKatas._5_kyu.ROT13
{
    public class Rot13
    {
        public static string rot13(string input)
        {
            string newStr = "";

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                {
                    int charI = input[i] + 13;

                    int newChar = 0;

                    if (charI > 90 && input[i] <= 90)
                    {
                        int currentItem = Math.Abs(90 - charI);

                        newChar = 65 + currentItem - 1;
                    }
                    else if (charI > 122)
                    {
                        int currentItem = Math.Abs(122 - charI);

                        newChar = 97 + currentItem - 1;
                    }
                    else
                    {
                        newChar = charI;
                    }

                    newStr += ((char)newChar).ToString();
                }
                else
                {
                    newStr += input[i].ToString();
                }
            }

            return newStr;
        }
    }
}
