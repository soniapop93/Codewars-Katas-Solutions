/*
LINK: https://www.codewars.com/kata/59f08f89a5e129c543000069/train/java

In this Kata, you will be given an array of strings and your task is to remove all consecutive duplicate letters
from each string in the array.

For example:

dup(["abracadabra","allottee","assessee"]) = ["abracadabra","alote","asese"].

dup(["kelless","keenness"]) = ["keles","kenes"].

Strings will be lowercase only, no spaces.
 */

package kyu_6.String_array_duplicates;

import java.util.ArrayList;

public class StringArrayDuplicates {
    public static String[] dup(String[] arr){
        String[] result = {};

        for (int i = 0; i < arr.length; i++) {
            String currentString = arr[i];

            for (int j = 0; j < arr[i].length(); j++) {
                int countLetter = countOccurences(currentString, arr[i].charAt(j));

                //todo: finish it
            }
        }

        return result;
    }

    private static int countOccurences(String word, char letter) {
        int count = 0;

        for (int i = 0; i < word.length(); i++) {
            if (word.equals(String.valueOf(letter))) {
                count++;
            }
        }

        return count;
    }
}
