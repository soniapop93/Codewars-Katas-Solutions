using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
