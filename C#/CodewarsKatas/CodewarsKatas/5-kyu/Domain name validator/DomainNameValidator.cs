/*
 * LINK: https://www.codewars.com/kata/5893933e1a88084be10001a3/train/csharp
 * 
 * In this kata you have to create a domain name validator mostly compliant with RFC 1035, RFC 1123, and RFC 2181
 * 
 * For purposes of this kata, following rules apply:
 * 
 * Domain name may contain subdomains (levels), hierarchically separated by . (period) character
 * Domain name must not contain more than 127 levels, including top level (TLD)
 * Domain name must not be longer than 253 characters (RFC specifies 255, but 2 characters are reserved for trailing dot and 
 * null character for root level)
 * Level names must be composed out of lowercase and uppercase ASCII letters, digits and - (minus sign) character
 * Level names must not start or end with - (minus sign) character
 * Level names must not be longer than 63 characters
 * Top level (TLD) must not be fully numerical
 * Additionally, in this kata
 * 
 * Domain name must contain at least one subdomain (level) apart from TLD
 * Top level validation must be naive - ie. TLDs nonexistent in IANA register are still considered valid as long as they adhere 
 * to the rules given above.
 * The validation function accepts string with the full domain name and returns boolean value indicating whether the domain name 
 * is valid or not.
 * 
 * Examples:
 * 
 *      validate('codewars') == False
 *      validate('g.co') == True
 *      validate('codewars.com') == True
 *      validate('CODEWARS.COM') == True
 *      validate('sub.codewars.com') == True
 *      validate('codewars.com-') == False
 *      validate('.codewars.com') == False
 *      validate('example@codewars.com') == False
 *      validate('127.0.0.1') == False
 */

namespace CodewarsKatas._5_kyu.Domain_name_validator
{
    public class DomainNameValidator
    {
        public static bool validate(string domain)
        {
            if (String.IsNullOrEmpty(domain) || !domain.Contains("."))
            {
                return false;
            }

            int count = 0;

            for (int i = 0; i < domain.Length; i++)
            {
                if (domain[i] == '.')
                {
                    count++;
                }
            }

            string[] splittedStr = domain.Split(".");

            string lastItem = splittedStr[splittedStr.Length - 1];

            for (int i = 0; i < lastItem.Length; i++)
            {
                if (!((lastItem[i] >= 65 && lastItem[i] <= 90) || (lastItem[i] >= 97 && lastItem[i] <= 122)))
                {
                    return false;
                }
            }

            string firstItem = splittedStr[0];
            
            if (String.IsNullOrEmpty(firstItem))
            {
                return false;
            }

            int countDigits = -1;

            for (int i = 0; i < firstItem.Length; i++)
            {
                if ((firstItem[i] >= 48 && firstItem[i] <= 57))
                {
                    countDigits++;
                }
            }

            if ((countDigits == firstItem.Length))
            {
                return false;
            }


            for (int i = 0; i < splittedStr.Length - 1; i++)
            {
                for (int j = 0; j < splittedStr[i].Length; j++)
                {
                    if ((splittedStr[i][0] == 45) || (splittedStr[i][splittedStr[i].Length - 1] == 45))
                    {
                        return false;
                    }

                    if (!((splittedStr[i][j] >= 65 && splittedStr[i][j] <= 90) ||
                        (splittedStr[i][j] >= 97 && splittedStr[i][j] <= 122) ||
                        (splittedStr[i][j] >= 48 && splittedStr[i][j] <= 57) ||
                        (splittedStr[i][j] == 45)))
                    {
                        return false;
                    }
                    
                }
            }

            return true;
        }
    }
}
