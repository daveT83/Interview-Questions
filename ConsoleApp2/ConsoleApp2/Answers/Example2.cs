using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure2
{
    internal class Example2 : Examples  //Extending the Examples class
    {
        //non recursive FizzBuzz
        //Also doesn't account for if the number is divisible by 3 and 5 and isn't inclusive of the upper bound. (slightly wrong just to differentiate it from the coding problem)
        public override List<string> Example1(int low, int high, List<string> strs = null)  //Allows to re-write the method logic with the same name, return type, and parameters.
        {
            if (strs == null)
            {
                strs = new List<string>();
            }

            for (int i = 0; i < high; i++)
            {
                if (low % 3 == 0)
                {
                    strs.Add("F");
                }
                else if (low % 5 == 0)
                {
                    strs.Add("B");
                }
                else
                {
                    strs.Add(low.ToString());
                }
            }

            return strs;
        }
    }
}
