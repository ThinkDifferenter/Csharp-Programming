using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章_实验1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double initial = 1;
            long deno = 1;
            int flag = 1;
            while(Math.Abs(initial)>1e-8)
            {
                result = result + initial;
                deno = deno + 2;
                flag = flag * (-1);
                initial = flag / Convert.ToDouble(deno);
            }
            result = result * 4;
            Console.WriteLine("the PI is {0}", result);
            Console.ReadLine();
        }
    }
}
