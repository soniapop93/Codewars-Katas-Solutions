/*
LINK: https://www.codewars.com/kata/5bd00c99dbc73908bb00057a/train/java

In this kata you will be given a random string of letters and tasked with
returning them as a string of comma-separated sequences sorted alphabetically,
with each sequence starting with an uppercase character followed by n-1 lowercase characters,
where n is the letter's alphabet position 1-26.

Example
alphaSeq("ZpglnRxqenU") -> "Eeeee,Ggggggg,Llllllllllll,Nnnnnnnnnnnnnn,Nnnnnnnnnnnnnn,
Pppppppppppppppp,Qqqqqqqqqqqqqqqqq,Rrrrrrrrrrrrrrrrrr,Uuuuuuuuuuuuuuuuuuuuu,Xxxxxxxxxxxxxxxxxxxxxxxx,
Zzzzzzzzzzzzzzzzzzzzzzzzzz"
Technical Details
The string will include only letters.
The first letter of each sequence is uppercase followed by n-1 lowercase.
Each sequence is separated with a comma.
Return value needs to be a string.

 */

package kyu_7.Alphabetical_Sequence;

import java.util.Arrays;

public class AlphabeticalSequence {
    public static String alphaSeq(String s) {
        String[] arrayS = new String[s.length()];
        s = s.toLowerCase();

        for (int i = 0; i < s.length(); i++) {
            int count = 1;

            for (int j = 97; j <= 122; j++) {
                if (j == s.charAt(i)) {
                    break;
                }
                count++;
            }

            arrayS[i] = generateString(String.valueOf(s.charAt(i)), count);
        }

        Arrays.sort(arrayS);

        return String.join(",", arrayS);
    }

    private static String generateString(String letter, int number) {
        String item = "";

        for (int i = 0; i < number; i++) {
            if (i == 0) {
                item += letter.toUpperCase();
            }
            else {
                item += letter.toLowerCase();
            }
        }

        return item;
    }
}