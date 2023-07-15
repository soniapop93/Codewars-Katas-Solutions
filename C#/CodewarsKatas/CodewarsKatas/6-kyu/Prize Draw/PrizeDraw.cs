/*
 * LINK: https://www.codewars.com/kata/5616868c81a0f281e500005c/train/csharp
 * 
 * To participate in a prize draw each one gives his/her firstname.
 * 
 * Each letter of a firstname has a value which is its rank in the English alphabet. 
 * A and a have rank 1, B and b rank 2 and so on.
 * 
 * The length of the firstname is added to the sum of these ranks hence a number som.
 * 
 * An array of random weights is linked to the firstnames and each som is multiplied by its corresponding 
 * weight to get what they call a winning number.
 * 
 * Example:
 * names: "COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH"
 * weights: [1, 4, 4, 5, 2, 1]
 * 
 * PauL -> som = length of firstname + 16 + 1 + 21 + 12 = 4 + 50 -> 54
 * The *weight* associated with PauL is 2 so PauL's *winning number* is 54 * 2 = 108.
 * Now one can sort the firstnames in decreasing order of the winning numbers. When two people have the same 
 * winning number sort them alphabetically by their firstnames.
 * 
 * Task:
 * parameters: st a string of firstnames, we an array of weights, n a rank
 * 
 * return: the firstname of the participant whose rank is n (ranks are numbered from 1)
 * 
 * Example:
 * names: "COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH"
 * weights: [1, 4, 4, 5, 2, 1]
 * n: 4
 * 
 * The function should return: "PauL"
 * Notes:
 * The weight array is at least as long as the number of names, it may be longer.
 * 
 * If st is empty return "No participants".
 * 
 * If n is greater than the number of participants then return "Not enough participants".
 * 
 * See Examples Test Cases for more examples.
 * 
 * 
 */

namespace CodewarsKatas._6_kyu.Prize_Draw
{
    public class PrizeDraw
    {
        public static string NthRank(string st, int[] we, int n)
        {
            string[] splittedNames = st.Split(",");

            List<KeyValuePair<int, string>> sumNames = new List<KeyValuePair<int, string>>();

            if (n > splittedNames.Length)
            {
                return "Not enough participants";
            }
            else if (st.Equals(""))
            {
                return "No participants";
            }
            else
            {
                for (int i = 0; i < splittedNames.Length; i++)
                {
                    int count = 0;

                    string name = splittedNames[i].ToLower();

                    for (int j = 0; j < name.Length; j++)
                    {
                        int countLetter = 1;

                        for (int k = 97; k <= 122; k++)
                        {
                            if (name[j] == k)
                            {
                                break;
                            }
                            countLetter++;
                        }
                        count += countLetter;
                    }

                    sumNames.Add(new KeyValuePair<int, string>((splittedNames[i].Length + count) * we[i], splittedNames[i]));

                }

                //TODO: not finished yet

                Console.WriteLine(String.Join(",", sumNames));
            }

            return "";
        }
    }
}
