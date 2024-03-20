/*
LINK: https://www.codewars.com/kata/55edaba99da3a9c84000003b/train/java

Complete the function which takes two arguments and returns all numbers which are divisible by the
given divisor. First argument is an array of numbers and the second is the divisor.

Example(Input1, Input2 --> Output)
[1, 2, 3, 4, 5, 6], 2 --> [2, 4, 6]
 */

package kyu_8.Find_numbers_which_are_divisible_by_given_number;

import java.util.ArrayList;

public class FindNumbersWhichAreDivisibleByGivenNumber {
    public static int[] divisibleBy(int[] numbers, int divider) {
        ArrayList<Integer> numbersFiltered = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] % divider == 0) {
                numbersFiltered.add(numbers[i]);
            }
        }

        int[] result = new int[numbersFiltered.size()];

        for (int i = 0; i < numbersFiltered.size(); i++) {
            result[i] = numbersFiltered.get(i);
        }

        return result;
    }
}
