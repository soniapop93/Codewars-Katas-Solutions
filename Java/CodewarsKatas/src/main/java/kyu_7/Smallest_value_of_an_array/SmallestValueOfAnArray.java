/*
LINK: https://www.codewars.com/kata/544a54fd18b8e06d240005c0/train/java


Write a function that can return the smallest value of an array or the index of that value.
The function's 2nd parameter will tell whether it should return the value or the index.

Assume the first parameter will always be an array filled with at least 1 number and no duplicates.
Assume the second parameter will be a string holding one of two values: 'value' and 'index'.

Arrays.findSmallest(new int[]{1,2,3,4,5}, 'value') // => 1
Arrays.findSmallest(new int[]{1,2,3,4,5}, 'index') // => 0
 */

package kyu_7.Smallest_value_of_an_array;

public class SmallestValueOfAnArray {
    public static int findSmallest( final int[] numbers, final String toReturn ) {
        int smallestValue = Integer.MAX_VALUE;
        int index = -1;

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] < smallestValue) {
                smallestValue = numbers[i];
                index = i;
            }
        }

        return toReturn.equals("value") ? smallestValue : index;
    }
}
