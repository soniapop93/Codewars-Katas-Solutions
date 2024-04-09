/*
LINK: https://www.codewars.com/kata/57b6f5aadb5b3d0ae3000611/train/java

You get an array of arrays.
If you sort the arrays by their length, you will see, that their length-values are consecutive.
But one array is missing!


You have to write a method, that return the length of the missing array.

Example:
[[1, 2], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9]] --> 3

If the array of arrays is null/nil or empty, the method should return 0.

When an array in the array is null or empty, the method should return 0 too!
There will always be a missing element and its length will be always between the given arrays.
 */

package kyu_6.Length_of_missing_array;

import java.util.Arrays;

public class LengthOfMissingArray {
    public static int getLengthOfMissingArray(Object[][] arrayOfArrays)
    {
        if ((arrayOfArrays == null) || (arrayOfArrays.length == 0)) {
            return 0;
        }

        int[] countArrays = new int[arrayOfArrays.length];

        for (int i = 0; i < arrayOfArrays.length; i++) {
            if ((arrayOfArrays[i] == null) || (arrayOfArrays[i].length == 0)) {
                return 0;
            }
            countArrays[i] = arrayOfArrays[i].length;
        }

        Arrays.sort(countArrays);

        for (int i = 0; i <= countArrays[countArrays.length - 1]; i++) {
            if (!contains(countArrays, i) && i >= countArrays[0]) {
                return i;
            }
        }

        return 0;
    }

    private static boolean contains(final int[] arr, final int value) {
        boolean result = Arrays.stream(arr).anyMatch(i -> i == value);
        return result;
    }

}
