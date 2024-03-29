﻿/*
 * LINK: https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp
 * 
 * We need to sum big numbers and we require your help.
 * 
 * Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.
 * 
 * Example
 * add("123", "321"); -> "444"
 * add("11", "99");   -> "110"
 * Notes
 * The input numbers are big.
 * The input is a string of only digits
 * The numbers are positives.
 */

using System.Numerics;

namespace CodewarsKatas._4_kyu.Sum_Strings_as_Numbers
{
    public class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
