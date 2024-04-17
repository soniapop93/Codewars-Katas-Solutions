/*
LINK: https://www.codewars.com/kata/5ac6932b2f317b96980000ca/train/java

Given a list of digits, return the smallest number that could be formed from these digits,
using the digits only once (ignore duplicates).

Notes:
Only positive integers will be passed to the function (> 0 ), no negatives or zeros.
Input >> Output Examples
minValue ({1, 3, 1})  ==> return (13)
Explanation:
(13) is the minimum number could be formed from {1, 3, 1} , Without duplications

minValue({5, 7, 5, 9, 7})  ==> return (579)
Explanation:
(579) is the minimum number could be formed from {5, 7, 5, 9, 7} , Without duplications

minValue({1, 9, 3, 1, 7, 4, 6, 6, 7}) return  ==> (134679)
 */

package kyu_7.Form_The_Minimum;

import java.util.Arrays;

public class FormTheMinimum {
    public static int minValue(int[] values){
        Arrays.sort(values);

        String strNumber = "";

        for (int i = 0; i < values.length; i++) {
            if (!strNumber.contains(String.valueOf(values[i]))) {
                strNumber += String.valueOf(values[i]);
            }
        }

        return Integer.valueOf(strNumber);
    }
}
