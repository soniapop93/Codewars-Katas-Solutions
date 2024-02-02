/*
LINK: https://www.codewars.com/kata/5d50e3914861a500121e1958/train/java

Your task is to add up letters to one letter.

The function will be given an array of single character Strings, each one being a letter to add.

Notes:
Letters will always be lowercase.
Letters can overflow (see second to last example of the description)
If no letters are given, the function should return 'z'
Examples:
addLetters("a", "b", "c") = "f"
addLetters("a", "b") = "c"
addLetters("z") = "z"
addLetters("z", "a") = "a"
addLetters("y", "c", "b") = "d" // notice the letters overflowing
addLetters() = "z"

 */

package kyu_7.Alphabetical_Addition;

public class AlphabeticalAddition {
    public static String addLetters(String... letters) {
        if (letters.length == 0) {
            return "z";
        }

        int sum = 0;

        for (int i = 0; i < letters.length; i++) {
            sum += letters[i].charAt(0) - 96;

            if (sum > 26) {
                sum -= 26;
            }
        }
        return String.valueOf((char)(sum + 96));
    }
}
