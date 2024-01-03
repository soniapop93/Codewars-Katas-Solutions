/*
LINK: https://www.codewars.com/kata/59377c53e66267c8f6000027/train/java

There is a war and nobody knows - the alphabet war!
There are two groups of hostile letters. The tension between left side letters and right side letters was too high
and the war began.

Task
Write a function that accepts fight string consists of only small letters and return who wins the fight. When the left
side wins return Left side wins!, when the right side wins return Right side wins!, in other case
return Let's fight again!.

The left side letters and their power:

 w - 4
 p - 3
 b - 2
 s - 1
The right side letters and their power:

 m - 4
 q - 3
 d - 2
 z - 1
The other letters don't have power and are only victims.

Example
AlphabetWar("z");        //=> Right side wins!
AlphabetWar("zdqmwpbs"); //=> Let's fight again!
AlphabetWar("zzzzs");    //=> Right side wins!
AlphabetWar("wwwwwwz");  //=> Left side wins!
 */

package kyu_7.Alphabet_war;

import java.util.HashMap;
import java.util.Map;

public class AlphabetWar {
    public static String alphabetWar(String fight){
        Map<String, Integer> leftSide = new HashMap<>();
        leftSide.put("w", 4);
        leftSide.put("p", 3);
        leftSide.put("b", 2);
        leftSide.put("s", 1);

        Map<String, Integer> rightSide = new HashMap<>();
        rightSide.put("m", 4);
        rightSide.put("q", 3);
        rightSide.put("d", 2);
        rightSide.put("z", 1);

        int countLeft = 0;
        int countRight = 0;

        for (int i = 0; i < fight.length(); i++) {
            if (leftSide.containsKey(String.valueOf(fight.charAt(i)))) {
                countLeft += leftSide.get(String.valueOf(fight.charAt(i)));
            }
            else if (rightSide.containsKey(String.valueOf(fight.charAt(i)))) {
                countRight += rightSide.get(String.valueOf(fight.charAt(i)));
            }
        }

        if (countLeft > countRight) {
            return "Left side wins!";
        }
        else if (countLeft < countRight) {
            return  "Right side wins!";
        }

        return "Let's fight again!";
    }
}
