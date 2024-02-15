/*
LINK: https://www.codewars.com/kata/598d91785d4ce3ec4f000018/train/java

Given a string "abc" and assuming that each letter in the string has a value equal to its position in the alphabet,
our string will have a value of 1 + 2 + 3 = 6. This means that: a = 1, b = 2, c = 3 ....z = 26.

You will be given a list of strings and your task will be to return the values of the strings as explained above
multiplied by the position of that string in the list. For our purpose, position begins with 1.

nameValue ["abc","abc abc"] should return [6,24] because of [ 6 * 1, 12 * 2 ]. Note how spaces are ignored.

"abc" has a value of 6, while "abc abc" has a value of 12. Now, the value at position 1 is multiplied by 1 while
the value at position 2 is multiplied by 2.

Input will only contain lowercase characters and spaces.
 */

package kyu_7.Word_values;

import java.util.ArrayList;

public class WordValues {
    public static int [] nameValue(String [] arr){
        ArrayList<Integer> values = new ArrayList<>();

        for (int i = 0; i < arr.length; i++) {
           int countItem = 0;

           for (int j = 0; j < arr[i].length(); j++) {
               if (arr[i].charAt(j) >= 97 && arr[i].charAt(j) <= 122) {
                   int countLetter = 1;

                   for (int k = 97; k < 122; k++) {
                       if (arr[i].charAt(j) == (char)k) {
                           break;
                       }
                       countLetter++;
                   }
                   countItem += countLetter;
               }
           }
           values.add(countItem);
        }

        int[] result = new int[values.size()];

        for (int i = 0; i < values.size(); i++) {
            result[i] = values.get(i) * (i + 1);
        }

        return result;
    }
}
