/*
LINK: https://www.codewars.com/kata/5966eeb31b229e44eb00007a/train/java

Write a function that converts any sentence into a V A P O R W A V E sentence.
a V A P O R W A V E sentence converts all the letters into uppercase, and adds 2 spaces between each letter
(or special character) to create this V A P O R W A V E effect.

Note that spaces should be ignored in this case.
 */

package kyu_7.Vaporcode_Kata;

import java.util.ArrayList;

public class Vaporcode {
    public static String vaporcode(String s) {
       ArrayList words = new ArrayList<>();
       s.chars().forEach(letter -> words.add(letter != 32 ? String.valueOf((char)letter).toUpperCase() + "  " : ""));

       String result = String.join("", words);

       return result.substring(0, result.length() - 2);
    }
}
