/*
 * LINK: https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp
 * 
 * Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.
 * 
 * For example:
 * 
 * SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
 * SortNumbers(null); // should return new int[] { }
 */

using System.Runtime.Serialization;

namespace CodewarsKatas._7_kyu.Sort_Numbers
{
    public class SortNumbersKata
    {
        public static int[] SortNumbers(int[] nums)
        {
            bool sorted = true;

            if (nums == null)
            {
                nums = new int[] { };
            }

            else if (nums.Length > 0)
            {
                do
                {
                    sorted = true;

                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        if (nums[i] > nums[i + 1])
                        {
                            int aux = nums[i];

                            nums[i] = nums[i + 1];
                            nums[i + 1] = aux;
                            sorted = false;
                            break;
                        }
                        else if (nums[i] < nums[i + 1])
                        {
                            continue;
                        }
                    }
                } while (!sorted);
            }
           
            return nums;
        }
    }
}
