/*
LINK: https://www.codewars.com/kata/55eeddff3f64c954c2000059/train/java

You are given a list/array which contains only integers (positive and negative).
Your job is to sum only the numbers that are the same and consecutive.
The result should be one list.

Extra credit if you solve it in one line. You can assume there is never an empty
list/array and there will always be an integer.

Same meaning: 1 == 1

1 != -1

#Examples:

[1,4,4,4,0,4,3,3,1] # should return [1,12,0,4,6,1]

"""So as you can see sum of consecutives 1 is 1
sum of 3 consecutives 4 is 12
sum of 0... and sum of 2
consecutives 3 is 6 ..."""

[1,1,7,7,3] # should return [2,14,3]
[-5,-5,7,7,12,0] # should return [-10,14,12,0]
 */

package kyu_6.Sum_consecutives;

import java.util.ArrayList;
import java.util.List;


public class SumConsecutives {
    public static List<Integer> sumConsecutives(List<Integer> s) {
        ArrayList<Integer> result = new ArrayList<>();

        int count = 1;

        for (int i = 0; i < s.size() - 1; i++) {
            if (s.get(i).equals(s.get(i + 1))) {
                count++;
            }
            else {
                result.add(count * s.get(i));
                count = 1;
                if (i == s.size() - 2) {
                    result.add(s.get(i + 1));
                }
            }
        }

        return result;
    }
}
