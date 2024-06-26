/*
LINK: https://www.codewars.com/kata/582cb3a637c5583f2200005d/train/java

You would like to get the 'weight' of a name by getting the sum of the ascii values.
However you believe that capital letters should be worth more than mere lowercase letters.
Spaces, numbers, or any other character are worth 0.

Normally in ascii

a has a value of 97
A has a value of 65
' ' has a value of 32
0 has a value of 48
To find who has the 'weightier' name you will switch all the values so:

A will be 97
a will be 65
' ' will be 0
0 will be 0
etc...
For example Joe will have a weight of 254, instead of 286 using normal ascii values.
 */

package kyu_7.Disagreeable_ascii;

public class DisagreeableAscii {
    public static int getWeight(String name){
        int result = 0;

        for (int i = 0; i < name.length(); i++) {
            if (name.charAt(i) >= 65 & name.charAt(i) <= 90) {
                result += name.charAt(i) + 32;
            } else if (name.charAt(i) >= 97 && name.charAt(i) <= 122) {
                result += name.charAt(i) - 32;
            }
        }

        return result;
    }

}
