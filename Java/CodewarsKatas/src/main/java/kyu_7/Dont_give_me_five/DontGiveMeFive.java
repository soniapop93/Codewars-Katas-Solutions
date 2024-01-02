/*
LINK: https://www.codewars.com/kata/5813d19765d81c592200001a/train/java

In this kata you get the start number and the end number of a region and should return the count of all numbers except
numbers with a 5 in it. The start and the end number are both inclusive!

Examples:

1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
The result may contain fives. ;-)
The start number will always be smaller than the end number. Both numbers can be also negative!

 */

package kyu_7.Dont_give_me_five;

public class DontGiveMeFive {
    public static int dontGiveMeFive(int start, int end)
    {
        int count = 0;

        for (int i = start; i <= end; i++) {
            int x = Math.abs(i);
            boolean contains = false;

            while (x > 0) {
                if (x % 10 == 5) {
                    contains = true;
                    break;
                }
                x = x / 10;
            }

            if (!contains) {
                count++;
            }
        }

        return count;
    }
}
