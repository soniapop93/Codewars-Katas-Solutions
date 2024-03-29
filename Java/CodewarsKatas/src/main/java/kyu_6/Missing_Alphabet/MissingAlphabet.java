/*
LINK: https://www.codewars.com/kata/5ad1e412cc2be1dbfb000016/train/java

In this Kata you have to create a function,named insertMissingLetters,
that takes in a string and outputs the same string processed in a particular way.

The function should insert only after the first occurrence of each character of the input string,
all the alphabet letters that:

-are NOT in the original string
-come after the letter of the string you are processing

Each added letter should be in uppercase, the letters of the original string will always be in lowercase.

Example:

input: "holly"

missing letters: "a,b,c,d,e,f,g,i,j,k,m,n,p,q,r,s,t,u,v,w,x,z"

output: "hIJKMNPQRSTUVWXZoPQRSTUVWXZlMNPQRSTUVWXZlyZ"

You don't need to validate input, the input string will always contain a
certain amount of lowercase letters (min 1 / max 50).
 */

package kyu_6.Missing_Alphabet;

public class MissingAlphabet {
    public static String insertMissingLetters(String str) {
        String result = "";
        String processedLetters = "";

        for (int i = 0; i < str.length(); i++) {
            String generatedLetters = generateLetters(str.charAt(i));
            String checkedLetters = checkLetters(generatedLetters, str);

            result += str.charAt(i);

            if (!processedLetters.contains(String.valueOf(str.charAt(i)))) {
                result += checkedLetters;
                processedLetters += String.valueOf(str.charAt(i));
            }
        }

        return result;
    }

    private static String generateLetters(char letter) {
        String result = "";

        for (int i = (letter - 31); i <= 90; i++) {
            result += (char)i;
        }

        return result;
    }

    private static String checkLetters(String generatedLetters, String str) {
        String result = "";

        for (int i = 0; i < generatedLetters.length(); i++) {
            if (!str.toUpperCase().contains(String.valueOf(generatedLetters.charAt(i)))) {
                result += generatedLetters.charAt(i);
            }
        }

        return result;
    }
}
