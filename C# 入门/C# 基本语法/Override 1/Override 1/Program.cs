using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Override_1
{
    public class baseclass
    {
        public virtual void show()//被重写的方法必须是virtual,abstract,override关键字修饰的(这里是能有vritual)
        {
            Console.WriteLine("this is in the baseclass");
        }
    }
    public class derivedclass:baseclass
    {
        public override void show()//重写的基类方法必须与override方法具有相同的签名(即方法名)
        {
            Console.WriteLine("this is override function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derivedclass newclass =new derivedclass();
            newclass.show();
            Console.ReadLine();
        }
    }
}
