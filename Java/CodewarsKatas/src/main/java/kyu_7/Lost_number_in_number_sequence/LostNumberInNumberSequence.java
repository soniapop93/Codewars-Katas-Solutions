/*
LINK: An ordered sequence of numbers from 1 to N is given. One number might have deleted from it,
then the remaining numbers were mixed. Find the number that was deleted.

Example:

The starting array sequence is [1,2,3,4,5,6,7,8,9]
The mixed array with one deleted number is [3,2,4,6,7,8,1,9]
Your function should return the int 5.
If no number was deleted from the starting array, your function should return the int 0.

Note: N may be 1 or less (in the latter case, the first array will be []).
 */

package kyu_7.Lost_number_in_number_sequence;

public class LostNumberInNumberSequence {
    public static int findDeletedNumber(int[] arr, int[] mixedArr) {
        int result = 0;

        for (int i = 0; i < arr.length; i++) {
            boolean found = false;

            for (int j = 0; j < mixedArr.length; j++) {
                if (mixedArr[j] == arr[i]) {
                    found = true;
                    break;
                }
            }
            if (!found) {
                result = arr[i];
                break;
            }
        }
        return result;
    }
}
