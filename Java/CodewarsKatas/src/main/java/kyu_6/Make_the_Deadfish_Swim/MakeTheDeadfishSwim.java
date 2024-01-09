/*
LINK: https://www.codewars.com/kata/51e0007c1f9378fa810002a9/train/java

Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.parse("iiisdoso") =- new int[] {8, 64};
 */

package kyu_6.Make_the_Deadfish_Swim;

import java.util.ArrayList;

public class MakeTheDeadfishSwim {
    public static int[] parse(String data) {
        ArrayList<Integer> result = new ArrayList<>();

        int value = 0;

        for (int i = 0; i < data.length(); i++) {
            if (String.valueOf(data.charAt(i)).equals("i")) {
                value++;
            }
            else if (String.valueOf(data.charAt(i)).equals("d")) {
                value--;
            }
            else if (String.valueOf(data.charAt(i)).equals("s")) {
                value = value * value;
            }
            else if (String.valueOf(data.charAt(i)).equals("o")) {
                result.add(value);
            }
        }

        int[] res = new int[result.size()];

        for (int i = 0; i < result.size(); i++) {
            res[i] = result.get(i);
        }

        return res;
    }
}
