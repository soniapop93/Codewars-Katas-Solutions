/*
LINK: https://www.codewars.com/kata/659af96994b858db10e1675f/train/java

You're given a string of digits representing a sequence of consecutive natural numbers concatenated
together. Your task is to find the smallest possible first number in the sequence.
The sequence starts with a single or multi-digit number and continues with numbers each incremented by 1.
If multiple sequences can be formed, choose the one that starts with the smallest number.

Examples
"123" -> [1, 2, 3] -> 1
"91011" -> [9, 10, 11] -> 9
"17181920" -> [17, 18, 19, 20] -> 17
"9899100" -> [98, 99, 100] -> 98
"91" -> [91] -> 91
"121122123" -> [121, 122, 123] -> 121
"1235" -> [1235] -> 1235
"101" -> [101] -> 101
Constraints
Input string length: 1 - 200 characters.
Smallest possible first number: 1 - 1,000,000,000.
Remember, the key is to form a sequence of consecutive natural numbers. If the sequence matches the
input string, you've found the smallest possible first number. Experiment with different lengths for the
first number until you find a match or exhaust all possibilities.
 */

package kyu_6.The_lost_beginning;

public class TheLostBeginning {
    public static long beginning(String s) {
        int firstNumberLength = 1;
        int index = 0;
        int numberLength = 1;

        while (index + numberLength < s.length()) {
            int nextInt = Integer.parseInt(s.substring(index, index + numberLength)) + 1;
            String nextIntStr = String.valueOf(nextInt);

            if (index + numberLength + nextIntStr.length() > s.length()) {
                return Long.parseLong(s);
            } else if (s.substring(index + numberLength, index + numberLength + nextIntStr.length()).equals(nextIntStr)) {
                index += numberLength;
                numberLength = nextIntStr.length();
            } else {
                index = 0;
                firstNumberLength++;
                numberLength = firstNumberLength;
            }
        }

        return Long.parseLong(s.substring(0, firstNumberLength));
    }
}
