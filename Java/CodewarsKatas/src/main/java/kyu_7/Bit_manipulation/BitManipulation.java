/*
LINK: https://www.codewars.com/kata/5a0d38c9697598b67a000041/train/java

You are given a string representing a number in binary. Your task is to delete all the unset bits in this string
and return the corresponding number (after keeping only the '1's).

In practice, you should implement this function:

public long eliminateUnsetBits(String number);
Examples
eliminateUnsetBits("11010101010101") ->  255 (= 11111111)
eliminateUnsetBits("111") ->  7
eliminateUnsetBits("1000000") -> 1
eliminateUnsetBits("000") -> 0

 */

package kyu_7.Bit_manipulation;

import java.math.BigInteger;

public class BitManipulation {
    public static long eliminateUnsetBits(String number) {
        if (number.equals("")) {
            return 0;
        }

        String filteredNumber = number.replaceAll("0", "");

        return Long.valueOf(String.valueOf(new BigInteger(filteredNumber, 2)));
    }
}
