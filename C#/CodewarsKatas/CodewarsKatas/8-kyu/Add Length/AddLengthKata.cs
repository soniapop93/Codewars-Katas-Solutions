/*
 * LINK: https://www.codewars.com/kata/559d2284b5bb6799e9000047/train/csharp
 * 
 * What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?
 * 
 * Example(Input --> Output)
 * 
 * "apple ban" --> ["apple 5", "ban 3"]
 * "you will win" -->["you 3", "will 4", "win 3"]
 * Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .
 * 
 * Note: String will have at least one element; words will always be separated by a space.
 */

using System.Collections.Generic;
using System;

namespace CodewarsKatas._8_kyu.Add_Length
{
    public class AddLengthKata
    {
        public static string[] AddLength(string str)
        {
            string[] strArr = str.Split(" ");
            List<string> finalList = new List<string>();

            for (int i = 0; i < strArr.Length; i++)
            {
                finalList.Add(String.Format("{0} {1}", strArr[i], strArr[i].Length));
            }
            return finalList.ToArray();
        }
    }
}
