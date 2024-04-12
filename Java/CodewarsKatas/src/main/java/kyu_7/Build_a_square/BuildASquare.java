/*
LINK: https://www.codewars.com/kata/59a96d71dbe3b06c0200009c/train/java

I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.

Example
n = 3, so I expect a 3x3 square back just like below as a string:

+++
+++
+++
 */

package kyu_7.Build_a_square;

public class BuildASquare {
    public static final String generateShape(int n) {
        String result = "";

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                result += "+";
            }
            result += "\n";
        }

        return result.substring(0, result.length() - 1);
    }
}
