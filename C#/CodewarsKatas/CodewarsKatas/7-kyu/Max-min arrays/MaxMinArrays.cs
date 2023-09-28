/*
 * LINK: https://www.codewars.com/kata/5a090c4e697598d0b9000004/train/csharp
 * 
 * In this Kata, you will be given an array of unique elements, and your task is to rearrange the values so that the 
 * first max value is followed by the first minimum, followed by second max value then second min value, etc.
 * 
 * For example:
 * 
 * Kata.Solve(new List<int> {15,11,10,7,12}) => new List<int> {15,7,12,10,11}
 * The first max is 15 and the first min is 7. The second max is 12 and the second min is 10 and so on.
 * 
 */

namespace CodewarsKatas._7_kyu.Max_min_arrays
{
    public class MaxMinArrays
    {
        public static List<int> Solve(List<int> arr)
        {
            List<int> result = new List<int>();

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            while (result.Count != arr.Count)
            {
                int tempMaxValue = int.MinValue;
                int tempMinValue = int.MaxValue;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > tempMaxValue && !result.Contains(arr[i]))
                    {
                        tempMaxValue = arr[i];
                    }

                    if (arr[i] < tempMinValue && !result.Contains(arr[i]))
                    {
                        tempMinValue = arr[i];
                    }
                }

                maxValue = tempMaxValue;
                minValue = tempMinValue;

                if (!result.Contains(maxValue))
                {
                    result.Add(maxValue);
                }
                if (!result.Contains(minValue))
                {
                    result.Add(minValue);
                }
            }

            return result;
        }
    }
}
