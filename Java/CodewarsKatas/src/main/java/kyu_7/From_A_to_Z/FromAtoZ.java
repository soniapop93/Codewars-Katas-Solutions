/*
LINK: https://www.codewars.com/kata/6512b3775bf8500baea77663/train/java


Given a string indicating a range of letters, return a string which includes all the letters in that range,
including the last letter.
Note that if the range is given in capital letters, return the string in capitals also!

Examples
"a-z" ➞ "abcdefghijklmnopqrstuvwxyz"
"h-o" ➞ "hijklmno"
"Q-Z" ➞ "QRSTUVWXYZ"
"J-J" ➞ "J"
Notes
A hyphen will separate the two letters in the string.
You don't need to worry about error handling in this kata (i.e. both letters will be the same case and the second
letter will not be before the first alphabetically).
 */

package kyu_7.From_A_to_Z;

public class FromAtoZ {
    public static String gimmeTheLetters(String s){
        String result = "";
        String[] splittedS = s.split("-");

        for (int i = splittedS[0].charAt(0); i <= splittedS[1].charAt(0); i++) {
            result += String.valueOf((char)i);
        }

        return result;
    }
}
