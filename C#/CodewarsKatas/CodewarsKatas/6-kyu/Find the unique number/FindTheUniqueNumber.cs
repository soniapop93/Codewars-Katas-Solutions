/*
 * LINK: https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp
 * 
 * There is an array with some numbers. All numbers are equal except for one. Try to find it!
 * 
 * findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
 * findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
 * It’s guaranteed that array contains at least 3 numbers.
 * 
 * The tests contain some very huge arrays, so think about performance.
 */

namespace CodewarsKatas._6_kyu.Find_the_unique_number
{
    public class FindTheUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            Dictionary<int, int> valuesCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (valuesCount.ContainsKey(number))
                {
                    valuesCount[number] = valuesCount[number] + 1;
                }
                else
                {
                    valuesCount[number] = 1;
                }
            }

            return valuesCount.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}
