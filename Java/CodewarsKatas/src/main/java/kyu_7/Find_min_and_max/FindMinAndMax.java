/*
LINK: https://www.codewars.com/kata/57a1ae8c7cb1f31e4e000130/train/java

Implement a function that returns the minimal and the maximal value of a list (in this order).
 */

package kyu_7.Find_min_and_max;

import java.util.List;

public class FindMinAndMax {
    public static int[] getMinMax(List<Integer> list) {
        if (list.size() == 1) {
            return new int[] {list.get(0), list.get(0)};
        }

        int minValue = Integer.MAX_VALUE;
        int maxValue = Integer.MIN_VALUE;

        for (int i = 0; i < list.size(); i++) {
            if (list.get(i) > maxValue) {
                maxValue = list.get(i);
            }
            if (list.get(i) < minValue) {
                minValue = list.get(i);
            }
        }

        int[] result = new int[] {minValue, maxValue};

        return result;
    }
}
