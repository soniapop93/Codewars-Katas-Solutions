import kyu_6.Missing_Alphabet.MissingAlphabet;
import kyu_6.String_array_duplicates.StringArrayDuplicates;
import kyu_6.Your_order_please.YourOrderPlease;

public class Main {
    public static void main(String[] args) {

        //System.out.println(YourOrderPlease.order("is2 Thi1s T4est 3a"));
        //System.out.println(MissingAlphabet.insertMissingLetters("hello"));
        String[] test = StringArrayDuplicates.dup(new String[] {"kelless","keenness"});

        for (String t : test) {
            System.out.println(t);
        }
    }
}
