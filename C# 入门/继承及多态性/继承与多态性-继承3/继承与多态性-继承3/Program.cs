using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态性_继承3
{
    public class Baseclass
    {
        public void show()
        {
            Console.WriteLine("这是在基类中的内容");
        }
    }
    public class Derivedclass:Baseclass
    {
        public void show()
        {
            Console.WriteLine("这是在派生类的方法隐藏了基类的方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derivedclass newclass = new Derivedclass();
            Baseclass newbaseclass = new Baseclass();
            newbaseclass.show();
            newclass.show();
            Console.ReadLine();
        }
    }
}
