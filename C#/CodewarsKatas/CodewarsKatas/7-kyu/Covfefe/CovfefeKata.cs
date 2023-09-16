/*
 * LINK: https://www.codewars.com/kata/592fd8f752ee71ac7e00008a/train/csharp
 * 
 * Your are given a string. You must replace any occurence of the sequence coverage by covfefe, however, if you don't find the word coverage in the string, 
 * you must add covfefe at the end of the string with a leading space.
 */

namespace CodewarsKatas._7_kyu.Covfefe
{
    public class CovfefeKata
    {
        public static string Covfefe(string tweet)
        {
            return tweet.Contains("coverage") ? tweet.Replace("coverage", "covfefe") : tweet + "covfefe";
        }
    }
}
