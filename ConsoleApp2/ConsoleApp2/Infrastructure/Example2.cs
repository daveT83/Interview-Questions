using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure
{
    internal class Example2 : Examples  //What is this doing?
    {
        //What does this method do walk me through it.
        public override List<string> Example1(int low, int high, List<string> strs = null)  //what does the override keyword mean/do?
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
