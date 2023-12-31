/*
LINK: https://www.codewars.com/kata/5b39e3772ae7545f650000fc/train/java

Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

Example:

Input:

'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

Output:

'alpha beta gamma delta'
 */

package kyu_7.RemoveDuplicateWords;

public class RemoveDuplicateWords {
    public static String removeDuplicateWords(String s){
        String[] splittedS = s.split(" ");
        String result = "";

        for (int i = 0; i < splittedS.length; i++) {
            if (!result.contains(splittedS[i])) {
                result += splittedS[i] + " ";
            }
        }
        return result.substring(0, result.length() - 1);
    }
}
