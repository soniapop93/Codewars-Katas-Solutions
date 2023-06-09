﻿/*
 * LINK: https://www.codewars.com/kata/5390bac347d09b7da40006f6/csharp
 * 
 * Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). 
 * Jaden is also known for some of his philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word. 
 * For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.
 * Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith,
 * but they are not capitalized in the same way he originally typed them.
 * 
 * Example:
 * 
 * Not Jaden-Cased: "How can mirrors be real if our eyes aren't real 
 * Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
*/



namespace CodewarsKatas._7_kyu.Jaden_Casing_Strings
{
    public class JadenCasingStrings
    {
        public static string ToJadenCase(string phrase)
        {
            string[] splitedPhrase = phrase.Split(" ");
            string newString = "";

            for (int i = 0; i < splitedPhrase.Length; i++)
            {
                string newWord = (splitedPhrase[i][0].ToString().ToUpper()) + splitedPhrase[i].ToString().Substring(1);
                newString = newString + newWord + " ";
            }

            return newString.Remove(newString.Length - 1, 1);
        }
    }
}
