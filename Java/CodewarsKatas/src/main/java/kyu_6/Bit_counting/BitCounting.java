/*
LINK: https://www.codewars.com/kata/526571aae218b8ee490006f4/train/java

Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary
representation of that number. You can guarantee that input is non-negative.

Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
 */

package kyu_6.Bit_counting;

public class BitCounting {
    public static int countBits(int n){
        String binaryN = Integer.toBinaryString(n);

        int count = 0;

        for (int i = 0; i < binaryN.length(); i++) {
            if (String.valueOf(binaryN.charAt(i)).equals("1")) {
                count++;
            }
        }

        return count;
    }
}
