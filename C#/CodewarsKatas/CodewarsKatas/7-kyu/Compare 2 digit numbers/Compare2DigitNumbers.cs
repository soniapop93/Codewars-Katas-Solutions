/*
 * LINK: https://www.codewars.com/kata/63f3c61dd27f3c07cc7978de/train/csharp
 * 
 * You are given 2 two-digit numbers. You should check if they are similar by comparing their numbers, and return the result in %.

 * Example:
 * 
 *  compare(13,14)=50%;
 *  compare(23,22)=50%;
 *  compare(15,51)=100%;
 *  compare(12,34)=0%.
 */ 
    
namespace CodewarsKatas._7_kyu.Compare_2_digit_numbers
{
    public class Compare2DigitNumbers
    {
        public static string Compare(int a, int b)
        {
            int count = 0;
            string x = "";

            if (a == b)
            {
                return "100%";
            }

            foreach (char c in a.ToString())
            {
                if (b.ToString().Contains(c) && x != c.ToString())
                {
                    x = c.ToString();
                    count++;
                }
            }

            if (count == a.ToString().Length)
            {
                return "100%";
            }
            else if(count == 0)
            {
                return "0%";
            }
            else
            {
                return "50%";
            }
        }
    }
}
