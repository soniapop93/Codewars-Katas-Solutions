/*
LINK: https://www.codewars.com/kata/514b92a657cdc65150000006/train/java

If we list all the natural numbers below 10 that are multiples of 3 or 5,
we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or
 5 below the number passed in.

Note: If the number is a multiple of both 3 and 5, only count it once.
 */

package kyu_6.Multiples_of_3_or_5;

public class MultiplesOf3Or5 {
    public static int solution(int number) {
        int result = 0;

        for (int i = 0; i < number; i++) {
            if ((i % 3 == 0) || (i % 5 == 0)) {
                result += i;
            }
        }

        return result;
    }
}
