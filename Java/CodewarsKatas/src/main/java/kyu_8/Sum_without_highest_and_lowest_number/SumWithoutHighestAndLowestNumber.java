/*
LINK: https://www.codewars.com/kata/576b93db1129fcf2200001e6/train/java

Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element (by value, not by index!).

The highest or lowest element respectively is a single element at each edge, even if there are more than one with
the same value.

Mind the input validation.

Example
{ 6, 2, 1, 8, 10 } => 16
{ 1, 1, 11, 2, 3 } => 6
Input validation
If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a
list with only 1 element, return 0.
 */

package kyu_8.Sum_without_highest_and_lowest_number;

public class SumWithoutHighestAndLowestNumber {
    public static int sum(int[] numbers)
    {
        if (numbers == null || numbers.length <= 1) {
            return 0;
        }

        int lowerValue = Integer.MAX_VALUE;
        int highestValue = Integer.MIN_VALUE;

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] > highestValue) {
                highestValue = numbers[i];
            }
            if (numbers[i] < lowerValue) {
                lowerValue = numbers[i];
            }
        }

        int sum = 0;
        boolean lowerValueChecked = false;
        boolean highestValueChecked = false;

        for (int i = 0; i < numbers.length; i++) {
            if ((numbers[i] == lowerValue) && (lowerValueChecked != true)) {
                lowerValueChecked = true;
                continue;
            }
            else if ((numbers[i] == highestValue) && (highestValueChecked != true)) {
                highestValueChecked = true;
                continue;
            }
            sum += numbers[i];
        }

        return sum;
    }
}
