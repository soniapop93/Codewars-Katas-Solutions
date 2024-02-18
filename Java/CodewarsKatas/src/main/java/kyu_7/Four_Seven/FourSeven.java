/*
LINK: https://www.codewars.com/kata/5ff50f64c0afc50008861bf0/train/java

Simple kata, simple rules: your function should accept the inputs 4 and 7. If 4 is entered,
the function should return 7. If 7 is entered, the function should return 4.
Anything else entered as input should return 0. There's only one catch,
your function cannot include if statements, switch statements, or the ternary operator.

There are some very simple ways of answering this problem,
but I encourage you to try and be as creative as possible.
 */

package kyu_7.Four_Seven;

import java.util.HashMap;

public class FourSeven {
    public static int fourSeven(int n){
        HashMap<Integer, Integer> values = new HashMap<>();
        values.put(n, 0);
        values.put(4, 7);
        values.put(7, 4);

        return values.get(n);
    }
}
