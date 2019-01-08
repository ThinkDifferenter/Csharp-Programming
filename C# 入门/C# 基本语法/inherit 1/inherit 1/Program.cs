using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inherit_1
{
    public class baseclass
    {
        public static void show()
        {
            Console.WriteLine("this is in the baseclass");
        }
    }
    public  class derivedclass:baseclass
    {
        public static void show()
        {
            Console.WriteLine("this is in the derivedclass");
        }
    }
    class myclass
    {
        static void Main(string[] args)
        {
            derivedclass sd = new derivedclass();
            sd.show();
            Console.ReadLine();
        }
    }
}
