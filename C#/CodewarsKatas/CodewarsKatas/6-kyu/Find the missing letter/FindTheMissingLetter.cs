/*
 * LINK: https://www.codewars.com/kata/5839edaa6754d6fec10000a2/train/csharp
 * 
 * Write a method that takes an array of consecutive (increasing) letters as input and that returns the 
 * missing letter in the array.
 * 
 * You will always get an valid array. And it will be always exactly one letter be missing. 
 * The length of the array will always be at least 2.
 * The array will always contain letters in only one case.
 * 
 * Example:
 * 
 * ['a','b','c','d','f'] -> 'e'
 * ['O','Q','R','S'] -> 'P'
 * 
 */
using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Find_the_missing_letter
{
    public class FindTheMissingLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            string missingLetter = "";

            List<char> letters = new List<char>();

            int indexOfFirstLetter = 0;
            
            if (array[0] >= 65 && array[0] <= 90)
            {
                int count = 0;

                for (int j = 65; j <= 90; j++)
                {
                    letters.Add((char)j);

                    if (array[0] == j)
                    {
                        indexOfFirstLetter = count;
                    }
                    count++;
                }
            }
            else if (array[0] >= 97 && array[0] <= 122)
            {
                int count = 0;

                for (int j = 97; j <= 122; j++)
                {
                    letters.Add((char)j);

                    if (array[0] == j)
                    {
                        indexOfFirstLetter = count;
                    }
                    count++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != letters[indexOfFirstLetter + i])
                {
                    missingLetter = (letters[indexOfFirstLetter + i]).ToString();

                    break;
                }
            }
            
            return missingLetter[0];
        }
    }
}
