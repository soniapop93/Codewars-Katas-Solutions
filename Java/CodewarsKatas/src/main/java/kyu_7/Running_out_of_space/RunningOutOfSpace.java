/*
LINK: https://www.codewars.com/kata/56576f82ab83ee8268000059/train/java

Kevin is noticing his space run out! Write a function that removes the spaces from the values and
returns an array
showing the space decreasing.
For example, running this function on the array ['i', 'have','no','space']
would produce ['i','ihave','ihaveno','ihavenospace']
 */

package kyu_7.Running_out_of_space;

public class RunningOutOfSpace {
    public static String[] spacey(String[] array) {
        String[] result = new String[array.length];

        String generatedStr = "";
        for (int i = 0; i < array.length; i++) {
            generatedStr += array[i];
            result[i] = generatedStr;
        }

        return result;
    }
}
