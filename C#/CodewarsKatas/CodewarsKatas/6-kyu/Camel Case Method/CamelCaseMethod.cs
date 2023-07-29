/*
 * LINK: https://www.codewars.com/kata/587731fda577b3d1b0001196/train/csharp
 * 
 * Write a method (or function, depending on the language) that converts a string to camelCase, that is, all words must have their first letter capitalized and spaces must be removed.
 * 
 * Examples (input --> output):
 * "hello case" --> "HelloCase"
 * "camel case word" --> "CamelCaseWord"
 * 
 */


namespace CodewarsKatas._6_kyu.Camel_Case_Method
{
    internal class CamelCaseMethod
    {
        public static string CamelCase(string str)
        {
            string result = "";

            string[] splittedStr = str.Split(" ");

            for (int i = 0; i < splittedStr.Length; i++)
            {
                string newWord = "";

                for (int j = 0; j < splittedStr[i].Length; j++)
                {
                    if (j == 0)
                    {
                        newWord += (char)(int)(splittedStr[i][j] - 32);
                    }
                    else
                    {
                        newWord += splittedStr[i][j];
                    }
                }
                result += newWord;
            }

            return result;
        }
    }
}
