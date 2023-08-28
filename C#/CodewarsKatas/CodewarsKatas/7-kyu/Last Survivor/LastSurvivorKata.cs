/*
 * LINK: https://www.codewars.com/kata/609eee71109f860006c377d1/train/csharp
 * 
 * You are given a string of letters and an array of numbers.
 * The numbers indicate positions of letters that must be removed, in order, starting from the beginning of the array.
 * After each removal the size of the string decreases (there is no empty space).
 * Return the only letter left.
 * 
 * Example:
 * 
 * let str = "zbk", arr = [0, 1]
 *     str = "bk", arr = [1]
 *     str = "b", arr = []
 *     return 'b'
 * Notes
 * The given string will never be empty.
 * The length of the array is always one less than the length of the string.
 * All numbers are valid.
 * There can be duplicate letters and numbers.
 */

using System.Linq;

namespace CodewarsKatas._7_kyu.Last_Survivor
{
    public class LastSurvivorKata
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
            for (int i = 0; i < coords.Length; i++)
            {
                letters = letters.Remove(coords[i], 1);
            }

            return letters;
        } 
    }
}
