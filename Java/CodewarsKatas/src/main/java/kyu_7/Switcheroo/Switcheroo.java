package kyu_7.Switcheroo;

public class Switcheroo {
    public static String switcheroo(String x) {
        String result = "";

        for (int i = 0; i < x.length(); i++) {
            if (String.valueOf(x.charAt(i)).equals("a")) {
                result += "b";
            }
            else if (String.valueOf(x.charAt(i)).equals("b")) {
                result += "a";
            }
            else {
                result += String.valueOf(x.charAt(i));
            }
        }

        return result;
    }
}
