package kyu_7.Halving_Sum;

public class HalvingSum {
    public static int halvingSum(int n) {
        int result = n;

        while (n > 0) {
            result += n / 2;
            n = n / 2;
        }

        return result;
    }
}
