/*
LINK: https://www.codewars.com/kata/5946a0a64a2c5b596500019a/train/java

You will receive an array as parameter that contains 1 or more integers and a
 number n.

Here is a little visualization of the process:

Step 1: Split the array in two:

[1, 2, 5, 7, 2, 3, 5, 7, 8]
      /            \
[1, 2, 5, 7]    [2, 3, 5, 7, 8]
Step 2: Put the arrays on top of each other:

   [1, 2, 5, 7]
[2, 3, 5, 7, 8]
Step 3: Add them together:

[2, 4, 7, 12, 15]
Repeat the above steps n times or until there is only one number left,
and then return the array.

Example
Input: arr=[4, 2, 5, 3, 2, 5, 7], n=2


Round 1
-------
step 1: [4, 2, 5]  [3, 2, 5, 7]

step 2:    [4, 2, 5]
        [3, 2, 5, 7]

step 3: [3, 6, 7, 12]


Round 2
-------
step 1: [3, 6]  [7, 12]

step 2:  [3,  6]
         [7, 12]

step 3: [10, 18]


Result: [10, 18]

 */

package kyu_6.Split_and_then_add_both_sides_of_an_array_together;

import java.util.ArrayList;

public class SplitAndThenAddBothSidesOfAnArrayTogether {
    public static int[] splitAndAdd(int[] numbers, int n) {
        ArrayList<Integer> listNumbers = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            listNumbers.add(numbers[i]);
        }

        ArrayList<Integer> secondHalf = new ArrayList<>();

        while (n > 0 && listNumbers.size() >= 1) {
            int middleIndex = (int) Math.floor(listNumbers.size() / 2);

            for (int i = middleIndex; i < listNumbers.size(); i++) {
                secondHalf.add(listNumbers.get(i));
            }

            while (listNumbers.size() > middleIndex) {
                listNumbers.remove(listNumbers.size() - 1);
            }

            for (int i = 0; i < listNumbers.size(); i++) {
                secondHalf.set(secondHalf.size() - 1 - i, secondHalf.get(secondHalf.size() - 1 - i) + listNumbers.get(listNumbers.size() - 1 - i));
            }

            listNumbers.clear();
            listNumbers.addAll(secondHalf);
            secondHalf.clear();

            n--;
        }

        return listNumbers.stream().mapToInt(i -> i).toArray();
    }
}
