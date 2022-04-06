using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;       //imports all dependancies from a given namespace
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure2    //A Grouping for different classes/interfaces/ etc regardless of the physical location on the hard drive. 2 classes in the same folder can have different namespaces.
{
    public class Examples   //Declares the Examples class
    {
        public string ID { get; private set; }  //property 
                                                //it's how you can retreive he value from this property
                                                //the property can only have its value set privately (inside this class)

        //Overloading
        //Constructor
        public Examples(string id)
        {
            ID = id;
        }

        //Constructor
        public Examples()
        {
            ID = "";
        }

        #region Example 1
        //Recursive FizzBuzz
        public virtual List<string> Example1(int low, int high, List<string> strs = null)   //If no value is passed into that parameter then the default value of null will be used.
                                                                                            //Allows you to override the method if you want.
        {
            if (strs == null)
            {
                strs = new List<string>();
            }

            if (low > high)
            {
                return strs;
            }

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

            return Example1(low + 1, high, strs);   //Recursion

        }
        #endregion

        #region Example 2
        //returns true or false. True if there are more than 0 elements found by the LINQ query and false if none are found.
        public bool Example2(List<Employee> list)
        {
            //LINQ --Side note I threw a bunch of fluff in there just to see how they would handle it.
            return list.Where(x => x.EmployeeNumber == ID).Select(x => x.EmployeeNumber).FirstOrDefault("").ToList().Count > 0 ? true : false;
        }
        #endregion

        #region Example 3
        //Returns a list of files that match a given regular expression.
        public List<string> Example3(string str, Regex regex, bool isBool = false)
        {
            List<string> list;
            List<string> returnList = new List<string>();

            if (isBool)
            {
                list = Directory.EnumerateFiles(str, "*", SearchOption.AllDirectories).ToList();        //Retrieves IEnumerable<string> of files
                                                                                                        //Retrieves IEnumerable<string> of files
                                                                                                        //Enumerate files is more efficient and results in faster execution time. GetFiles uses a Windows specific search that pulls a bunch of extra data that isn't used.
                                                                                                        //Yes Enumerate files see above.
            }
            else
            {
                list = Directory.EnumerateFiles(str, "*", SearchOption.TopDirectoryOnly).ToList();      //SearchOption.AllDirectories
            }

            foreach (string listStr in list)
            {
                if (Example3A(regex, listStr))
                {
                    returnList.Add(listStr);
                }
            }

            return returnList;
        }

        private bool Example3A(Regex regex, string str) //method is can only be called from this class
                                                        //Regex regex and string str
        {
            return regex.IsMatch(str);
        }
        #endregion

        #region Example 4
        //This is confusing and not intended for anyone to know, just gauge how they handle it... this uses reflection.
        public static dynamic Example4(Type type, string[] strs)    //the easiest way to think of dynamic is like var, but for return values. It will dynamically return any type from the method.
        {
            object obj = Activator.CreateInstance(type);    //Creates a new object of the Type that is passed in
            PropertyInfo[] infos = type.GetProperties();    //Gets all properties from the type that was passed in

            for (int i = 0; i < infos.Length; i++)          //iterates through all of the properties
            {
                infos[i].SetValue(obj, strs[i]);            //sets the value of each individual property. The value will be a string from strs[i]
                                                            //Note this is really terrible as it makes a lot of assumptions and isn't suited for general use.
            }
            return obj;                                     //returns the newly created object
        }
        #endregion

        #region Example 5
        //Reads a file into a list. Every line is a new entry in the list.
        public List<string> Example5(string str, string str2, string str3)
        {
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(str))     //using creates a new StreamReader and then properly disposes of it when the code exits the using statement.
            {
                string ln = "";
                while ((ln = sr.ReadLine()) != null)        //reads in a line from the file and places it into the ln variable. This will continue to iterate until ln is == to null, at which point we hit the end of the file and can exit the loop.
                {
                    list.Add(ln.Replace(str2, str3));
                }
            }
            return list;
        }
        #endregion

    }
}
