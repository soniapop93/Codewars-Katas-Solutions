/*
LINK: https://www.codewars.com/kata/5a4d303f880385399b000001/train/java

Strong number is a number with the sum of the factorial of its digits is equal to the number itself.

For example, 145 is strong, because 1! + 4! + 5! = 1 + 24 + 120 = 145.

Task
Given a positive number, find if it is strong or not, and return either "STRONG!!!!" or "Not Strong !!".

Examples
1 is a strong number, because 1! = 1, so return "STRONG!!!!".
123 is not a strong number, because 1! + 2! + 3! = 9 is not equal to 123, so return "Not Strong !!".
145 is a strong number, because 1! + 4! + 5! = 1 + 24 + 120 = 145, so return "STRONG!!!!".
150 is not a strong number, because 1! + 5! + 0! = 122 is not equal to 150, so return "Not Strong !!".
 */

package kyu_7.Strong_Number;

import java.util.ArrayList;

public class StrongNumber {
    public static String isStrongNumber(int num) {
        int sum = 0;
        int tempNum = num;

        ArrayList<Integer> numbers = new ArrayList<>();

        while (tempNum > 0) {
            numbers.add(tempNum % 10);
            tempNum = tempNum / 10;
        }

        for (int i = 0; i < numbers.size(); i++) {
            int factorial = 1;

            for (int j = 1; j <= numbers.get(i); j++) {
                factorial *= j;
            }
            sum += factorial;
        }

        if (sum == num) {
            return "STRONG!!!!";
        }

        return "Not Strong !!";
    }
}
