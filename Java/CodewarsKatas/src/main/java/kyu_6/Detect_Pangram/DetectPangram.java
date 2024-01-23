/*
LINK: https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/java

A pangram is a sentence that contains every single letter of the alphabet at least once.
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the
letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
 */

package kyu_6.Detect_Pangram;

import java.util.HashMap;
import java.util.Map;

public class DetectPangram {
    public static boolean check(String sentence){
        boolean result = false;
        Map<String, Integer> mapLetters = generateDictLetters();

        sentence = sentence.toLowerCase();

        for (int i = 0; i < sentence.length(); i++) {
            for (Map.Entry<String, Integer> entry : mapLetters.entrySet()) {
                String key = entry.getKey();
                Integer val = entry.getValue();

                if (key.equals(String.valueOf(sentence.charAt(i)))) {
                    entry.setValue(entry.getValue() + 1);
                    break;
                }
            }
        }

        for (Map.Entry<String, Integer> entry : mapLetters.entrySet()) {
            Integer val = entry.getValue();

            if (val < 1) {
                result = false;
                break;
            }
            else {
                result = true;
            }
        }

        return result;
    }

    private static Map<String, Integer> generateDictLetters() {
        Map<String, Integer> mapLetters = new HashMap<>();

        for (int i = 97; i <= 122; i++) {
            mapLetters.put(String.valueOf((char)i), 0);
        }
        return mapLetters;
    }
}
