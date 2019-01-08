using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_1
{
    public class myclass
    {
        delegate double useDelegate(double d1, double d2);//defined delegate

        public static double mutiply(double d1, double d2)
        {
            return d1 * d2;
        }

        public static double divide(double d1, double d2)
        {
            return d1 / d2;
        }


        static void Main(string[] args)
        {
            useDelegate dg;//define delegate dg;
            Console.WriteLine("inter two number:");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input m for mutipiy,input d for divide:");
            string str = Console.ReadLine();
            if (str == "m")
            {
                dg = new useDelegate(mutiply);//using delegate way
            }
            else
            {
                dg = new useDelegate(divide);
            }
            Console.WriteLine("the reault is {0}", dg(d1,d2));//using delefate
            Console.ReadLine();
        }
    }
    
}
