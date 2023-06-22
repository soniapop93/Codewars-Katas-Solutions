/*
 * LINK: https://www.codewars.com/kata/58249d08b81f70a2fc0001a4/train/csharp
 * 
 * Given a number return the closest number to it that is divisible by 10.
 * 
 * Example input:
 * 
 * 22
 * 25
 * 37
 * 
 * Expected output:
 * 
 * 20
 * 30
 * 40
 */

namespace CodewarsKatas._7_kyu.Return_the_closest_number_multiple_of_10
{
    public class ReturnClosestNumber
    {
        public int ClosestMultiple10(int num)
        {
            if ((num % 10) == 0)
                return num;

            int tempValue = num;

            int firstCounter = 0;
            int secondCounter = 0;

            int firstValue = 0;
            int secondValue = 0;

            while(true)
            {
                if ((num % 10) == 0)
                {
                    firstValue = num;
                    break;
                }
                firstCounter++;
                num++;
            }

            num = tempValue;

            while (true)
            {

                if ((num % 10) == 0)
                {
                    secondValue = num;
                    break;
                }
                secondCounter++;
                num--;
            }

            if (firstCounter == secondCounter)
            {
                return firstValue;
            }

            else if (firstCounter < secondCounter)
            {
                return firstValue;
            }
            return secondValue;
        }
    }
}
