/*
LINK: https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/java

Convert number to reversed array of digits
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example(Input => Output):
35231 => [1,3,2,5,3]
0 => [0]
 */


package kyu_8.Convert_number_to_reversed_array_of_digits;

public class ConvertNumberToReversedArrayOfDigits {
    public static int[] digitize(long n) {
        if (n == 0) {
            return new int[]{0};
        }

        int[] result = new int[String.valueOf(n).length()];

        int index = 0;
        while (n > 0) {
            result[index] = (int)(n % 10);
            n = n / 10;
            index++;
        }

        return result;
    }
}
