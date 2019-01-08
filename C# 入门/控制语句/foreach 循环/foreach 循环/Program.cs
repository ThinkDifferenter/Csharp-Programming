using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//foreach很重要的特点是不必处理数组的下标
namespace foreach_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组遍历
            char[] A = { 'a', 'b', 'c' };
            foreach(char temp in A)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
