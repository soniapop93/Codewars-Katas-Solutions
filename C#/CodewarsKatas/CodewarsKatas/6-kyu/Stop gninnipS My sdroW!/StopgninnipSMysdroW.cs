/*
 * LINK: https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
 * 
 * Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed 
 * (Just like the name of this Kata). 
 * Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
 * Examples:
 * 
 *  spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
 *  spinWords( "This is a test") => returns "This is a test" 
 *  spinWords( "This is another test" )=> returns "This is rehtona test"
 * 
 */

namespace CodewarsKatas._6_kyu.Stop_gninnipS_My_sdroW_
{
    public class StopgninnipSMysdroW
    {
        public static string spinWords(string sentence)
        {
            string[] splitedSentence = sentence.Split(" ");
            string newSentence = "";

            for (int i = 0; i < splitedSentence.Length; i++)
            {
                if(splitedSentence[i].Length >= 5)
                {
                    string newStr = "";
                    for (int j = splitedSentence[i].Length - 1; j >= 0; j--)
                    {
                        newStr = newStr + splitedSentence[i][j];
                    }
                    newSentence = newSentence + newStr + " ";
                }
                else
                {
                    newSentence = newSentence + splitedSentence[i] + " ";
                }
            }

            return newSentence.Remove(newSentence.Length - 1, 1);
        }
    }
}
