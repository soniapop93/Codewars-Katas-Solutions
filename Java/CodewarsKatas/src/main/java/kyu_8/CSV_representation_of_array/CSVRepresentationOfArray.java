/*
LINK: https://www.codewars.com/kata/5a34af40e1ce0eb1f5000036/train/java

Create a function that returns the CSV representation of a two-dimensional numeric array.

Example:

input:
   [[ 0, 1, 2, 3, 4 ],
    [ 10,11,12,13,14 ],
    [ 20,21,22,23,24 ],
    [ 30,31,32,33,34 ]]

output:
     '0,1,2,3,4\n'
    +'10,11,12,13,14\n'
    +'20,21,22,23,24\n'
    +'30,31,32,33,34'
Array's length > 2.

 */

package kyu_8.CSV_representation_of_array;

public class CSVRepresentationOfArray {
    public static String toCsvText(int[][] array){
        String result = "";

        for (int i = 0; i < array.length; i++) {
            String newLine = "";
            for (int j = 0; j < array[i].length; j++) {
                newLine += array[i][j] + ",";
            }
            result += newLine.substring(0, newLine.length() - 1) + "\n";
        }

        return result.substring(0, result.length() - 1);
    }
}
