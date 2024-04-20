/*
LINK: https://www.codewars.com/kata/5497a3c181dd7291ce000700/train/java

Given a square matrix (i.e. an array of subarrays), find the sum of values from the first value of the first array,
the second value of the second array, the third value of the third array, and so on...

Examples
array = [[1, 2],
         [3, 4]]

diagonal sum: 1 + 4 = 5
array = [[5, 9, 1, 0],
         [8, 7, 2, 3],
         [1, 4, 1, 9],
         [2, 3, 8, 2]]

diagonal sum: 5 + 7 + 1 + 2 = 15

 */
package kyu_7.Find_sum_of_top_left_to_bottom_right_diagonals;

public class FindSumOfTopLeftToBottomRightDiagonals {
    public static int diagonalSum(final int[][] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.length; i++) {
            for (int j = i; j < matrix[i].length; j++) {
                sum += matrix[i][j];
                break;
            }
        }

        return sum;
    }
}
