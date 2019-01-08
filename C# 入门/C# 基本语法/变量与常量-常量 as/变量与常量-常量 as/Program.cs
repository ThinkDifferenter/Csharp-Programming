using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量与常量_常量_as
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[2];
            arr[1] = "test";
            arr[0] = 123;
            for(int i=0;i< arr.Length;i++)
            {
                string s = arr[i] as string;
                if(s!=null)
                {
                    Console.WriteLine(i + ":" + s);
                }
            }
            Console.ReadLine();
        }
    }
}
