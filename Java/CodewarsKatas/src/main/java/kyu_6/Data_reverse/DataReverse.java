/*
LINK: https://www.codewars.com/kata/569d488d61b812a0f7000015/train/java

A stream of data is received and needs to be reversed.

Each segment is 8 bits long, meaning the order of these segments needs to be reversed,
for example:

11111111  00000000  00001111  10101010
 (byte1)   (byte2)   (byte3)   (byte4)
should become:

10101010  00001111  00000000  11111111
 (byte4)   (byte3)   (byte2)   (byte1)
The total number of bits will always be a multiple of 8.

The data is given in an array as such:

[1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]
 */

package kyu_6.Data_reverse;

import java.util.ArrayList;

public class DataReverse {
    public static int[] dataReverse(int[] data) {
        ArrayList<Integer> result = new ArrayList<>();

        int count = 0;
        ArrayList<Integer> item = new ArrayList<>();

        for (int i = 0; i < data.length; i++) {
            if (count == 8) {
                for (int j = 0; j < item.size(); j++) {
                    result.add(item.get(j));
                }
                count = 0;
                item.clear();
            }

            //todo: finish it

            item.add(data[i]);
            count++;
        }

        int[] res = new int[result.size()];

        for (int i = 0; i < result.size(); i++)
            res[i] = result.get(i);

        return res;
    }
}
