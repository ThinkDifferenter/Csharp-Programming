using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = -1;
            Console.WriteLine("在0到9中输入一个数:");
            int number2 = Convert.ToInt16(Console.ReadLine());
            if(number2==number1)
            {
                Console.WriteLine("两数相同！");
            }
            if(number2>number1)
            {
                Console.WriteLine("number2>number1");
            }
            if(number2<number1)
            {
                Console.WriteLine("number2<number1");
            }
            Console.ReadLine();
        }
    }
}
