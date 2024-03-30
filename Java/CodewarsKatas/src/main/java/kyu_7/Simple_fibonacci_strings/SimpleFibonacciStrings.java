/*
LINK: https://www.codewars.com/kata/5aa39ba75084d7cf45000008/train/java

Given that

f0 = '0'
f1 = '01'
f2 = '010' = f1 + f0
f3 = '01001' = f2 + f1
You will be given a number and your task is to return the nth fibonacci string.
For example:

solve(2) = '010'
solve(3) = '01001'
 */

package kyu_7.Simple_fibonacci_strings;

public class SimpleFibonacciStrings {
    public static String solve(int n){
        String firstItem = "0";
        String secondItem = firstItem + "1";

        if (n == 0) {
            return firstItem;
        } else if (n == 1) {
            return secondItem;
        }

        int index = 2;

        while (index < n) {
            String aux = firstItem;
            firstItem = secondItem;
            secondItem += aux;

            index++;
        }

        return secondItem + firstItem;
    }
}