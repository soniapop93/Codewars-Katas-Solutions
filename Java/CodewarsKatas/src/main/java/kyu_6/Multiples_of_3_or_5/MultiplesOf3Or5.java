package kyu_6.Multiples_of_3_or_5;

public class MultiplesOf3Or5 {
    public static int solution(int number) {
        int result = 0;

        for (int i = 0; i < number; i++) {
            if ((i % 3 == 0) || (i % 5 == 0)) {
                result += i;
            }
        }

        return result;
    }
}
