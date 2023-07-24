/*
 * LINK: https://www.codewars.com/kata/6071ef9cbe6ec400228d9531/train/csharp
 * 
 * You have to write a calculator that receives strings for input. The dots will represent the number in the equation. There will be dots on one side, an operator, and dots again after the operator. The dots and the operator will be separated by one space.
 * 
 * Here are the following valid operators :
 * 
 * + Addition
 * - Subtraction
 * * Multiplication
 * // Integer Division
 * Your Work (Task)
 * You'll have to return a string that contains dots, as many the equation returns. If the result is 0, return the empty string. When it comes to subtraction, the first number will always be greater than or equal to the second number.
 *      
 *      Examples (Input => Output)
 *      "..... + ..............." => "...................."
 *      "..... - ..."             => ".."
 *      "..... - ."               => "...."
 *      "..... * ..."             => "..............."
 *      "..... * .."              => ".........."
 *      "..... // .."             => ".."
 *      "..... // ."              => "....."
 *      ". // .."                 => ""
 *      ".. - .."                 => ""
 */

namespace CodewarsKatas._7_kyu.Dot_Calculator
{
    public class DotCalculator
    {
        public static string Calculator(string txt)
        {
            string operatorTxt = "";
            string[] txtSplited = null;

            if (txt.Contains("+"))
            {
                txtSplited = txt.Split(" + ");
                operatorTxt = "+";
            }
            else if (txt.Contains("-"))
            {
                txtSplited = txt.Split(" - ");
                operatorTxt = "-";
            }
            else if (txt.Contains("*"))
            {
                txtSplited = txt.Split(" * ");
                operatorTxt = "*";
            }
            else if (txt.Contains("//"))
            {
                txtSplited = txt.Split(" // ");
                operatorTxt = "//";
            }

            int firstNr = txtSplited[0].Length;
            int secondNr = txtSplited[1].Length;

            int result = 0;

            if (operatorTxt.Equals("+"))
            {
                result = firstNr + secondNr;
            }
            else if (operatorTxt.Equals("-"))
            {
                result = firstNr - secondNr;
            }
            if (operatorTxt.Equals("*"))
            {
                result = firstNr * secondNr;
            }
            if (operatorTxt.Equals("//"))
            {
                result = firstNr / secondNr;
            }

            string resultStr = "";

            for (int i = 0; i < result; i++)
            {
                resultStr += ".";
            }

            return resultStr;
        }
    }
}
