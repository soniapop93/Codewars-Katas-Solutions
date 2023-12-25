/*
LINK: https://www.codewars.com/kata/59cfc000aeb2844d16000075/train/java

Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below.
Index 0 will be considered even.

For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

The input will be a lowercase string with no spaces.
 */


package kyu_7.Alternate_capitalization;

public class AlternateCapitalization {
    public static String[] capitalize(String s){
        String first = "";
        String second = "";

        for (int i = 0; i < s.length(); i++) {
            if (i % 2 == 0) {
                first += String.valueOf((char)(s.charAt(i) - 32));
                second += String.valueOf(s.charAt(i));
            }
            else {
                first += String.valueOf(s.charAt(i));
                second += String.valueOf((char)(s.charAt(i) - 32));
            }
        }

        return new String[] {first, second};
    }
}
