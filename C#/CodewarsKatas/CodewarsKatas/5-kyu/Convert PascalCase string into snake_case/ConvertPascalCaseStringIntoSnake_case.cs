/*
 * LINK: https://www.codewars.com/kata/529b418d533b76924600085d/train/csharp
 * 
 * Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. 
 * Lowercase characters can be numbers. If the method gets a number as input, it should return a string.
 * 
 * Examples
 * "TestController"  -->  "test_controller"
 * "MoviesAndBooks"  -->  "movies_and_books"
 * "App7Test"        -->  "app7_test"
 * 1                 -->  "1"
 * 
 */

namespace CodewarsKatas._5_kyu.Convert_PascalCase_string_into_snake_case
{
    public class ConvertPascalCaseStringIntoSnake_case
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            string result = "";

            result += str[0].ToString().ToLower();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    result += "_";
                    result += ((char)(str[i] + 32)).ToString();
                }
                else
                {
                    result += str[i].ToString();
                }
            }

            return result;
        }
    }
}
