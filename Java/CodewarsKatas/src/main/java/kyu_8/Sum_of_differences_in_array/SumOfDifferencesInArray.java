/*
LINK: https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e/train/java

Your task is to sum the differences between consecutive pairs in the array in descending order.

Example
[2, 1, 10]  -->  9
In descending order: [10, 2, 1]

Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

If the array is empty or the array has only one element the result should be 0.
 */

package kyu_8.Sum_of_differences_in_array;

import java.util.Arrays;

public class SumOfDifferencesInArray {
    public static int sumOfDifferences(int[] arr) {
        if (arr.length == 0) {
            return 0;
        }

        int result = 0;
        Arrays.sort(arr);

        int countItems = 0;

        for (int i = 0; i < arr.length - 1; i++) {
            if (arr[i] == arr[i + 1]) {
                countItems++;
            }

            result += (arr[i] - arr[i + 1]);
        }

        if (countItems == arr.length) {
            return 0;
        }

        return result * -1;
    }
}
