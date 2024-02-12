/*
LINK: https://www.codewars.com/kata/5a29a0898f27f2d9c9000058/train/java

In this Kata, you will be given a string and your task will be to return a list of ints detailing the count of
uppercase letters, lowercase, numbers and special characters, as follows.

Solve("*'&ABCDabcde12345") = [4,5,5,3].
--the order is: uppercase letters, lowercase, numbers and special characters.
 */

package kyu_7.Simple_string_characters;

public class SimpleStringCharacters {
    public static int[] Solve(String word) {
        int[] result = new int[4];

        int upperLetters = 0;
        int lowerLetters = 0;
        int numbers = 0;
        int specialChars = 0;

        for (int i = 0; i < word.length(); i++) {
            if (word.charAt(i) >= 65 && word.charAt(i) <= 90) {
                upperLetters++;
            } else if (word.charAt(i) >= 97 && word.charAt(i) <= 122) {
                lowerLetters++;
            } else if (word.charAt(i) >= 48 && word.charAt(i) <= 57) {
                numbers++;
            } else {
                specialChars++;
            }
        }

        result[0] = upperLetters;
        result[1] = lowerLetters;
        result[2] = numbers;
        result[3] = specialChars;

        return result;
    }
}
