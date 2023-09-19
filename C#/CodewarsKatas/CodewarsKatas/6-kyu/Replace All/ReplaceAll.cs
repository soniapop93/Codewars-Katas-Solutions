/*
 * LINK: https://www.codewars.com/kata/52aaf51822e82a808100066b/train/csharp 
 * 
 * Isn't it annoying how "string".replace("find", "replace"); only replaces the first match of the find string? Write a function, replaceAll(input, find, replace); 
 * that will replace all matches of the given find string with the given replace string.
 * 
 * The function will always be called with three strings, so don't worry about validating the arguments.
 * 
 * As with the original "string".replace(find, replace), if find is an empty string, it should match in-between each character, effectively inserting replace 
 * in-between each character, including the start and end of the string. 
 * 
 */


namespace CodewarsKatas._6_kyu.Replace_All
{
    public class ReplaceAll
    {
        public static string replaceAll(string input, string find, string replace)
        {
            string result = "";

            if (find == "")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    result += replace + input[i];
                }
                result += replace;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == find[0])
                    {
                        if (find.Length <= input.Length - i)
                        {
                            bool found = true;

                            for (int j = 0; j < find.Length; j++)
                            {
                                if (find[j] != input[i + j])
                                {
                                    found = false;
                                    break;
                                }
                            }

                            if (found)
                            {
                                result += replace;
                                i += find.Length - 1;
                            }
                            else
                            {
                                result += input[i];
                            }
                        }
                        else
                        {
                            result += input[i];
                            break;
                        }
                    }
                    else
                    {
                        result += input[i];
                    }
                }
            }

            return result;
        }
    }
}
