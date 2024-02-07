/*
LINK: https://www.codewars.com/kata/59f11118a5e129e591000134/train/java

In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice.
Your task will be to return the sum of the numbers that occur only once.

For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
Every other number occurs twice.
 */

package kyu_7.Sum_of_array_singles;

public class SumOfArraySingles {
    public static int repeats(int [] arr){
        int result = 0;

        for (int i = 0; i < arr.length; i++) {
            int count = countOccurences(arr[i], arr);

            if (count == 1) {
                result += arr[i];
            }
        }
        return result;
    }

    private static int countOccurences(int n, int[] arr) {
        int count = 0;

        for (int i = 0; i < arr.length; i++) {
            if (n == arr[i]) {
                count++;
            }
        }
        return count;
    }
}
