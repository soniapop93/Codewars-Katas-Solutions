/*
LINK: https://www.codewars.com/kata/5a9e86705ee396d6be000091/train/java

Given an array with exactly 5 strings "a", "b" or "c"
(chars in Java, characters in Fortran), check if the array contains three and
 two of the same values.

Examples
["a", "a", "a", "b", "b"] ==> true  // 3x "a" and 2x "b"
["a", "b", "c", "b", "c"] ==> false // 1x "a", 2x "b" and 2x "c"
["a", "a", "a", "a", "a"] ==> false // 5x "a"

 */

package kyu_7.Check_three_and_two;

import java.util.HashMap;
import java.util.Map;

public class CheckThreeAndTwo {
    public static boolean checkThreeAndTwo(char[] chars) {
        HashMap<String, Integer> values = new HashMap<>();

        for (int i = 0; i < chars.length; i++) {
            if (values.containsKey(String.valueOf(chars[i]))) {
                values.put(String.valueOf(chars[i]), values.get(String.valueOf(chars[i])) + 1);
            }
            else {
                values.put(String.valueOf(chars[i]), 1);
            }
        }

        boolean result = false;

        for (Map.Entry<String, Integer> entry : values.entrySet()) {
            if (entry.getValue() == 2 || entry.getValue() == 3) {
                result = true;
            }
            else {
                result = false;
                break;
            }
        }

        return result;
    }
}
