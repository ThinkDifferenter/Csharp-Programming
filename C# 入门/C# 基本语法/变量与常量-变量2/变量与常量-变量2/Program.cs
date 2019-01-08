using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_变量2
{
    class Program
    {
       
        static void Write(string myString)
        {
            Console.WriteLine("myString={0}",myString);
        }
        static void Main(string[] args)
        {
            string myString = "string 定义在main()方法中";
            Write(myString);
            Console.ReadLine();
        }
    }
}
