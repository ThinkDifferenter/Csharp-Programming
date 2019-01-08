using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Override_2
{
    public class myclass
    {
        public virtual void messageshow()
        {
            Console.WriteLine("this is in the myclass");
        }
    }
    public class hisclass : myclass
    {
        public override void messageshow()
        {
            Console.WriteLine("I have changed this messageshow funtion");
            Console.WriteLine("this is in the hisclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            hisclass newclass = new hisclass();
            newclass.messageshow();
            Console.ReadLine();
        }
    }
}
