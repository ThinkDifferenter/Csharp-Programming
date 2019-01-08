using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_语句
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myname = "jim";
            const string hisname = "berl";
            const string hername = "lily";
            Console.WriteLine("你的名字是；");
            string name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myname:
                    Console.WriteLine("你好，这是你的名字"); break;
                case hisname:
                    Console.WriteLine("这是他的名字"); break;
                case hername:
                    Console.WriteLine("这是她的名字"); break;
                default:
                    Console.WriteLine("我不知道这是谁的名字"); break;

            }
            Console.ReadLine();

        }
    }
}
