/*
 * LINK: https://www.codewars.com/kata/56bdd0aec5dc03d7780010a5/train/csharp
 * 
 * Your task is to find the next higher number (int) with same '1'- Bits.

 * I.e. as much 1 bits as before and output next higher than input. Input is always an int in between 1 and 1<<30 (inclusive). No bad cases or special tricks...
 * 
 * Some easy examples:
 *      Input: 129  => Output: 130 (10000001 => 10000010)
 *      Input: 127 => Output: 191 (01111111 => 10111111)
 *      Input: 1 => Output: 2 (01 => 10)
 *      Input: 323423 => Output: 323439 (1001110111101011111 => 1001110111101101111)
 */

using System;

namespace CodewarsKatas._6_kyu.Next_higher_number_with_same_bits
{
    public class NextHigherNumberWithSameBits
    {
        public int nextHigher(int value)
        {
            int result = 0;

            string binaryValue = Convert.ToString(value, 2);
            int counter = 0;
            
            for (int i = 0; i < binaryValue.Length; i++)
            {
                if (binaryValue[i] == '1')
                {
                    counter++;
                }
            }

            while(true)
            {
                int newValue = value + 1;

                string newBinaryValue = Convert.ToString(newValue, 2);

                int newCounter = 0;
                for (int j = 0; j < newBinaryValue.Length; j++)
                {
                    if (newBinaryValue[j] == '1')
                    {
                        newCounter++;
                    }
                }

                if (newCounter == counter)
                {
                    result = newValue;
                    break;
                }
                value = newValue;
            }
            return result;
        }
    }
}
