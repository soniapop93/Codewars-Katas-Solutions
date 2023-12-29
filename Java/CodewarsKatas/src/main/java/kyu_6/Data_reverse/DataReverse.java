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
        ArrayList<String> itemList = new ArrayList<>();

        int count = 0;
        String bitItem = "";

        for (int i = 0; i < data.length; i++) {
            if (count == 8 || i == data.length - 1) {
                if (i == data.length - 1) {
                    bitItem += data[data.length - 1];
                }
                itemList.add(bitItem);
                count = 0;
                bitItem = "";
            }

            bitItem += data[i];
            count++;
        }
        ArrayList<String> reversedRes = new ArrayList<>();

        for (int i = itemList.size() - 1; i >= 0; i--) {
            reversedRes.add(itemList.get(i));
        }

        for (int i = 0; i < reversedRes.size(); i++) {
            for (int j = 0; j < reversedRes.get(i).length(); j++) {
                result.add(Integer.parseInt(String.valueOf(reversedRes.get(i).charAt(j))));
            }
        }

        int[] res = new int[result.size()];

        for (int i = 0; i < result.size(); i++)
            res[i] = result.get(i);

        return res;
    }
}
