/*
LINK: https://www.codewars.com/kata/57cc79ec484cf991c900018d/train/java

Simple enough this one - you will be given an array. The values in the array will either be numbers or strings,
or a mix of both. You will not get an empty array, nor a sparse one.

Your job is to return a single array that has first the numbers sorted in ascending order, followed by the strings
sorted in alphabetic order. The values must maintain their original type.

Note that numbers written as strings are strings and must be sorted with the other strings.
 */

package kyu_7.Double_Sort;

import java.util.ArrayList;
import java.util.Arrays;

public class DoubleSort {
    public static Object[] dbSort(Object[] a){
        ArrayList<Integer> numbers = new ArrayList<>();
        ArrayList<String> words = new ArrayList<>();

        for (int i = 0; i < a.length; i++) {
            String type = a[i].getClass().getTypeName();
            if (type.contains("String")) {
                words.add(String.valueOf(a[i]));
            }
            else {
                numbers.add(Integer.valueOf(String.valueOf(a[i])));
            }
        }

        int[] arrayNumbers = new int[numbers.size()];

        for (int i = 0; i < numbers.size(); i++) {
            arrayNumbers[i] = numbers.get(i);
        }

        String[] arrayWords = new String[words.size()];

        for (int i = 0; i < words.size(); i++) {
            arrayWords[i] = words.get(i);
        }

        Arrays.sort(arrayNumbers);
        Arrays.sort(arrayWords);

        Object[] result = new Object[a.length];

        int countNr = 0;

        for (int i = 0; i < arrayNumbers.length; i++) {
            result[i] = arrayNumbers[i];
            countNr++;
        }

        for (int i = 0; i < arrayWords.length; i++) {
            result[i + countNr] = arrayWords[i];
        }

        return result;
    }
}
