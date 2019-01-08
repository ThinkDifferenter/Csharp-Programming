using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modifier_internal
{
    public class myclass
    {
        internal static void show()
        {
            Console.WriteLine("the internal modifier");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass.show();
            Console.ReadLine();
        }
    }
}
