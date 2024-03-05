package kyu_7.Count_the_divisors_of_a_number;

public class CountTheDivisorsOfANumber {
    public static long numberOfDivisors(int n) {
        long count = 0;

        for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
                count++;
            }
        }
        
        return count;
    }
}
