/*
 * LINK: https://www.codewars.com/kata/5503013e34137eeeaa001648/train/csharp
 * 
 * Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. 
 * Since James doesn't know how to make this happen, he needs your help.
 * 
 * Task
 * You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters. 
 * Trailing spaces should be removed, and every line must be terminated with a newline character (\n).
 * 
 * Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.
 * 
 * Examples
 * A size 3 diamond:
 * 
 *  *
 * ***
 *  *
 * ...which would appear as a string of " *\n***\n *\n"
 * 
 * A size 5 diamond:
 * 
 *   *
 *  ***
 * *****
 *  ***
 *   *
 * ...that is:
 * 
 * "  *\n ***\n*****\n ***\n  *\n"
 * 
 */

using System.Diagnostics;

namespace CodewarsKatas._6_kyu.Give_me_a_Diamond
{
    public class GiveMeADiamond
    {
        public static string print(int n)
        {
            string result = "";

            if (n % 2 == 0 || n < 0)
            {
                return null;
            }
            else
            {
                List<string> rows = new List<string>();

                for (int i = 1; i <= n; i += 2)
                {
                    string stars = generateStars(i);

                    string spacesStars = addSpaces(n - stars.Length);

                    rows.Add(spacesStars + stars);
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    result += rows[i] + "\n";
                }

                for (int i = rows.Count - 2; i >= 0; i--)
                {
                    result += rows[i] + "\n";
                }
            }
            return result;
        }

        private static string generateStars (int starsNr)
        {
            string stars = "";
            
            for (int i = 0; i < starsNr; i++)
            {
                stars += "*";
            }

            return stars;
        }

        private static string addSpaces(int stars)
        {
            string row = "";

            for (int i = 0; i < (stars / 2); i++)
            {
                row += " ";
            }

            return row;
        }
    }
}
