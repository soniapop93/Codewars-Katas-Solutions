/*
LINK: https://www.codewars.com/kata/57ee99a16c8df7b02d00045f/train/java

Given a two-dimensional array of integers, return the flattened version of the array
with all the integers in the sorted (ascending) order.

Example:

Given [[3, 2, 1], [4, 6, 5], [], [9, 7, 8]], your function should return [1, 2, 3, 4, 5, 6, 7, 8, 9].
 */

package kyu_7.Flatten_and_sort_an_array;

import java.util.ArrayList;
import java.util.Arrays;

public class FlattenAndSortAnArray {
    public static int[] flattenAndSort(int[][] array) {
        ArrayList<Integer> values = new ArrayList<>();

        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array[i].length; j++) {
                values.add(array[i][j]);
            }
        }

        int[] result = new int[values.size()];

        for (int i = 0; i < values.size(); i++) {
            result[i] = values.get(i);
        }

        Arrays.sort(result);

        return result;
    }
}
