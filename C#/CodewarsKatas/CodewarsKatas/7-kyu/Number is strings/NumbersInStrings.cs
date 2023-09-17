/*
 * LINK: https://www.codewars.com/kata/59dd2c38f703c4ae5e000014/train/csharp
 * 
 * In this Kata, you will be given a string that has lowercase letters and numbers. Your task is to compare the number groupings and return the largest number. Numbers will not have leading zeros.
 * 
 * For example, solve("gh12cdy695m1") = 695, because this is the largest of all number groupings
 */

using System.Collections.Generic;

namespace CodewarsKatas._7_kyu.Number_is_strings
{
    public class NumbersInStrings
    {
        public static int Solve(string s)
        {
            List<string> numbersList = new List<string>();
            string number = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    number += s[i].ToString();
                }
                else
                {
                    if (!number.Equals(""))
                    {
                        numbersList.Add(number);
                    }
                    number = "";
                }
            }

            if (!number.Equals(""))
            {
                numbersList.Add(number);
            }

            int result = 0;

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (Int32.Parse(numbersList[i]) > result)
                {
                    result = Int32.Parse(numbersList[i]);
                }
            }

            return result;
        }

    }
}
