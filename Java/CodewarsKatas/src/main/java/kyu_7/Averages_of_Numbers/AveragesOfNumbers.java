/*
LINK: https://www.codewars.com/kata/57d2807295497e652b000139/train/java

Write a method, that gets an array of integer-numbers and return an array of the averages of each integer-number
and his follower, if there is one.

Example:

Input:  [ 1, 3, 5, 1, -10]
Output:  [ 2, 4, 3, -4.5]
If the array has 0 or 1 values or is null, your method should return an empty array.
 */

package kyu_7.Averages_of_Numbers;

public class AveragesOfNumbers {
    public static double[] averages(int[] numbers)
    {
        if (numbers == null || numbers.length <= 1) {
            return new double[0];
        }

        double[] result = new double[numbers.length - 1];

        for (int i = 0; i < numbers.length - 1; i++) {
            result[i] = (double)(numbers[i] + numbers[i + 1]) / 2;
        }

        return result;
    }
}
