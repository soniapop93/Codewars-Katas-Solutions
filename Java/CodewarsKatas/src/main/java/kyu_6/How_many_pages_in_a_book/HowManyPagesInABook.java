/*
LINK: https://www.codewars.com/kata/622de76d28bf330057cd6af8/train/java

Every book has n pages with page numbers 1 to n. The summary is made by adding up the number of
digits of all page numbers.

Task: Given the summary, find the number of pages n the book has.

Example
If the input is summary=25, then the output must be n=17: The numbers 1 to 17 have 25 digits in
total: 1234567891011121314151617.

Be aware that you'll get enormous books having up to 100.000 pages.

All inputs will be valid.
 */

package kyu_6.How_many_pages_in_a_book;

public class HowManyPagesInABook {
    public static int amountOfPages(int summary) {
        int countPages = 0;

        for (int i = 1; i <= summary; i++) {
            String iStr = String.valueOf(i);

            for (int j = 0; j < iStr.length(); j++){
                countPages++;
            }

            if (countPages == summary) {
                return i;
            }
        }
        return 0;
    }
}
