/*
LINK: https://www.codewars.com/kata/563b74ddd19a3ad462000054/train/java

Write me a function stringy that takes a size and returns a string of alternating 1s and 0s.

the string should start with a 1.

a string with size 6 should return :'101010'.

with size 4 should return : '1010'.

with size 12 should return : '101010101010'.

The size will always be positive and will only use whole numbers.
 */

package kyu_8.Stringy_Strings.kyu_8;

public class StringyStrings {
    public static String stringy(int size) {
        String result = "";

        for (int i = 1; i <= size; i++) {
            if (i % 2 == 0) {
                result += "0";
            }
            else {
                result += "1";
            }
        }

        return result;
    }
}
