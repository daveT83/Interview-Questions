using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure2
{
    //see below
    internal class AnotherExamplePart2 : AnotherExample       //Implementing AnotherExample
    {
        public bool isTrue()
        {
            return true;
        }

        public string GenerateString()      //doesn't have the required parameter: char[] chars
        {
            return "Generated String";
        }

        //Missing method:         Employee CreateEmployee(object[] objs);
        //This needs implemented

    }
}
