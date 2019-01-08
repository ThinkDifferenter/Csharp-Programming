using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if_嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("你输入一个数，我可以猜:");
            n = Convert.ToInt16(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("你输入的数是1");
            }
            else if (n == 2)
            {
                Console.WriteLine("你输入的数是2");
            }
           else  if (n == 3)
            {
                Console.WriteLine("你输入的数是3");
            }
            else if (n == 4)
            {
                Console.WriteLine("你输入的数是4");
            }
            else if (n == 5)
            {
                Console.WriteLine("你输入的数是5");
            }
            else
            {
                Console.WriteLine("我不知道！");
            }
            Console.ReadLine();
        }
    }
}
