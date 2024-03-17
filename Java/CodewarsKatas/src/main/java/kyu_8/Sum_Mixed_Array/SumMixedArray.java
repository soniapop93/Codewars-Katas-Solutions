/*
LINK: https://www.codewars.com/kata/57eaeb9578748ff92a000009/train/java

Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

Return your answer as a number.
 */

package kyu_8.Sum_Mixed_Array;

import java.util.List;

public class SumMixedArray {
    public int sum(List<?> mixed) {
        int result = 0;

        for (int i = 0; i < mixed.size(); i++) {
            result += Integer.parseInt(String.valueOf(mixed.get(i)));
        }
        return result;
    }
}
