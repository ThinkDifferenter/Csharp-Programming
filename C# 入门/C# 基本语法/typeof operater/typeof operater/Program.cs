using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typeof_operater
{
    public class myclass
    {
        public void show()
        {
            Console.WriteLine("hellp C#");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( typeof(int));
            Console.WriteLine( typeof(double));
            Console.WriteLine( typeof(decimal));
            Console.ReadLine();
        }
    }
}
