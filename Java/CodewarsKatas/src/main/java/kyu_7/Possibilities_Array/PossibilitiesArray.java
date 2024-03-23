/*
LINK: https://www.codewars.com/kata/59b710ed70a3b7dd8f000027/train/java

A non-empty array a of length n is called an array of all possibilities if it contains all numbers between 0 and a.length - 1 (both inclusive).

Write a function that accepts an integer array and returns true if the array is an array of all possibilities, else false.

Examples:

[1,2,0,3] => True
# Includes all numbers between 0 and a.length - 1 (4 - 1 = 3)

[0,1,2,2,3] => False
# Doesn't include all numbers between 0 and a.length - 1 (5 - 1 = 4)

[0] => True
# Includes all numbers between 0 and a.length - 1 (1 - 1 = 0).
 */

package kyu_7.Possibilities_Array;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class PossibilitiesArray {
    public static boolean isAllPossibilities(int[] arg) {
        int maxValue = Integer.MIN_VALUE;

        if (arg.length == 0) {
            return false;
        }
        List<Integer> list = Arrays.stream(arg).boxed().toList();

        for (int i = 0; i < arg.length; i++) {
            int occurrences = Collections.frequency(list, i);

            if (arg[i] < 0 || occurrences > 1) {
                return false;
            }
            if (arg[i] > maxValue) {
                maxValue = arg[i];
            }
        }
        for (int i = 0; i < maxValue; i++) {
            if (!list.contains(i)) {
                return false;
            }
        }

        return true;
    }
}
