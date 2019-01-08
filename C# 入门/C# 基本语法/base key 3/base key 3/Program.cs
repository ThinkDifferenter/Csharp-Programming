using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_key_3
{
    public class baseclass
    {
        int num;
        public baseclass()
        {
            Console.WriteLine("this constrution1 is in baseclass");
        }
        public baseclass(int i)
        {
            num = i;
            Console.WriteLine("this construction2 is baseclass(int i)");
        }

    }
    public class derivedclass : baseclass
    {
        public derivedclass()  //using base key to transfer derivedclass construct function
            : base()
        {
            Console.WriteLine("using construction1");
        }
        public derivedclass(int i)
            : base(i)
        {
            Console.WriteLine("using construction2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derivedclass myclass = new derivedclass();//construct function transfer
            derivedclass hisclass = new derivedclass(1);
            Console.ReadLine();
        }
    }
}
