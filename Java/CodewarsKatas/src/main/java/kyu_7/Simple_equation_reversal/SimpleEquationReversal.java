/*
LINK: https://www.codewars.com/kata/5aa3af22ba1bb5209f000037/train/java

Given a mathematical equation that has *,+,-,/, reverse it as follows:

solve("100*b/y") = "y/b*100"
solve("a+b-c/d*30") = "30*d/c-b+a"
 */

package kyu_7.Simple_equation_reversal;

import java.util.HashMap;

public class SimpleEquationReversal {
    public static String solve(String eq){
        String result = "";
        String nr = "";
        boolean found = false;

        for (int i = eq.length() - 1; i >= 0; i--) {
            if (eq.charAt(i) >= 48 && eq.charAt(i) <= 57) {
                nr += String.valueOf(eq.charAt(i));

                if (i > 0) {
                    continue;
                }
                found = true;
            }

            String reversedNr = "";

            for (int j = nr.length() - 1; j >= 0; j--) {
                reversedNr += String.valueOf(nr.charAt(j));
            }

            if (!reversedNr.equals("")) {
                result += reversedNr;
                nr = "";
            }

            if (!found)
                result += String.valueOf(eq.charAt(i));
        }

        return result;
    }
}
