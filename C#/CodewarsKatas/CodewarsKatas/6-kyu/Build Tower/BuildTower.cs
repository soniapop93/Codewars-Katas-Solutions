/*
 * LINK: https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/csharp
 * 
 * Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. 
 * A tower block is represented with "*" character.
 * 
 * For example, a tower with 3 floors looks like this:
 * 
 * [
 *   "  *  ",
 *   " *** ", 
 *   "*****"
 * ]
 * And a tower with 6 floors looks like this:
 * 
 * [
 *   "     *     ", 
 *   "    ***    ", 
 *   "   *****   ", 
 *   "  *******  ", 
 *   " ********* ", 
 *   "***********"
 * ]
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._6_kyu.Build_Tower
{
    public class BuildTower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            List<string> result = new List<string>();

            int n = (nFloors * 2) - 1;

            for (int i = 1; i <= n; i+= 2) 
            {
                string stars = generateStars(i);
                string spacesStars = addSpaces(n - stars.Length);
                result.Add(spacesStars + stars);
            }

            return result.ToArray();
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

        private static string generateStars(int starsNr)
        {
            string stars = "";

            for (int i = 0; i < starsNr; i++)
            {
                stars += "*";
            }

            return stars;
        }
    }
}
