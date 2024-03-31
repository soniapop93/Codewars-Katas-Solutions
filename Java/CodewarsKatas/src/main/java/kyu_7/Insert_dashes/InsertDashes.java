/*
LINK: https://www.codewars.com/kata/55960bbb182094bc4800007b/train/java

Write a function insert_dash(num) / insertDash(num) / InsertDash(int num)
that will insert dashes ('-') between each two odd digits in num.
For example: if num is 454793 the output should be 4547-9-3.

Note that the number will always be non-negative (>= 0).
 */

package kyu_7.Insert_dashes;

public class InsertDashes {
    public static String insertDash(int num) {
        String numStr = String.valueOf(num);
        String result = "";

        for (int i = 0; i < numStr.length(); i++) {
            if (i == numStr.length() - 1) {
                result += numStr.charAt(i);
            }
            else if (Integer.valueOf(numStr.charAt(i)) % 2 != 0 &&
                Integer.valueOf(numStr.charAt(i + 1)) % 2 != 0) {
                result += numStr.charAt(i) + "-";
            }
            else {
                result += numStr.charAt(i);
            }
        }

        return result;
    }
}
