/*
LINK: https://www.codewars.com/kata/57f609022f4d534f05000024/train/java

You are given an odd-length array of integers, in which all of them are the same,
except for one single number.

Complete the method which accepts such an array, and returns that single different number.

The input array will always be valid! (odd-length >= 3)

Examples
[1, 1, 2] ==> 2
[17, 17, 3, 17, 17, 17, 17] ==> 3
 */
package kyu_7.Find_the_stray_number;

public class FindTheStrayNumber {
    public static int stray(int[] numbers) {
        for (int i = 0; i < numbers.length; i++) {
            int count = 0;
            for (int j = 0; j < numbers.length; j++) {
                if (numbers[i] == numbers[j]) {
                    count++;
                }
            }

            if (count == 1) {
                return numbers[i];
            }
        }

        return 0;
    }
}
