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
