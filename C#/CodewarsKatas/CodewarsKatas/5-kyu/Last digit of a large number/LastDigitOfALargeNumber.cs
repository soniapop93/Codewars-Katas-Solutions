/*
 * LINK: https://www.codewars.com/kata/5511b2f550906349a70004e1/train/csharp
 * 
 * Define a function that takes in two non-negative integers a and b and returns the last decimal digit of ab
 * Note that a and b may be very large! 
 * 
 */

using System.Numerics;


namespace CodewarsKatas._5_kyu.Last_digit_of_a_large_number
{
    public class LastDigitOfALargeNumber
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            BigInteger result = BigInteger.ModPow(n1, n2, 10);

            return (int)result;
        }
    }
}
