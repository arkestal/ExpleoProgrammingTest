using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting two inputs from user
            Console.Write("Please enter your first word: ");
            string firstInput = Console.ReadLine();
            Console.Write("Please enter your second word: ");
            string secondInput = Console.ReadLine();

            //Sending inputs into method and presents the result
            bool answer = AnagramMethod.AnagramCheck(firstInput, secondInput);
            if (answer)
            {
                Console.WriteLine($"{answer}, {firstInput} and {secondInput} are anagrams!");
            }
            else
            {
                Console.WriteLine($"{answer}, {firstInput} and {secondInput} are NOT anagrams!");
            }
            Console.ReadKey();
        }
    }
}
