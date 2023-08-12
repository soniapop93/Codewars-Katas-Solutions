/*
 * LINK: https://www.codewars.com/kata/5659c6d896bc135c4c00021e/train/csharp
 * 
 * Write a function that takes a positive integer and returns the next smaller positive integer containing the same digits.
 * 
 * For example:
 * 
 * nextSmaller(21) == 12
 * nextSmaller(531) == 513
 * nextSmaller(2071) == 2017
 * Return -1 (for Haskell: return Nothing, for Rust: return None), when there is no smaller number that contains the same digits. Also return -1 when the next smaller number with the same digits would require the leading digit to be zero.
 * 
 * nextSmaller(9) == -1
 * nextSmaller(111) == -1
 * nextSmaller(135) == -1
 * nextSmaller(1027) == -1 // 0721 is out since we don't write numbers with leading zeros
 * some tests will include very large numbers.
 * test data only employs positive integers.
 * 
 */

using System.Collections.Generic;

namespace CodewarsKatas._4_kyu.Next_smaller_number_with_the_same_digits
{
    public class NextSmallerNumberWithTheSameDigits
    {
        public static long NextSmaller(long n)
        {
            long temp = n;
            long result = -1;

            List<long> digits = new List<long>();


            while (temp > 0)
            {
                long digit = temp % 10;
                temp = temp / 10;
                digits.Add(digit);
            }

            while (n > 0)
            {
                n--;
                List<long> nextDigits = new List<long>();
                long currentNumber = n;

                while (currentNumber > 0)
                {
                    long digit = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    nextDigits.Add(digit);
                }

                if (digits.Count == nextDigits.Count)
                {
                    List<long> orderDigits = orderListAscendent(digits);
                    List<long> orderNextDigits = orderListAscendent(nextDigits);

                    bool same = true;

                    for (int i = 0; i < orderDigits.Count; i++)
                    {
                        if (orderDigits[i] != orderNextDigits[i])
                        {
                            same = false;
                            break;
                        }
                    }

                    if (same)
                    {
                        result = n;
                        break;
                    }
                }
            }

            return result;
        }
        
        private static List<long> orderListAscendent(List<long> digits)
        {
            bool sorted = true;

            do
            {
                sorted = true;

                for (int i = 0; i < digits.Count - 1; i++)
                {
                    if (digits[i] > digits[i + 1])
                    {
                        long aux = digits[i];

                        digits[i] = digits[i + 1];
                        digits[i + 1] = aux;
                        sorted = false;
                        break;
                    }
                    else if (digits[i] < digits[i + 1])
                    {
                        continue;
                    }
                }
            } while (!sorted);

            return digits;
        }
    }
}
