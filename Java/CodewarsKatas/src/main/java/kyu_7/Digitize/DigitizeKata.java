/*
LINK: https://www.codewars.com/kata/5417423f9e2e6c2f040002ae/train/java

Given a non-negative integer, return an array / a list of the individual digits in order.

Examples:

123 => [1,2,3]

1 => [1]

8675309 => [8,6,7,5,3,0,9]
 */

package kyu_7.Digitize;

import java.util.ArrayList;

public class DigitizeKata {
    public static int[] digitize(int n){
        ArrayList<Integer> numbers = new ArrayList<>();

        if (n == 0) {
            return new int[]{0};
        }

        while (n > 0) {
            numbers.add(n % 10);
            n = n / 10;
        }

        int[] result = new int[numbers.size()];

        int count = 0;
        for (int i = numbers.size() - 1; i >= 0; i--) {
            result[count] = numbers.get(i);
            count++;
        }

        return result;
    }
}
