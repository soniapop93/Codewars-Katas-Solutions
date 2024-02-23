/*
LINK: https://www.codewars.com/kata/56582133c932d8239900002e/train/java

Complete the function to find the count of the most frequent item of an array.
You can assume that input is an array of integers. For an empty array return 0

Example
input array: [3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]
ouptut: 5
 */


package kyu_7.Find_Count_of_Most_Frequent_Item_in_an_Array;

import java.util.HashMap;

public class FindCountOfMostFrequentItemInAnArray {
    public static int mostFrequentItemCount(int[] collection) {
        if (collection.length < 1) {
            return 0;
        }

        HashMap<Integer, Integer> values = new HashMap<>();

        for (int i = 0; i < collection.length; i++) {
            if (values.containsKey(collection[i])) {
                values.put(collection[i], values.get(collection[i]) + 1);
            }
            else {
                values.put(collection[i], 1);
            }
        }

        int result = -1;

        for (int v : values.values()) {
            if (v > result) {
                result = v;
            }
        }

        return result;
    }
}
