/*
LINK: https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/java

Write a function named first_non_repeating_letter† that takes a string input, and returns the first
character that is not repeated anywhere in the string.

For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in
the string, and occurs first in the string.

As an added challenge, upper- and lowercase letters are considered the same character, but the function should return
the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

If a string contains all repeating characters, it should return an empty string ("");

† Note: the function is called firstNonRepeatingLetter for historical reasons, but your function should handle any
Unicode character.
 */

package kyu_5.First_non_repeating_character;

public class FirstNonRepeatingCharacter {
    public static String firstNonRepeatingLetter(String s){
        int count = 0;
        String result = "";

        for (int i = 0; i < s.length(); i++) {
            for (int j = 0; j < s.length(); j++) {
                if (String.valueOf(s.charAt(i)).toLowerCase().equals(String.valueOf(s.charAt(j)).toLowerCase())) {
                    count++;
                }

                if (count > 1) {
                    count = 0;
                    break;
                }
            }

            if (count == 1) {
                result = String.valueOf(s.charAt(i));
                break;
            }
        }
        return result;
    }
}