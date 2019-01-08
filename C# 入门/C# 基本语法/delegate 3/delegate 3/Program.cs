using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegate_3
{
    public class myclass
    {
        public  delegate void myclassdelegate();
        public static void show()
        {
            Console.WriteLine("hello C#");
        }
        public static void display()
        {
            Console.WriteLine("I love programing");
        }
    }
    class Program
    {
        delegate void programdelgate();
        public static void tell()
        {
            Console.WriteLine("just do it");
        }
        public static void saying()
        {
            Console.WriteLine("if cannot hold the sand,scate it!");
        }
        static void Main(string[] args)
        {
            myclass.myclassdelegate  dg1;
            programdelgate dg2;
            dg1 = new myclassdelegete(show);
            dg1 = new myclassdelegate(display);
            dg2 = new programdelgate(tell);
            dg2 = new programdelgate(saying);
            Console.ReadLine();
        }
    }
}
