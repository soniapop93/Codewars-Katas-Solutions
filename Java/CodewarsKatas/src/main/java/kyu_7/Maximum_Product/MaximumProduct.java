/*
LINK: https://www.codewars.com/kata/5a4138acf28b82aa43000117/train/java


Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

Notes
Array/list size is at least 2.

Array/list numbers could be a mixture of positives, negatives also zeroes .

Input >> Output Examples
adjacentElementsProduct([1, 2, 3]); ==> return 6
Explanation:
The maximum product obtained from multiplying 2 * 3 = 6, and they're adjacent numbers in the array.
adjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]); ==> return 50
Explanation:
Max product obtained from multiplying 5 * 10  =  50 .
 */

package kyu_7.Maximum_Product;

public class MaximumProduct {
    public static int adjacentElementsProduct(int[] array) {
        int maxProduct = Integer.MIN_VALUE;

        for (int i = 0; i < array.length - 1; i++) {
            int result = array[i] * array[i + 1];
            if (result > maxProduct) {
                maxProduct = result;
            }
        }

        return maxProduct;
    }

}
