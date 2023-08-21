/*
 * LINK: https://www.codewars.com/kata/59d9ff9f7905dfeed50000b0/train/csharp
 * 
 * Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. In the alphabet, a and b are also in positions 1 and 2. 
 * Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.
 * 
 * Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word. For example,
 * 
 * solve(["abode","ABc","xyzD"]) = [4, 3, 1]
 * See test cases for more examples.
 * 
 * Input will consist of alphabet characters, both uppercase and lowercase. No spaces.
 */

namespace CodewarsKatas._7_kyu.Alphabet_symmetry
{
    public class AlphabetSymmetry
    {
        public static List<int> Solve(List<string> arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                int countWord = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] >= 65 && arr[i][j] <= 90)
                    {
                        int count = 0;

                        for (int k = 65; k <= 90; k++)
                        {
                            if (arr[i][j] == (char)k && j == count)
                            {
                                countWord++;
                            }
                            count++;
                        }
                    }
                    else if (arr[i][j] >= 97 && arr[i][j] <= 122)
                    {
                        int count = 0;

                        for (int k = 97; k <= 122; k++)
                        {
                            if (arr[i][j] == (char)k && j == count)
                            {
                                countWord++;
                            }
                            count++;
                        }
                    }
                }
                result.Add(countWord);
            }

            return result;
        }
    }
}
