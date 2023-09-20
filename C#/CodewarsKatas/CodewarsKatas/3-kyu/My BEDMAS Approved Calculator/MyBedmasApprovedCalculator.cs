/*
 * LINK: https://www.codewars.com/kata/56a14b6b56e5917073000022/train/csharp
 * 
 * Given a string of characters and symbols, calculate the expected result. The string consists of numbers, and the operators:
 *  
 *      /  division
 *      +  addition
 *      -  subtraction
 *      \* multiplication
 *      ^  power of
 * 
 *      As well as the brackets ()
 *      
 *      
 * Numbers can be integers or doubles.
 * 
 * Assume the string is of the correct format (no missing brackets, unmatched operators). 
 * The format of the string can also have optional whitespace between numbers and symbols, so the following are equivalent:
 * 
 *      "3+4*2"
 *      "3 +                             4*   2"
 */


namespace CodewarsKatas._3_kyu.My_BEDMAS_Approved_Calculator
{
    public class MyBedmasApprovedCalculator
    {
        public static double calculate(string s)
        {
            s = removeSpaces(s);

            s = calculateMultiplication(s);

            return 0;
        }

        private static string removeSpaces(string s)
        {

            while (s.Contains(" "))
            {
                s = s.Replace(" ", "");
            }

            return s;
        }


        private static string calculateMultiplication(string s)
        {
            if (s.Contains("*"))
            {
                string firstNumber = "";
                string secondNumber = "";

                int index = s.IndexOf("*");

                for (int i = index; i < s.Length; i++)
                {
                    if (s[i] >= 48 && s[i] <= 57)
                    {
                        firstNumber += s[i].ToString();
                    }
                    else if (i != index)
                    {
                        break;
                    }
                }
                // 4+3*5

                for (int i = index; i >= 0; i--)
                {
                    if (s[i] >= 48 && s[i] <= 57)
                    {
                        secondNumber += s[i].ToString();
                    }
                    else if (i != index)
                    {
                        break;
                    }
                }
                Console.WriteLine("");
            }
            return "";

        }


    }
}
