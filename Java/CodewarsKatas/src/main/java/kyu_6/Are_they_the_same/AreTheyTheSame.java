/*
LINK: https://www.codewars.com/kata/550498447451fbbd7600041c/train/java

Given two arrays a and b write a function comp(a, b) (orcompSame(a, b)) that checks whether the two arrays have the
"same" elements, with the same multiplicities (the multiplicity of a member is the number of times it appears).
"Same" means, here, that the elements in b are the elements in a squared, regardless of the order.

Examples
Valid arrays
a = [121, 144, 19, 161, 19, 144, 19, 11]
b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
comp(a, b) returns true because in b 121 is the square of 11, 14641 is the square of 121, 20736 the square of 144,
361 the square of 19, 25921 the square of 161, and so on. It gets obvious if we write b's elements in terms of squares:

a = [121, 144, 19, 161, 19, 144, 19, 11]
b = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19]
Invalid arrays
If, for example, we change the first number to something else, comp is not returning true anymore:

a = [121, 144, 19, 161, 19, 144, 19, 11]
b = [132, 14641, 20736, 361, 25921, 361, 20736, 361]
comp(a,b) returns false because in b 132 is not the square of any number of a.

a = [121, 144, 19, 161, 19, 144, 19, 11]
b = [121, 14641, 20736, 36100, 25921, 361, 20736, 361]
comp(a,b) returns false because in b 36100 is not the square of any number of a.

 */

package kyu_6.Are_they_the_same;

import java.util.ArrayList;

public class AreTheyTheSame {
    public static boolean comp(int[] a, int[] b) {
        if ((a == null && b != null) || (a != null && b == null)) {
            return false;
        }

        if (a.length != b.length) {
            return false;
        }

        ArrayList<Integer> bList = new ArrayList<>();

        for (int i = 0; i < b.length; i++){
            bList.add(b[i]);
        }

        for (int i = 0; i < a.length; i++) {
            int squared = a[i] * a[i];
            int indexFound = contains(squared, bList);

            if (indexFound == -1) {
                return false;
            }
            bList.remove(indexFound);
        }
        return true;
    }

    private static int contains(int item, ArrayList<Integer> items) {
        for (int i = 0; i < items.size(); i++) {
            if (items.get(i) == item) {
                return i;
            }
        }
        return -1;
    }
}
