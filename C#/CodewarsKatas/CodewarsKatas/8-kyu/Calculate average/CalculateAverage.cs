/*
 * LINK: https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/csharp
 * 
 * Write a function which calculates the average of the numbers in a given list.
 * 
 * Note: Empty arrays should return 0.
 */

namespace CodewarsKatas._8_kyu.Calculate_average
{
    public class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            double sum = 0;

            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
            }
            else
            {
                return 0;
            }
            return sum / array.Length;
        }
    }
}
