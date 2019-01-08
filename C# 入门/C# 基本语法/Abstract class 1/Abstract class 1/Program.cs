using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_class_1
{
    public abstract class baseclass//defined a abstract class
    {
        protected string name = "jiangjun";
        protected string id = "1920154944";
        public abstract void showmessage();//declare a abstract function but not tell the function body!
        public abstract void welcome();
    }

    public class dericedclass : baseclass
    {
        public override void showmessage()//defined a abstract function (override)
        {
            Console.WriteLine("my name is {0}", name);
        }
        public override void welcome()
        {
            Console.WriteLine("Hello ,{0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dericedclass sd = new dericedclass();
            sd.showmessage();
            sd.welcome();
            Console.ReadLine();
        }
    }
}
