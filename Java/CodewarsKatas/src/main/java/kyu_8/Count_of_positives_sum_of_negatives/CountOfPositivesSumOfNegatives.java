/*
LINK: https://www.codewars.com/kata/576bb71bbbcf0951d5000044/train/java

Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second
element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
 */

package kyu_8.Count_of_positives_sum_of_negatives;

public class CountOfPositivesSumOfNegatives {
    public static int[] countPositivesSumNegatives(int[] input)
    {
        if (input == null || input.length == 0) {
            return new int[] {};
        }

        int countPositives = 0;
        int sumNegatives = 0;

        for (int i = 0; i < input.length; i++) {
            if (input[i] > 0) {
                countPositives++;
            }
            else if (input[i] < 0) {
                sumNegatives += input[i];
            }
        }

        return new int[] {countPositives, sumNegatives};
    }
}
