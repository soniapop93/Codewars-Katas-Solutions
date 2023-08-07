/*
 * LINK: https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp
 * 
 * In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
 *  
 *   Examples
 *   Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
 *   Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
 *   Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
 *   Notes
 *   All numbers are valid Int32, no need to validate them.
 *   There will always be at least one number in the input string.
 *   Output string must be two numbers separated by a single space, and highest number is first.
 */  


namespace CodewarsKatas._7_kyu.Highest_and_Lowest
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string result = "";

            string[] splittedNumbers = numbers.Split(" ");

            int lowest = int.MaxValue;
            int highest = int.MinValue;

            for (int i = 0; i < splittedNumbers.Length; i++) 
            {
                if (Int32.Parse(splittedNumbers[i]) > highest)
                {
                    highest = Int32.Parse(splittedNumbers[i]);
                }

                if (Int32.Parse(splittedNumbers[i]) < lowest)
                {
                    lowest = Int32.Parse(splittedNumbers[i]);
                }
            }

            result = highest.ToString() + " " + lowest.ToString();

            return result;
        }
    }
}
