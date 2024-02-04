/*
LINK: https://www.codewars.com/kata/5650ab06d11d675371000003/train/java

The aim of this kata is to split a given string into different strings of equal size
(note size of strings is passed to the method)

Example:

Split the below string into other strings of size #3

'supercalifragilisticexpialidocious'

Will return a new string
'sup erc ali fra gil ist ice xpi ali doc iou s'
Assumptions:

String length is always greater than 0
String has no spaces
Size is always positive
 */

package kyu_7.Split_In_Parts;

public class SplitInParts {
    public static String splitInParts(String s, int partLength) {
        String result = "";

        int count = 0;
        for (int i = 0; i < s.length(); i++) {
            if (count < partLength) {
                result += s.charAt(i);
            }
            else {
                result += " ";
                count = 0;
                i--;
                continue;
            }
            count++;
        }

        return result;
    }
}
