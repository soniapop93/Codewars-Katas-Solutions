/*
LINK: https://www.codewars.com/kata/5ce969ab07d4b7002dcaa7a1/train/java

In this Kata, you will be given a string and your task will be to return the length of the longest prefix that
is also a suffix. A prefix is the start of a string while the suffix is the end of a string. For instance,
the prefixes of the string "abcd" are ["a","ab","abc"]. The suffixes are ["bcd", "cd", "d"]. You should not overlap
the prefix and suffix.

for example:
solve("abcd") = 0, because no prefix == suffix.
solve("abcda") = 1, because the longest prefix which == suffix is "a".
solve("abcdabc") = 3. Longest prefix which == suffix is "abc".
solve("aaaa") = 2. Longest prefix which == suffix is "aa". You should not overlap the prefix and suffix
solve("aa") = 1. You should not overlap the prefix and suffix.
solve("a") = 0. You should not overlap the prefix and suffix.
All strings will be lowercase and string lengths are 1 <= length <= 500

 */

package kyu_7.String_prefix_and_suffix;

import java.util.ArrayList;

public class StringPrefixAndSuffix {
    public static int solve(String s){
        ArrayList<String> prefixes = new ArrayList<>();
        ArrayList<String> suffixes = new ArrayList<>();

        for (int i = 1; i < s.length(); i++) {
            prefixes.add(s.substring(0, i));
        }

        for (int i = s.length() - 1; i >= 1; i--) {
            suffixes.add(s.substring(i, s.length()));
        }

        int count = 0;

        for (String i : prefixes) {
            if (suffixes.contains(i) && i.length() <= s.length() / 2) {
                if (count < i.length()) {
                    count = i.length();
                }
            }
        }

        return count;
    }

}
