/*
LINK; https://www.codewars.com/kata/515f51d438015969f7000013/train/java

Write a function that when given a number >= 0, returns an Array of ascending length subarrays.

pyramid(0) => [ ]
pyramid(1) => [ [1] ]
pyramid(2) => [ [1], [1, 1] ]
pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
Note: the subarrays should be filled with 1s
 */

package kyu_6.Pyramid_Array;

public class PyramidArray {
    public static int[][] pyramid(int n){
        if (n == 0) {
            return new int[][]{};
        }

        int[][] pyramidList = new int[n][];

        for (int i = 0; i < n; i++) {
            int[] items = new int[i + 1];

            for (int j = 0; j <= i; j++) {
                items[j] = 1;
            }
                pyramidList[i] = items;
        }

        return pyramidList;
    }
}
