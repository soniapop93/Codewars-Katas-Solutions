/*
LINK: https://www.codewars.com/kata/57ad85bb7cb1f3ae7c000039/train/java

You have to search all numbers from inclusive 1 to inclusive a given number x,
that have the given digit d in it.
The value of d will always be 0 - 9.
The value of x will always be greater than 0.

You have to return as an array:
the count of these numbers,
their sum
and their product.

For example:
x = 11
d = 1
->
Numbers: 1, 10, 11
Return: [3, 22, 110]

If there are no numbers, which include the digit, return [0,0,0].
 */


package kyu_7.Numbers_with_this_digit_inside;

import java.util.ArrayList;

public class NumbersWithThisDigitInside {
    public static long[] numbersWithDigitInside(long x, long d)
    {
        long[] result = new long[3];
        ArrayList<Integer> numbersFound = new ArrayList<>();

        for (int i = 1; i <= x; i++) {
            if (String.valueOf(i).contains(String.valueOf(d))) {
                numbersFound.add(i);
            }
        }

        long sum = 0;
        long product = 1;

        for (int i = 0; i < numbersFound.size(); i++) {
            sum += numbersFound.get(i);
            product *= numbersFound.get(i);
        }

        result[0] = numbersFound.size();
        result[1] = sum;
        result[2] = numbersFound.size() == 0 ? 0 : product;

        return result;
    }
}
