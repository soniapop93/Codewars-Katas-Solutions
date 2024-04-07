/*
LINK: https://www.codewars.com/kata/56e2f59fb2ed128081001328/train/java


Input: Array of elements

["h","o","l","a"]

Output: String with comma delimited elements of the array in th same order.

"h,o,l,a"

Note: if this seems too simple for you try the next level

Note2: the input data can be: boolean array, array of objects, array of string arrays,
array of number arrays...
 */

package kyu_8.Printing_Array_elements_with_Comma_delimiters;

public class PrintingArrayElementsWithCommaDelimiters {
    public static String printArray(Object[] array) {
        String result = "";

        for (int i = 0; i < array.length; i++) {
            result += String.valueOf(array[i]) + ",";
        }

        return result.substring(0, result.length() - 1);
    }
}