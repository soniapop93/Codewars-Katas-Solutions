/*
LINK: https://www.codewars.com/kata/573f5c61e7752709df0005d2/train/java

Write a function that merges two sorted arrays into a single one. The arrays only contain integers.
Also, the final outcome must be sorted and not have any duplicate.
 */

package kyu_8.Merging_sorted_integer_arrays;

import java.util.ArrayList;
import java.util.Arrays;

public class MergingSortedIntegerArrays {
    public static int[] mergeArrays(int[] first, int[] second) {
        int[] merged = new int[first.length + second.length];

        int count = 0;

        for (int i = 0; i < first.length; i++) {
            merged[count] = first[i];
            count++;
        }

        for (int i = 0; i < second.length; i++) {
            merged[count] = second[i];
            count++;
        }

        Arrays.sort(merged);

        ArrayList<Integer> removeDuplicates = new ArrayList<>();

        for (int i = 0; i < merged.length; i++) {
            if (!removeDuplicates.contains(merged[i])) {
                removeDuplicates.add(merged[i]);
            }
        }

        int[] result = new int[removeDuplicates.size()];

        for (int i = 0; i < removeDuplicates.size(); i++) {
            result[i] = removeDuplicates.get(i);
        }

        return result;
    }
}
