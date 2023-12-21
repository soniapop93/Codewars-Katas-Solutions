/*
LINK: https://www.codewars.com/kata/57a6633153ba33189e000074/train/java

Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance.
For empty output return (an empty list).

Consult the solution set-up for the exact data structure implementation depending on your language.

Example:

ordered_count("abracadabra") == [('a', 5), ('b', 2), ('r', 2), ('c', 1), ('d', 1)]
 */

package kyu_7.Ordered_count_of_characters;

import java.util.ArrayList;
import java.util.List;

import org.apache.commons.lang3.tuple.MutablePair;
import org.apache.commons.lang3.tuple.Pair;

public class OrderCountOfCharacters {
    public static List<Pair<Character, Integer>> orderedCount(String text) {
       List<Pair<Character, Integer>> result =  new ArrayList<>();

        for (int i = 0; i < text.length(); i++) {
            int index = contains(result, text.charAt(i));

            if (index == -1) {
                Pair<Character, Integer> pair = new MutablePair<>(text.charAt(i), 1);
                result.add(pair);
            }
            else {
                result.get(index).setValue(result.get(index).getValue() + 1);
            }
        }

        return result;
    }

    private static int contains(List<Pair<Character, Integer>> result, char c) {
        for (int i = 0; i < result.size(); i++) {
            if (result.get(i).getKey() == c) {
                return i;
            }
        }

        return -1;
    }
}
