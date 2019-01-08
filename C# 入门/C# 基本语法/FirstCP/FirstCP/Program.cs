using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("在下面输入一行内容，按回车键结束输入:");
            string str = Console.ReadLine();
            Console.WriteLine("你输入的字符为:{0}", str);
            Console.WriteLine("你输入的字符为:"+str);
            Console.WriteLine("你输入的内容一共有{0}个字符",str.Length);
            Console.WriteLine("你输入的内容一共有"+str.Length+"个字符");
            Console.WriteLine("按任意键结束......");
            Console.ReadLine();
        }
    }
}
