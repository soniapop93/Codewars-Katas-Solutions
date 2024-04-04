/*
LINK: https://www.codewars.com/kata/5513795bd3fafb56c200049e/train/java

Create a function with two arguments that will return an array of the first n multiples of x.

Assume both the given number and the number of times to count will be positive numbers greater than 0.

Return the results as an array or list ( depending on language ).

Examples
countBy(1,10)  // should return  {1,2,3,4,5,6,7,8,9,10}
countBy(2,5)  // should return {2,4,6,8,10}
 */

package kyu_8.Count_by_X;

import java.util.ArrayList;

public class CountByX {
    public static int[] countBy(int x, int n){
        int[] result = new int[n];

        int count = 0;
        int index = 0;

        while (n > 0) {
            count++;
            if (count % x == 0) {
                result[index] = count;
                index++;
            }
            else {
                continue;
            }
            n--;
        }

        return result;
    }
}
