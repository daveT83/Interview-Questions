using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Coding_Question
{
    public class FizzBuzzAnswers
    {
        public void Solution1(int low, int high)
        {
            while (low <= high)
            {
                if (low % 3 == 0 && low % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (low % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (low % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                low++;
            }
        }
        public void Solution2(int low, int high)
        {
            bool isNewLine = false;
            while (low <= high)
            {
                if (low % 3 == 0)
                {
                    Console.Write("Fizz");
                    isNewLine = true;
                }
                if (low % 5 == 0)
                {
                    Console.Write("Buzz");
                    isNewLine = true;
                }

                if (isNewLine)
                {
                    Console.WriteLine();
                    isNewLine = false;
                }
                low++;
            }
        }
    }
}
