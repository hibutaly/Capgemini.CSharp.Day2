using System;
using static System.Console;

namespace Capgemini.CSharp.Day2
{
    internal class StringMethod
    {
        static void Main(string[] args)
        {
            string str = "        Capgemini             ";
            //WriteLine($"length:{str.Length}");

            ////clone
            //string s =str.Clone() as string;
            //WriteLine($"clone :{s}");
            //WriteLine($"remove left space:{str.TrimStart()}{str.TrimEnd()}");

            //string str1 = "Good Morning Everyone";
            //string[] test=str1.Split('o');
            ////foreach (string test2 in test)
            ////{
            ////    WriteLine(test2);
            ////}


            //WriteLine($"join string:{string.Join('p', test)}");


            //substring

            string pid = "p00001";
            int id = int.Parse(pid.Substring(1, 5));
            id++;
            WriteLine($"new id:{"p000" + id}");
            WriteLine($"id is{ id}");
            WriteLine(pid + 1);


            WriteLine(str.Substring(3, 6));











        }
    }
}
