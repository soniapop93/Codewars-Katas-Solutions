/*
 * LINK: https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/train/csharp
 * 
 * ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
 * 
 * If the function is passed a valid PIN string, return true, else return false.
 * 
 * Examples (Input --> Output)
 * "1234"   -->  true
 * "12345"  -->  false
 * "a234"   -->  false
 */

namespace CodewarsKatas._7_kyu.Regex_validate_PIN_code
{
    public class RegexValidatePINcode
    {
        public static bool ValidatePin(string pin)
        {
            bool isDigit = true;
            if (pin.Length == 4 || pin.Length == 6)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (pin[i] < 48 && pin[i] > 57)
                    {
                        isDigit = false;
                        break;
                    }
                }
            }
            else
            {
                isDigit = false;
            }
            return isDigit;
        }
    }
}
