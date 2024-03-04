package kyu_7.Calculate_mean_and_concatenate_string;

public class CalculateMeanAndConcatenateString {
    public static Object[] mean(char[] lst)
    {
        Object[] result = new Object[2];
        String s = "";
        int sum = 0;

        for (int i = 0; i < lst.length; i++) {
            if ((lst[i] >= 65 && lst[i] <= 90) || (lst[i] >= 97 && lst[i] <= 122)) {
                s += String.valueOf(lst[i]);
            }
            else {
                sum += Integer.valueOf(String.valueOf(lst[i]));
            }
        }
        result[0] = (double)sum / 10;
        result[1] = s;

        return result;
    }
}
