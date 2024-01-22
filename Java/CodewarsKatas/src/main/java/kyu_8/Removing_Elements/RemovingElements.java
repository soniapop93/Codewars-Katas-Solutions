/*
LINK: https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/train/java


Take an array and remove every second element from the array.
Always keep the first element and start removing with the next element.

Example:
["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]
 */

package kyu_8.Removing_Elements;

import java.util.ArrayList;

public class RemovingElements {
    public static Object[] removeEveryOther(Object[] arr) {
        ArrayList<Object> filteredElements = new ArrayList<>();

        for (int i = 0; i < arr.length; i++) {
            if (i % 2 == 0) {
                filteredElements.add(arr[i]);
            }
        }

        Object[] result = new Object[filteredElements.size()];

        for (int i = 0; i < filteredElements.size(); i++) {
            result[i] = filteredElements.get(i);
        }

        return result;
    }
}
