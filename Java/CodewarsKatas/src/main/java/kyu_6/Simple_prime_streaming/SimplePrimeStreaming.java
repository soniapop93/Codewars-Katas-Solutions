/*
LINK: https://www.codewars.com/kata/5a908da30025e995880000e3/train/java

Consider a sequence made up of the consecutive prime numbers.
This infinite sequence would start with:

"2357111317192329313741434753596167717379..."
You will be given two numbers: a and b, and your task will be to return b elements
starting from index a in this sequence.

For example:
solve(10,5) == `19232` Because these are 5 elements from index 10 in the sequence.
 */

package kyu_6.Simple_prime_streaming;

public class SimplePrimeStreaming {
    public static String solve(int a, int b) {
        String result = "";
        StringBuilder primes = new StringBuilder();

        int count = 0;

        for (int i = 2; i <= Integer.MAX_VALUE; i++) {
            count = 0;

            for (int j = 2; j <= i / 2; j++) {
                if (i % j == 0) {
                    count++;
                    break;
                }
            }

            if (count == 0) {
                primes.append(i);
                if (primes.length() > a + b + 1) {
                    break;
                }
            }
        }

        String primesStr = primes.toString();

        result = primesStr.substring(a, a + b);

        return result;
    }
}
