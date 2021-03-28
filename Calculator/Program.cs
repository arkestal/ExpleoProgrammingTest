using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            Console.Write("Type in two numbers and a calculation method (e.g. 4 * 5 or 2 + 6): ");
            try
            {
                answer = CalculatingClass.SplitString(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
