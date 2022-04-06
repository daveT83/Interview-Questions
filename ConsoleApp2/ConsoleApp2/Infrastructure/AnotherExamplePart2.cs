using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure
{
    //Whats wrong with this class? (Pull up Another Example as well)
    internal class AnotherExamplePart2:AnotherExample       //what is this doing?
    {
        public bool isTrue()
        {
            return true;
        }

        public string GenerateString()
        {
            return "Generated String";
        }
    }
}
