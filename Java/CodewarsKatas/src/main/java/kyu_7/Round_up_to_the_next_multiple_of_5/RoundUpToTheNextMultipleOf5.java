/*
LINK:  https://www.codewars.com/kata/55d1d6d5955ec6365400006d/train/java

Given an integer as input, can you round it to the next (meaning, "greater than or equal") multiple of 5?

Examples:

input:    output:
0    ->   0
2    ->   5
3    ->   5
12   ->   15
21   ->   25
30   ->   30
-2   ->   0
-5   ->   -5
etc.
Input may be any positive or negative integer (including 0).

You can assume that all inputs are valid integers.
 */


package kyu_7.Round_up_to_the_next_multiple_of_5;

public class RoundUpToTheNextMultipleOf5 {
    public static int roundToNext5(int number) {
        if ((number == 0) || ((number % 5) == 0)) {
            return number;
        }

        do {
            number++;
        } while((number % 5) != 0);

        return number;
    }
}
