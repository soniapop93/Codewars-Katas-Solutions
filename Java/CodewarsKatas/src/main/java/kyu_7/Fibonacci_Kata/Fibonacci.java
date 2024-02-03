/*
LINK: https://www.codewars.com/kata/57a1d5ef7cb1f3db590002af/train/java

Create function fib that returns n'th element of Fibonacci sequence (classic programming task).
 */

package kyu_7.Fibonacci_Kata;

public class Fibonacci {
    public static long fib (int n){
        int x = 1;
        int y = 1;

        if (n <= 2) {
            return 1;
        }

        while ((n - 2) > 0) {
            int sum = x + y;

            x = y;
            y = sum;

            n--;
        }

        return y;
    }
}
