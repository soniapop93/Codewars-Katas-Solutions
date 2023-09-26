/*
 * LINK: https://www.codewars.com/kata/56b7251b81290caf76000978/train/csharp
 * 
 * As you probably know, Fibonacci sequence are the numbers in the following integer sequence: 1, 1, 2, 3, 5, 8, 13... 
 * Write a method that takes the index as an argument and returns last digit from fibonacci number. Example: getLastDigit(15) - 610. 
 * Your method must return 0 because the last digit of 610 is 0. 
 * Fibonacci sequence grows very fast and value can take very big numbers (bigger than integer type can contain), so, please, be careful with overflow.
 */

namespace CodewarsKatas._7_kyu.Find_Fibonacci_last_digit
{
    public class FindFibonacciLastDigit
    {
        public static int GetLastDigit(int index)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;

            for (int i = 2; i <= index; i++)
            {
                result = (firstNumber + secondNumber) % 10;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }

    }
}
