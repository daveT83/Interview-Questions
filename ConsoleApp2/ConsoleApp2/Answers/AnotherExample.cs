using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure2
{
    internal interface AnotherExample       //It allows for you to have a 'base' type that provides x amount of method definitions. So this would be an example if you need to test x amount of criteria and it can expand in the fute. That way you can require a List<AnotherExample> and pass it anything that extends it. You can also call a set method and there is no room for and deviation from that in any child Classes.
                                            // this can be accessed from the current assembly
    {
        //method declarations
        bool isTrue();                      
        string GenerateString(char[] chars);
        Employee CreateEmployee(object[] objs);
    }
}
