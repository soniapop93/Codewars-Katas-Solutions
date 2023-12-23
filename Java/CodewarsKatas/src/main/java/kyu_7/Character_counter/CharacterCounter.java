/*
LINK: https://www.codewars.com/kata/56786a687e9a88d1cf00005d/train/java

You are going to be given a word. Your job will be to make sure that each character in that word has
the exact same number of occurrences. You will return true if it is valid, or false if it is not.

For this kata, capitals are considered the same as lowercase letters. Therefore: "A" == "a"

The input is a string (with no spaces) containing [a-z],[A-Z],[0-9] and common symbols. The length will be 0 < length < 100.

Examples
"abcabc" is a valid word because "a" appears twice, "b" appears twice, and"c" appears twice.
"abcabcd" is NOT a valid word because "a" appears twice, "b" appears twice, "c" appears twice, but "d" only appears once!
"123abc!" is a valid word because all of the characters only appear once in the word.

 */

package kyu_7.Character_counter;

import javax.xml.crypto.dsig.keyinfo.KeyValue;
import java.util.HashMap;
import java.util.Map;

public class CharacterCounter {
    public static boolean validateWord(String word) {
        Map<String, Integer> map = new HashMap<String, Integer>();

        for (int i = 0; i < word.length(); i++) {
            if (map.containsKey(String.valueOf(word.charAt(i)))) {
               map.put(String.valueOf(word.charAt(i)), map.get(String.valueOf(word.charAt(i))) + 1);
            }
            else {
                map.put(String.valueOf(word.charAt(i)), 1);
            }
        }

        boolean isSame = false;
        int count = 0;

        for (Map.Entry<String, Integer> entry : map.entrySet()) {
           //todo: finish it
        }

        return false;
    }
}
