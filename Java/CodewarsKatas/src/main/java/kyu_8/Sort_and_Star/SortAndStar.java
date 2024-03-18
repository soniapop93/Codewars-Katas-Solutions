/*
LINK: https://www.codewars.com/kata/57cfdf34902f6ba3d300001e/train/java

You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on
the ASCII values of the chars) and then return the first value.

The returned value must be a string, and have "***" between each of its letters.

You should not remove or add elements from/to the array.


 */

package kyu_8.Sort_and_Star;

public class SortAndStar {
    public static String twoSort(String[] s) {
        String firstValue = "";

        for (int i = 65; i <= 122; i++) {
            for (int j = 0; j < s.length; j++){
                if (s[j].charAt(0) == i) {
                    firstValue = String.valueOf(s[j]);
                    break;
                }
            }
            if (!firstValue.equals("")) {
                break;
            }
        }

        String result = "";

        for (int i = 0; i < firstValue.length(); i++) {
            result += firstValue.charAt(i);

            if (i != firstValue.length() - 1) {
                result += "***";
            }
        }

        return result;
    }
}