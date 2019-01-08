using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_Test2
{
    class Program
    {
        //声明一类函数的委托
        delegate void LearnDelegate(string name);

        //要进行委托的方法
        static void LearnA(string name)
        {
            Console.WriteLine("小王在学" + name);
        }

        static void LearnB(string name)
        {
            Console.WriteLine("小张在学" + name);
        }

        static void LearnC(string name)
        {
            Console.WriteLine("我在学" + name);
        }
        static void Main()
        {
            //创建委托实例
            LearnDelegate learn_A = new LearnDelegate(LearnA);
            LearnDelegate learn_B = new LearnDelegate(LearnB);
            LearnDelegate learn_C = new LearnDelegate(LearnC);

            //声明一个委托链，不需要实例化它
            LearnDelegate DelegateLst;

            //把委托对象直接相加并赋给  委托链
            DelegateLst = learn_A + learn_B + learn_C;
            
            //给委托链传值
            //使用委托链时就触发委托给这个委托链的所用方法
            //修改委托中的参数时委托于该委托链的所有方法传入的参数均改变

            DelegateLst("C语言编程");

            Console.WriteLine();

            //同样，也可以对委托链中的委托对象进行添加和删除操作

            DelegateLst -= learn_A;//删除一个委托方法，这里使用DelegateLst -= Learn_A;效果是一样的，因为此时可以看作它是LearnA方法的一个别名
            DelegateLst("C#语言编程");
            Console.WriteLine();

            //在委托链的最后添加新的方法
            DelegateLst += learn_B;//添加一个委托方法，同样这里也可以使用DelegateLst += Learn_B;
            DelegateLst("JAVA语言编程");

            Console.ReadLine();
        }
    }
}
