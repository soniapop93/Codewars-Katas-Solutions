/*
LINK: https://www.codewars.com/kata/59887207635904314100007b/train/java

Simply find the closest value to zero from the list. Notice that there are negatives in the list.

List is always not empty and contains only integers. Return None if it is not possible to define
only one of such values. And of course, we are expecting 0 as closest value to zero.

Examples:

[2, 4, -1, -3]  => -1
[5, 2, -2]      => None
[5, 2, 2]       => 2
[13, 0, -6]     => 0
 */

package kyu_7.Closest_to_Zero;


import java.util.ArrayList;
import java.util.Arrays;

public class ClosestToZero {
    public static Integer find(int[] arr) {
        Arrays.sort(arr);

        ArrayList<Integer> closestPositive = new ArrayList<>();
        ArrayList<Integer> closestNegative = new ArrayList<>();

        for (int i = 0; i < arr.length; i++) {
            if (arr[i] >= 0) {
                closestPositive.add(arr[i]);
            }
            else if (arr[i] < 0) {
                closestNegative.add(arr[i]);
            }
        }

        if (closestPositive.size() > 0 && closestNegative.size() > 0) {
            if (closestPositive.get(0) == closestNegative.get(closestNegative.size() - 1) * -1) {
                return null;
            }
            else if (closestPositive.get(0) < closestNegative.get(closestNegative.size() - 1) * -1) {
                return closestPositive.get(0);
            }
            return closestNegative.get(closestNegative.size() - 1);
        }
        else if (closestPositive.size() > 0) {
            return closestPositive.get(0);
        }

        return closestNegative.get(closestNegative.size() - 1);
    }
}
