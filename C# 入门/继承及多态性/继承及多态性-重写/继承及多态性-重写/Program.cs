using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//在C#中要扩展或修改继承方法，属性和事件的抽象或虚拟实现，必须用到override方法
//方法重写可以是派生类继承基类的方法
namespace 继承及多态性_重写
{
    public class Baseclass
    {
        public virtual void Showmessage()
        {
            Console.WriteLine("基类中定义的重写方法");
        }
    }
    public class Derivedclass:Baseclass
    {
        public override void Showmessage()//实现方法重写
        {
            base.Showmessage();//系统自动补全
            string name;
            string ID;
            Console.WriteLine("输入你的名字:");
            name = Console.ReadLine();
            Console.WriteLine("输入你的ID:");
            ID = Console.ReadLine();
            Console.WriteLine("你好:{0}",name);
            Console.WriteLine("你的学号是:{0}",ID);
        }
    }
    class Programsz
    {
        static void Main(string[] args)
        {
            Derivedclass declass = new Derivedclass();
            declass.Showmessage();
            Console.ReadLine();
        }
    }
}
