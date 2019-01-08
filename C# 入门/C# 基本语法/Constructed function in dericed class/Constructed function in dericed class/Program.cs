using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructed_function_in_dericed_class
{
    public class baseclass
    {
        protected string name = "jiangjun";
        protected string id = "1920154944";
        public  void show()
        {
            Console.WriteLine("Welcome!");
        }
    }
    public class dericedclass : baseclass
    {
        public dericedclass()
        {
            Console.WriteLine("my name is {0}", name);
            Console.WriteLine("my id is {0}", id);
        }
        public void welcome()
        {
            Console.WriteLine("welcome {0}!", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dericedclass sd = new dericedclass();//using constructed funtion
            sd.show();
            sd.welcome();
            Console.ReadLine();
        }
    }
}
