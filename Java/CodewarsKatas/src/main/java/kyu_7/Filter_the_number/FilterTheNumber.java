/*
LINK: https://www.codewars.com/kata/55b051fac50a3292a9000025/train/java

Filter the number
Oh, no! The number has been mixed up with the text. Your goal is to retrieve the number from the text,
can you return the number back to its original state?

Task
Your task is to return a number from a string.

Details
You will be given a string of numbers and letters mixed up, you have to return all the numbers in that
string in the order they occur.
 */

package kyu_7.Filter_the_number;

public class FilterTheNumber {
    public static long filterString(final String value) {
        String number = "";

        for (int i = 0; i < value.length(); i++) {
            if (value.charAt(i) >= 48 && value.charAt(i) <= 57) {
                number += String.valueOf(value.charAt(i));
            }
        }
        return Long.parseLong(number);
    }
}
