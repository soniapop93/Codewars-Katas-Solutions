/*
LINK: https://www.codewars.com/kata/57a0885cbb9944e24c00008e/train/java

Write function RemoveExclamationMarks which removes all 
exclamation marks from a given string.


 */

package kyu_8.Remove_exclamation_marks;

public class RemoveExclamationMarks {
    static String removeExclamationMarks(String s) {
        String filteredS = "";

        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) != 33) { // 33 -> !
                filteredS += String.valueOf(s.charAt(i));
            }
        }

        return filteredS;
    }
}
