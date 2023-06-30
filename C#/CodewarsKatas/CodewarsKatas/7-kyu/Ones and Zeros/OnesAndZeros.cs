/*
 * LINK: https://www.codewars.com/kata/578553c3a1b8d5c40300037c/train/csharp
 * 
 * Given an array of ones and zeroes, convert the equivalent binary value to an integer.
 * 
 * Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.
 * 
 * Examples:
 * 
 * Testing: [0, 0, 0, 1] ==> 1
 * Testing: [0, 0, 1, 0] ==> 2
 * Testing: [0, 1, 0, 1] ==> 5
 * Testing: [1, 0, 0, 1] ==> 9
 * Testing: [0, 0, 1, 0] ==> 2
 * Testing: [0, 1, 1, 0] ==> 6
 * Testing: [1, 1, 1, 1] ==> 15
 * Testing: [1, 0, 1, 1] ==> 11
 * However, the arrays can have varying lengths, not just limited to 4.
 */

namespace CodewarsKatas._7_kyu.Ones_and_Zeros
{
    public class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string strArray = String.Join("", BinaryArray);

            return Convert.ToInt32(strArray, 2);
        }
    }
}
