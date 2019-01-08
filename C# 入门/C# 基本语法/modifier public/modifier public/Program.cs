using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modifier_public
{
    public class myclass
    {
        public static string hisname = "zhangming";
    }
    class Program
    {
        public static string name="my name is jiangjun";

        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(myclass.hisname);

            Console.ReadLine();
        }
    }
}
