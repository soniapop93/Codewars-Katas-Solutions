/*
LINK: https://www.codewars.com/kata/55908aad6620c066bc00002a/train/java

Check to see if a string has the same amount of 'x's and 'o's.
The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

 */

package kyu_7.Exes_and_Ohs;

public class ExesAndOhs {
    public static boolean getXO (String str) {
        int countX = 0;
        int countO = 0;

        for (int i = 0; i < str.length(); i++) {
            if (String.valueOf(str.charAt(i)).toLowerCase().equals("x")) {
                countX++;
            }
            else if (String.valueOf(str.charAt(i)).toLowerCase().equals("o")) {
                countO++;
            }
        }

        if (countO == countX) {
            return true;
        }
        return false;

    }
}
