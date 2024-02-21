/*
LINK: https://www.codewars.com/kata/5637b03c6be7e01d99000046/train/java

One suggestion to build a satisfactory password is to start with a memorable phrase or sentence and make a
password by extracting the first letter of each word.

Even better is to replace some of those letters with numbers (e.g., the letter O can be replaced with the number 0):

instead of including i or I put the number 1 in the password;
instead of including o or O put the number 0 in the password;
instead of including s or S put the number 5 in the password.
Examples:
"Give me liberty or give me death"  --> "Gml0gmd"
"Keep Calm and Carry On"            --> "KCaC0"

 */

package kyu_7.Password_maker;

public class PasswordMaker {
    public static String makePassword(String phrase){
        String result = "";

        if (phrase.equals("")) {
            return "";
        }

        String[] splittedPhrase = phrase.split(" ");

        for (int i = 0; i < splittedPhrase.length; i++) {
            if ((splittedPhrase[i].charAt(0) == 73) || (splittedPhrase[i].charAt(0) == 105)) {
                result += "1";
            } else if ((splittedPhrase[i].charAt(0) == 79) || (splittedPhrase[i].charAt(0) == 111)) {
                result += "0";
            } else if ((splittedPhrase[i].charAt(0) == 83) || (splittedPhrase[i].charAt(0) == 115)) {
                result += "5";
            }
            else {
                result += String.valueOf(splittedPhrase[i].charAt(0));
            }
        }

        return result;
    }
}
