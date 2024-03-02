/*
LINK: https://www.codewars.com/kata/55fd2d567d94ac3bc9000064/train/java

Given the triangle of consecutive odd numbers:

             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Calculate the sum of the numbers in the nth row of this triangle
(starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8
 */

package kyu_7.Sum_of_odd_numbers;

import java.util.ArrayList;

public class SumOfOddNumbers {
    public static int rowSumOddNumbers(int n) {
        int result = 0;
        int lastNumber = 1;

        for (int i = 1; i <= n; i++) {
            int count = 1;
            ArrayList<Integer> rows = new ArrayList<>();

            while (count <= i) {
                if (lastNumber % 2 != 0) {
                    rows.add(lastNumber);
                    count++;
                }
                lastNumber++;
            }

            if (i == n) {
                for (int j = 0; j < rows.size(); j++) {
                    result += rows.get(j);
                }
            }
        }

        return result;
    }
}
