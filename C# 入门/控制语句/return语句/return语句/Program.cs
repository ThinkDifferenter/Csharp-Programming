using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return语句
{
    class Program
    {
        public string Show()
        {
            return "你好！";
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.Show());
            Console.ReadLine();
        }
    }
}
