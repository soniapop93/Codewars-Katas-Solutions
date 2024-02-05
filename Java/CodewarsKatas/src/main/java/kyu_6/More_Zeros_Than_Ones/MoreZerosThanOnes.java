/*
LINK: https://www.codewars.com/kata/5d41e16d8bad42002208fe1a/train/java

Create a moreZeros function which will receive a string for input, and return an array
(or null terminated string in C) containing only the characters from that string whose binary representation
of its ASCII value consists of more zeros than ones.

You should remove any duplicate characters, keeping the first occurrence of any such duplicates, so they are in
the same order in the final array as they first appeared in the input string.

Examples

'abcde' === ["1100001", "1100010", "1100011", "1100100", "1100101"]
               True       True       False      True       False

        --> ['a','b','d']

'DIGEST'--> ['D','I','E','T']
All input will be valid strings of length > 0. Leading zeros in binary should not be counted.
 */

package kyu_6.More_Zeros_Than_Ones;

public class MoreZerosThanOnes {
    public static char[] moreZeros(String s) {
        String result = "";

        String sFiltered = "";

        for (int i = 0; i < s.length(); i++) {
            if (!sFiltered.contains(String.valueOf(s.charAt(i)))) {
                sFiltered += String.valueOf(s.charAt(i));
            }
        }

        for (int i = 0; i < sFiltered.length(); i++) {
            String binaryChar = Integer.toBinaryString(sFiltered.charAt(i));

            if (binaryChar.charAt(0) == '0') {
                binaryChar = binaryChar.replaceFirst("0", "");
            }
            if (countChar(binaryChar, '0') > countChar(binaryChar, '1')) {
                result += String.valueOf(sFiltered.charAt(i));
            }
        }

        char[] charResult = result.toCharArray();
        return charResult;
    }

    private static int countChar(String s, char c) {
        int count = 0;

        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) == c) {
                count++;
            }
        }

        return count;
    }
}
