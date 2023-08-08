/*
 * LINK: https://www.codewars.com/kata/563cf89eb4747c5fb100001b/train/csharp
 * 
 * Given an array of integers, remove the smallest value. Do not mutate the original array/list.
 * If there are multiple elements with the same value, remove the one with a lower index. 
 * If you get an empty array/list, return an empty array/list.
 * 
 * Don't change the order of the elements that are left.
 * 
 * Examples
    * Input: [1,2,3,4,5], output = [2,3,4,5]
    * Input: [5,3,2,1,4], output = [5,3,2,4]
    * Input: [2,2,1,2,1], output = [2,2,2,1]
 */

namespace CodewarsKatas._7_kyu.Remove_the_minimum
{
    public class RemoveTheMinimum
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> result = new List<int>();

            int lowest = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            bool identified = false;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == lowest && !identified)
                {
                    identified = true;
                    continue;
                }
                result.Add(numbers[i]);
            }

            return result;
        }
    }
}
