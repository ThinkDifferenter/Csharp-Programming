using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_class_2
{
    public class fistclass
    {
        public virtual void information()//defined a virtual fuction
        {
            Console.WriteLine("welcome!");
        }
    }
    public abstract class secondclass : fistclass
    {
        protected string name = "jiangjun";
        protected string id = "4944";
        public abstract override void information();//override abstract funtion
    }
    public class thirdclass : secondclass
    {
        public override void information()//realize virstual funtion
        {
            //base.information(); canot do this!
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Your id is {0}", id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            thirdclass newclass = new thirdclass();
            newclass.information();
            Console.ReadLine();
        }
    }
}
