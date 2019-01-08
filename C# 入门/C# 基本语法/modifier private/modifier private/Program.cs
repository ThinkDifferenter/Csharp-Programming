using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modifier_private
{
    public class myclass
    {
        private int i = 123;
        public static int show()
        {
            return i;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int j=myclass.show();
            Console.WriteLine("i={0}", j);
            Console.ReadLine();
        }
    }
}
