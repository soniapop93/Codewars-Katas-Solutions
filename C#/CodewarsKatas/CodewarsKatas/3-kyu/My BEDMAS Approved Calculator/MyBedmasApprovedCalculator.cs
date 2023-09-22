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

            while (s.Contains("(") && s.Contains(")"))
            {
                s = calculateOperationInBrackets(s);
            }

            s = calculateOperation(s);

            return Double.Parse(s);
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
                Tuple<string, string> numbers = identifyFirstSecondNumbers(s, "*");

                string result = (Double.Parse(numbers.Item1) * Double.Parse(numbers.Item2)).ToString();

                s = s.Replace(numbers.Item1 + "*" + numbers.Item2, result);
            }

            return s;
        }

        private static string calculateDivision(string s)
        {
            if (s.Contains("/"))
            {
                Tuple<string, string> numbers = identifyFirstSecondNumbers(s, "/");

                string result = (Double.Parse(numbers.Item1) / Double.Parse(numbers.Item2)).ToString();

                s = s.Replace(numbers.Item1 + "/" + numbers.Item2, result);
            }

            return s;
        }

        private static string calculatePower(string s)
        {
            if (s.Contains("^"))
            {
                Tuple<string, string> numbers = identifyFirstSecondNumbers(s, "^");

                string result = (Math.Pow(Double.Parse(numbers.Item1), Double.Parse(numbers.Item2))).ToString();

                s = s.Replace(numbers.Item1 + "^" + numbers.Item2, result);
            }

            return s;
        }

        private static string calculateAddition(string s)
        {
            if (s.Contains("+"))
            {
                Tuple<string, string> numbers = identifyFirstSecondNumbers(s, "+");

                string result = (Double.Parse(numbers.Item1) + Double.Parse(numbers.Item2)).ToString();

                s = s.Replace(numbers.Item1 + "+" + numbers.Item2, result);
            }

            return s;
        }

        private static string calculateSubtraction(string s)
        {
            if (s.Contains("-"))
            {
                Tuple<string, string> numbers = identifyFirstSecondNumbers(s, "-");

                string result = (Double.Parse(numbers.Item1) - Double.Parse(numbers.Item2)).ToString();

                s = s.Replace(numbers.Item1 + "-" + numbers.Item2, result);
            }

            return s;
        }

        private static Tuple<int, int> identifyBrackets(string s)
        {
            int indexOfFirstBracket = -1;
            int indexOfSecondBracket = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 40) // 40 -> ( 
                {
                    indexOfFirstBracket = i;
                }
            }

            if (indexOfFirstBracket != -1 && (s.Contains("(") && s.Contains(")")))
            {
                for (int i = indexOfFirstBracket; i < s.Length; i++)
                {
                    if (s[i] == 41) // 41 -> )
                    {
                        indexOfSecondBracket = i;
                        break;
                    }
                }
            }

            return new Tuple<int, int>(indexOfFirstBracket, indexOfSecondBracket);
        }

        private static string calculateOperationInBrackets(string s)
        {
            Tuple<int, int> indexesOfBrackets = identifyBrackets(s);

            if (indexesOfBrackets.Item1 != -1 && indexesOfBrackets.Item2 != -1)
            {
                string newStr = "";

                for (int i = indexesOfBrackets.Item1 + 1; i < indexesOfBrackets.Item2; i++)
                {
                    newStr += s[i];
                }

                if (!newStr.Equals(""))
                {
                    newStr = calculateOperation(newStr);

                    s = s.Substring(0, indexesOfBrackets.Item1) + newStr + s.Substring(indexesOfBrackets.Item2 + 1, s.Length - indexesOfBrackets.Item2 - 1);
                }
            }

            return s;
        }

        private static string calculateOperation(string s)
        {
            while (s.Contains("^"))
            {
                s = calculatePower(s);
            }

            int index = 0;

            while (index < s.Length)
            {
                if (s[index] == 42) // 42 -> *
                {
                    s = calculateMultiplication(s);
                    index = 0;
                }
                else if (s[index] == 47) // 47 -> /
                {
                    s = calculateDivision(s);
                    index = 0;
                }
                index++;
            }

            index = 0;

            while (index < s.Length)
            {
                if (s[index] == 43) // 43 -> +
                {
                    s = calculateAddition(s);
                    index = 0;
                }
                else if (s[index] == 45) // 47 -> -
                {
                    s = calculateSubtraction(s);
                    index = 0;
                }
                index++;
            }

            return s;

        }

        private static Tuple<string, string> identifyFirstSecondNumbers(string s, string sign)
        {
            string firstNumber = "";
            string secondNumber = "";

            int index = s.IndexOf(sign);

            for (int i = index; i >= 0; i--)
            {
                if ((s[i] >= 48 && s[i] <= 57) || s[i] == 46)
                {
                    firstNumber = s[i].ToString() + firstNumber;
                }
                else if (i != index)
                {
                    break;
                }
            }


            for (int i = index; i < s.Length; i++)
            {
                if ((s[i] >= 48 && s[i] <= 57) || s[i] == 46)
                {
                    secondNumber += s[i].ToString();
                }
                else if (i != index)
                {
                    break;
                }
            }

            return new Tuple<string, string>(firstNumber, secondNumber); 
        }
    }
}