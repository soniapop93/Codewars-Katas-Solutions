/*
LINK: https://www.codewars.com/kata/57cf50a7eca2603de0000090/train/java

Move every letter in the provided string forward 10 letters through the alphabet.

If it goes past 'z', start again at 'a'.

Input will be a string with length > 0.
 */

package kyu_7.Move_10;

public class Move10 {
    public static String moveTen(String s) {
        String result = "";

        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) >= 97 && s.charAt(i) <= 122) {
                int value =  s.charAt(i) + 10;

                if (value > 122) {
                    int n = value - 122;

                    result += String.valueOf((char)(96 + n));
                }
                else {
                    result += String.valueOf((char)(value));
                }
            }
        }

        return result;
    }
}
