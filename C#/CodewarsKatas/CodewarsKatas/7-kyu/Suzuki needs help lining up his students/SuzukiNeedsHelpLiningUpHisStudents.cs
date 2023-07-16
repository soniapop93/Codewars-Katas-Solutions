/*
 * LINK: https://www.codewars.com/kata/5701800886306a876a001031/train/csharp
 * 
 * Suzuki needs help lining up his students!
 * 
 * Today Suzuki will be interviewing his students to ensure they are progressing in their training. 
 * He decided to schedule the interviews based on the length of the students name in descending order. The students will line up and wait for their turn.
 * 
 * You will be given a string of student names. Sort them and return a list of names in descending order.
 * 
 * Here is an example input:
 * 
 * string = 'Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi'
 * Here is an example return from your function:
 * 
 *  lst = ['Takehiko',
 *         'Takayuki',
 *         'Takahiro',
 *         'Takeshi',
 *         'Takeshi',
 *         'Takashi',
 *         'Tadashi',
 *         'Takeo',
 *         'Takao']
 * Names of equal length will be returned in reverse alphabetical order (Z->A) such that:
 * 
 * string = "xxa xxb xxc xxd xa xb xc xd"
 * Returns
 * 
 * ['xxd', 'xxc', 'xxb', 'xxa', 'xd', 'xc', 'xb', 'xa']
 * 
 */

namespace CodewarsKatas._7_kyu.Suzuki_needs_help_lining_up_his_students
{
    public class SuzukiNeedsHelpLiningUpHisStudents
    {
        public static String[] LineupStudents(String a)
        {
            string[] splittedA = a.Split(" ");

            List<string> sortedNames = new List<string>();
            SortedDictionary<int, List<string>> dictNames = new SortedDictionary<int, List<string>>();

            for (int i = 0; i < splittedA.Length; i++)
            {
                if (!dictNames.ContainsKey(splittedA[i].Length))
                {
                    dictNames[splittedA[i].Length] = new List<string>();
                }

                dictNames[splittedA[i].Length].Add(splittedA[i]);
            }

            for (int i = dictNames.Keys.Count - 1; i >= 0; i--)
            {
                if (dictNames[dictNames.Keys.ElementAt(i)].Count > 1)
                {
                    List<string> sortedAlphabetically = sortAlphabetically(dictNames[dictNames.Keys.ElementAt(i)]);
                    
                    sortedNames.AddRange(sortedAlphabetically);
                }
                else
                {
                    sortedNames.Add(dictNames[dictNames.Keys.ElementAt(i)][0]);
                }
                
            }
            return sortedNames.ToArray();
        }

        private static List<string> sortAlphabetically(List<string> sortList) 
        {
            bool sorted = true;

            do
            {
                sorted = true;
                for (int i = 0; i < sortList.Count - 1; i++)
                {
                    for (int j = 0; j < sortList[i].Length; j++)
                    {
                        if (sortList[i][j] < sortList[i + 1][j])
                        {
                            string aux = sortList[i];

                            sortList[i] = sortList[i + 1];
                            sortList[i + 1] = aux;
                            sorted = false;
                            break;
                        }
                        else if (sortList[i][j] > sortList[i + 1][j])
                        {
                            break;
                        }
                    }
                }
            } while (!sorted);

            return sortList;
        }
    }
}
