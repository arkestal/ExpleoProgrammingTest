using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatingClass
    {
        public static string SplitString(string stringInput)
        {
            string[] stringNumbers;
            string answer = "";
            string splitInTwo = string.Concat(stringInput.Where(s => !Char.IsWhiteSpace(s)));

            if (splitInTwo.Contains("+"))
            {
                stringNumbers = splitInTwo.Split('+');
                answer = CalculateAddition(stringNumbers).ToString();
            }
            else if (splitInTwo.Contains("-"))
            {
                stringNumbers = splitInTwo.Split('-');
                answer = CalculateSubtraction(stringNumbers).ToString();
            }
            else if (splitInTwo.Contains("*"))
            {
                stringNumbers = splitInTwo.Split('*');
                answer = CalculateMultiplication(stringNumbers).ToString();
            }
            else if (splitInTwo.Contains("/"))
            {
                stringNumbers = splitInTwo.Split('/');
                answer = CalculateDivision(stringNumbers).ToString();
            }
            else
            {
                answer = "You did not provide one of the four basic mathematical operators!";
            }
            return answer;
        }

        public static double CalculateDivision(string[] stringNumbers)
        {
            double firstNumber = double.Parse(stringNumbers[0]);
            double secondNumber = double.Parse(stringNumbers[1]);

            double answer = firstNumber / secondNumber;

            return answer;
        }

        public static double CalculateMultiplication(string[] stringNumbers)
        {
            double firstNumber = double.Parse(stringNumbers[0]);
            double secondNumber = double.Parse(stringNumbers[1]);

            double answer = firstNumber * secondNumber;

            return answer;
        }

        public static double CalculateSubtraction(string[] stringNumbers)
        {
            double firstNumber = double.Parse(stringNumbers[0]);
            double secondNumber = double.Parse(stringNumbers[1]);

            double answer = firstNumber - secondNumber;

            return answer;
        }

        public static double CalculateAddition(string[] stringNumbers)
        {
            double firstNumber = double.Parse(stringNumbers[0]);
            double secondNumber = double.Parse(stringNumbers[1]);

            double answer = firstNumber + secondNumber;

            return answer;
        }
    }
}
