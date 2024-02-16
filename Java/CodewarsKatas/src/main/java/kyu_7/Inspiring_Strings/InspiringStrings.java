/*
LINK: https://www.codewars.com/kata/5939ab6eed348a945f0007b2/train/java

When given a string of space separated words, return the word with the longest length.
If there are multiple words with the longest length, return the last instance of the word with
the longest length.

Example:

'red white blue' //returns string value of white

'red blue gold' //returns gold
 */

package kyu_7.Inspiring_Strings;

public class InspiringStrings {
    public static String longestWord(String wordString) {
        String[] splittedStr = wordString.split(" ");

        int[] lenWords = new int[splittedStr.length];

        for (int i = 0; i < splittedStr.length; i++) {
            lenWords[i] = splittedStr[i].length();
        }

        int count = -1;
        int index = -1;

        for (int i = 0; i < lenWords.length; i++) {
            if (count <= lenWords[i]) {
                count = lenWords[i];
                index = i;
            }
        }

        return splittedStr[index];
    }
}
