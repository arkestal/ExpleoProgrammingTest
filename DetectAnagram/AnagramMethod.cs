using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectAnagram
{
    public static class AnagramMethod
    {
        public static bool AnagramCheck(string firstInput, string secondInput)
        {
            //Making inputs into chararrays and ignoring the use of capital letters
            char[] firstInputArray = firstInput.ToLower().ToCharArray();
            char[] secondInputArray = secondInput.ToLower().ToCharArray();

            //Sorting chars by alphabetical and numerical order
            Array.Sort(firstInputArray);
            Array.Sort(secondInputArray);

            //Making the arrays back into strings
            string orderedFirstInput = new string(firstInputArray);
            string orderedSecondInput = new string(secondInputArray);

            //Checking the boolean value and returns it
            bool answer = orderedFirstInput.Equals(orderedSecondInput);

            return answer;
        }
    }
}
