/*
 * LINK: https://www.codewars.com/kata/5596f6e9529e9ab6fb000014/train/csharp
 *
 * Write a function that receives two strings and returns n, where n is equal to the number of characters we should shift the first string forward to match the second. 
 * The check should be case sensitive.
 *
 * For instance, take the strings "fatigue" and "tiguefa". 
 * In this case, the first string has been rotated 5 characters forward to produce the second string, so 5 would be returned.
 *
 * If the second string isn't a valid rotation of the first string, the method returns -1.
 * Examples:
 *   "coffee", "eecoff" => 2
 *   "eecoff", "coffee" => 4
 *   "moose", "Moose" => -1
 *   "isn't", "'tisn" => 2
 *   "Esham", "Esham" => 0
 *   "dog", "god" => -1
 */

namespace CodewarsKatas._6_kyu.Calculate_String_Rotation
{
    public class CalculateStringRotation
    {
        public static int ShiftedDiff(string first, string second)
        {
            int count = 0;

            string tempFirst = first;

            while (!tempFirst.Equals(second) && count < tempFirst.Length)
            {
                tempFirst = tempFirst[tempFirst.Length - 1] + tempFirst.Substring(0, tempFirst.Length - 1);
                count++;
            }

            if (count == tempFirst.Length)
            {
                count = -1;
            }

            return count;
        }
    }
}
