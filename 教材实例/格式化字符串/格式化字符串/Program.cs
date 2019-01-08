using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 格式化字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I lvoe computer";
            string str2 = "I lvoe program";
            string str3 = string.Format("{0} and {1}!", str1, str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
