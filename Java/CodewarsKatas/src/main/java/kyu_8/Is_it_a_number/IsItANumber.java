/*
LINK: https://www.codewars.com/kata/57126304cdbf63c6770012bd/train/java

Given a string s, write a method (function) that will return true if its a valid single integer
or floating number or false if its not.

Valid examples, should return true:

isDigit("3")
isDigit("  3  ")
isDigit("-3.23")
should return false:

isDigit("3-4")
isDigit("  3   5")
isDigit("3 5")
isDigit("zero")
 */

package kyu_8.Is_it_a_number;

public class IsItANumber {
    public boolean isDigit(String s)
    {
        s = s.trim();

        try {
            Integer.valueOf(s);
            return true;
        } catch (NumberFormatException e){
            try {
                Double.valueOf(s);
                return true;
            } catch (NumberFormatException ex){
                return false;
            }
        }
    }
}
