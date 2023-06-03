/*
 * LINK: https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp
 * 
 * Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.
 * 
 * Write a function which takes a list of strings and returns each line prepended by the correct number.
 * 
 * The numbering starts at 1. The format is n: string. Notice the colon and space in between.
 * 
 * Examples: (Input --> Output)
 *      [] --> []
 *      ["a", "b", "c"] --> ["1: a", "2: b", "3: c"]
 */

namespace CodewarsKatas._7_kyu.Testing_1_2_3
{
    public class Testing1_2_3
    {
        public static List<string> Number(List<string> lines)
        {
            List<string> newLines = new List<string>();

            for (int i = 0; i < lines.Count(); i++)
            {
                string str = (i + 1).ToString() + ": " + lines[i];
                newLines.Add(str);
            }
            return newLines;
        }
    }
}
