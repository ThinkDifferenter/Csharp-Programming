using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 异常处理
{
    class Program
    {
        class test
        {
            public int MyInt(string a, string b)
            {
                int int1;
                int int2;
                int num;
                try
                {
                    int1 = int.Parse(a);//将参数a强制转换成int类型数据
                    int2 = int.Parse(b);
                    if (int2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    num = int1 / int2;
                    return num;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("用零除整数引发异常");
                    Console.WriteLine(e.Message);
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入分子:");
                string str1=Console.ReadLine();
                Console.WriteLine("请输入分母:");
                string str2=Console.ReadLine();
                test t=new test();
                Console.WriteLine("分子除以分母的值为:",t.MyInt(str1,str2));
            }
            catch(FormatException)
            {
                Console.WriteLine("请输入数值格式数据:");
            }
            Console.WriteLine("\n以下是try-catch=finally实例\n");
            string str = "My name is jiangjun";
            object obj = str;
            try
            {
                int i = (int)obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("程序执行完毕！！！");
            }
            Console.ReadLine();
        }
    }
}
