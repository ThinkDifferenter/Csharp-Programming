using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承与多态性_继承1
{
    public class Baseclass
    {
        public void show()
        {
            Console.WriteLine("这是基类中的内容");
        }
    } 

    public class Derivedclass:Baseclass
    {
        public void shownew()
        {
            Console.WriteLine("这是在派生类中的内容");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derivedclass aclass = new Derivedclass();
            aclass.show();
            aclass.shownew();
            Console.ReadLine();
        }
    }
}
