using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;       //what does the using statement mean here?
using System.Threading.Tasks;

namespace ConsoleApp2.Infrastructure    //what is namespace?
{
    public class Examples   //what does this line mean?
    {
        public string ID { get; private set; }  //what is this? 
                                                //What does get; mean?
                                                //What does private set; mean?

        //What are the 2 Examples methods an exampl of?
        //What is this method?
        public Examples(string id)
        {
            ID = id;
        }

        //What is this method?
        public Examples()
        {
            ID = "";
        }

        #region Example 1
        //What does this method do walk me through it.
        public virtual List<string> Example1(int low, int high, List<string> strs = null)   //what does the List<string> strs = null do/mean?
                                                                                            //what does the virutal keyword mean/do?
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

            return Example1(low + 1, high, strs);   //What is this an example of? (calling a method from inside of itself)

        }
        #endregion

        #region Example 2
        //What does this method do walk me through it.
        public bool Example2(List<Employee> list)
        {
            //What is the .Where(x => x.EmployeeNumber == ID).Select(x => x.EmployeeNumber).FirstOrDefault("").ToList() an example of?
            return list.Where(x => x.EmployeeNumber == ID).Select(x => x.EmployeeNumber).FirstOrDefault("").ToList().Count > 0 ? true : false;
        }
        #endregion

        #region Example 3
        //What does this method do walk me through it.
        public List<string> Example3(string str, Regex regex, bool isBool = false)
        {
            List<string> list;
            List<string> returnList = new List<string>();

            if (isBool)
            {
                list = Directory.EnumerateFiles(str, "*", SearchOption.AllDirectories).ToList();        //Do you know what Enumerate files is?
                                                                                                        //Do you know what GetFiles is?
                                                                                                        //What's the differance between them?
                                                                                                        //Is one better than the other why?
            }
            else
            {
                list = Directory.EnumerateFiles(str, "*", SearchOption.TopDirectoryOnly).ToList();      //Is there an easy way to get all files in all sub directories using this?
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

        private bool Example3A(Regex regex, string str) //What does private mean here?
                                                        //What are the parameters?
        {
            return regex.IsMatch(str);
        }
        #endregion

        #region Example 4
        //What does this method do walk me through it.
        public static dynamic Example4(Type type, string[] strs)
        {
            object obj = Activator.CreateInstance(type);
            PropertyInfo[] infos = type.GetProperties();

            for (int i = 0; i < infos.Length; i++)
            {
                infos[i].SetValue(obj, strs[i]);
            }
            return obj;
        }
        #endregion

        #region Example 5
        //What does this method do walk me through it.
        public List<string> Example5(string str, string str2, string str3)
        {
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(str))     //What does the using statment mean here?
            {
                string ln = "";
                while ((ln = sr.ReadLine()) != null)        //What does this line do?
                {
                    list.Add(ln.Replace(str2, str3));
                }
            }
            return list;
        }
        #endregion

    }
}
