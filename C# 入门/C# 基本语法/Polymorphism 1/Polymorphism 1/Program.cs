using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism_1
{
    //多态性是指通过基类引用，依靠执行多个派生类的方法，使程序执行动态操作。
    //简单的说多态性是以同样的方法处理不同对象的能力
    //即对象运行的时刻的类型决定他的行为
    public class contact 
    {
        public virtual string showmessage()
        {
            return "hello !";
        }
    }
    public class customero : contact
    {
        public override string showmessage()
        {
            return "refuse message!";
        }
    }
    public class customert : contact//两个派生类同时继承了同一个基类
    {
        public override string showmessage()
        {
            return "welcome message!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            contact [] contacts = new contact[2];//与定义数组的方式相同，里面的每个元素代表每个不同的派生类的方法
            contacts[0] = new customert();//定义第一个元素代表customert派生类
            Console.WriteLine("{0}", contacts[0].showmessage());//调用该派生类中的方法
            contacts[1] = new customero();//定义第二个元素代表customero派生类
            Console.WriteLine("{0}", contacts[1].showmessage());//调用该派生类中的方法
            Console.ReadLine();
        }
    }
}
