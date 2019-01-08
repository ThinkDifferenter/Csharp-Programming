using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism_2
{
    public class baseclass
    {
        public virtual string  show()
        {
            return  "hello!";
        }
    }
    public class myclass : baseclass
    {
        public override string show()
        {
            return  "hello,his name is zhangming";
        }
    }
    public class hisclass : baseclass
    {
        public override string show()
        {
            return  "hello,his name is zhangming";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseclass[] newclass = new baseclass[2];
            newclass[0] = new myclass();
            Console.WriteLine(newclass[0].show());
            newclass[1] = new hisclass();
            Console.WriteLine(newclass[1].show());
            Console.ReadLine();
        }
    }
}
