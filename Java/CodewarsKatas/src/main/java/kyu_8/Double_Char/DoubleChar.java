/*
LINK: https://www.codewars.com/kata/56b1f01c247c01db92000076/train/java

Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "

 */

package kyu_8.Double_Char;

public class DoubleChar {
    public static String doubleChar(String s){
        String result = "";

        for (int i = 0; i < s.length(); i++) {
            result += String.valueOf(s.charAt(i)) + String.valueOf(s.charAt(i));
        }

        return result;
    }
}
