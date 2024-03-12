/*
LINK: https://www.codewars.com/kata/55a2d7ebe362935a210000b2/train/java

Given an array of integers your solution should find the smallest integer.

For example:

Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.
 */

package kyu_8.Find_the_smallest_integer_in_the_array;

public class FindTheSmallestIntegerInTheArray {
    public static int findSmallestInt(int[] args) {
        int smallInt = Integer.MAX_VALUE;

        for (int i = 0; i < args.length; i++) {
            if (args[i] < smallInt) {
                smallInt = args[i];
            }
        }

        return smallInt;
    }
}
