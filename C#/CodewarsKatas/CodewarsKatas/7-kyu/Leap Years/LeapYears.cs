/*
 * LINK: https://www.codewars.com/kata/526c7363236867513f0005ca/train/csharp
 * 
 * In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are:
 * 
 * years divisible by 4 are leap years
 * but years divisible by 100 are not leap years
 * but years divisible by 400 are leap years
 *  */

namespace CodewarsKatas._7_kyu.Leap_Years
{
    public class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }

            else if (year % 100 == 0)
            {
                return false;
            }
            return false;
        }
    }

}
