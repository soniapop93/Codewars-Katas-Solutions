package kyu_8.Get_the_mean_of_an_array;

public class GetTheMeanOfAnArray {
    public static int getAverage(int[] marks){
        int result = 0;

        int sum = 0;

        for (int i = 0; i < marks.length; i++) {
            sum += marks[i];
        }

        result = sum / marks.length;

        return result;
    }
}
