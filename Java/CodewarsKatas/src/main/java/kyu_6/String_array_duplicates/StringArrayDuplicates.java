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
        ArrayList<String> result = new ArrayList<String>();

        for (int i = 0; i < arr.length; i++) {
            String newWord = "";

            for (int j = 0; j < arr[i].length(); j++) {
                if ((j + 1) < arr[i].length()) {
                    if (arr[i].charAt(j) != arr[i].charAt(j + 1)) {
                        newWord += arr[i].charAt(j);
                    }
                } else {
                    newWord += arr[i].charAt(j);
                }
            }
            result.add(newWord);
        }

        String[] arrResult = new String[result.size()];

        for (int i = 0; i < result.size(); i++) {
            arrResult[i] = result.get(i);
        }

        return arrResult;
    }
}
