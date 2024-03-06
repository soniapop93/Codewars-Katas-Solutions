/*
LINK: https://www.codewars.com/kata/54557d61126a00423b000a45/train/java

Given 2 strings, a and b, return a string of the form: shorter+reverse(longer)+shorter.

In other words, the shortest string has to be put as prefix and as suffix of the reverse of the longest.

Strings a and b may be empty, but not null (In C# strings may also be null. Treat them as if they are empty.).
If a and b have the same length treat a as the longer producing b+reverse(a)+b


 */

package kyu_7.Shorter_concat_reverse_longer;

public class ShorterConcatReverseLonger {
    public static String shorterReverseLonger(String a, String b) {
        if (a.length() > b.length())
        {
            return b + reverseStr(a) + b;
        }
        else  if (b.length() > a.length()) {
            return a + reverseStr(b) + a;
        }
        else {
            return b + reverseStr(a) + b;
        }
    }

    private static String reverseStr(String s) {
        String newStr = "";

        for (int i = s.length() - 1; i >= 0; i--) {
            newStr += String.valueOf(s.charAt(i));
        }

        return newStr;
    }
}
