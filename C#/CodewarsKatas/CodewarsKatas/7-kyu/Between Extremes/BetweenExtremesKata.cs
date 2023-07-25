﻿/*
 * LINK: https://www.codewars.com/kata/56d19b2ac05aed1a20000430/train/csharp
 * 
 * Given an array of numbers, return the difference between the largest and smallest values.
 * 
 * For example:
 * 
 * [23, 3, 19, 21, 16] should return 20 (i.e., 23 - 3).
 * 
 * [1, 434, 555, 34, 112] should return 554 (i.e., 555 - 1).
 * 
 * The array will contain a minimum of two elements. Input data range guarantees that max-min will cause no integer overflow.
 */

namespace CodewarsKatas._7_kyu.Between_Extremes
{
    public class BetweenExtremesKata
    {
        public static int BetweenExtremes(int[] numbers)
        {
            int largestValue = int.MinValue;
            int smallestValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largestValue)
                {
                    largestValue = numbers[i];
                }
                if (numbers[i] < smallestValue)
                {
                    smallestValue = numbers[i];
                }
            }

            return largestValue - smallestValue;
        }
    }
}
