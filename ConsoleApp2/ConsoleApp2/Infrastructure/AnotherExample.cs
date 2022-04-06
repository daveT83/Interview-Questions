using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure
{
    internal interface AnotherExample       //what is an interface?
                                            // what does internal mean?
    {
        //what are all of teh following?
        bool isTrue();                      
        string GenerateString(char[] chars);
        Employee CreateEmployee(object[] objs);
    }
}
