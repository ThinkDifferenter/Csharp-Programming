using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism_3
{
    public class baseclass
    {
        public virtual string showmessage()
        {
            return "hello";
        }
    }
    public class firstclass : baseclass
    {
        public new string showmessage()//public override string showmessage() defferent! new operator cannot override virstual function!
        {
            return "refuse information!";
        }
    }
    public class secondclass : baseclass
    {
        public override string showmessage()
        {
            return "welcome information!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseclass[] Base = new baseclass[2];
            Base[0] = new firstclass();
            Base[1] = new secondclass();
            Console.WriteLine("{0}", Base[0].showmessage());
            Console.WriteLine("{0}", Base[1].showmessage());
            Console.ReadLine();
        }
    }
}
