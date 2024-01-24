/*
LINK: https://www.codewars.com/kata/5bbb8887484fcd36fb0020ca/train/java

Count how often sign changes in array.

number from 0 to ... . Empty array returns 0
exemple:
const arr = [1, -3, -4, 0, 5];
catchSignChange(arr) == 2;
 */

package kyu_7.Plus_minus_Count;

public class PlusMinusCount {
    public static int signChange(int[] arr) {
        int count = 0;
        int lastItem = 0;

        for (int i = 0; i < arr.length; i++) {
            if (i == 0) {
                lastItem = arr[i];
            }

            if (lastItem >= 0 && arr[i] < 0) {
                count++;
            }
            else if (lastItem < 0 && arr[i] >= 0) {
                count++;
            }

            lastItem = arr[i];
        }

        return count;
    }
}
