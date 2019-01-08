using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_key
{
    public class basecalss
    {
        public  virtual void show()
        {
            Console.WriteLine("this is in baseclass");
        }
    }
    class derivedclass:basecalss 
    {
        public  override void show()
        {
            base.show();
            //与 Console.WriteLine("this is in baseclass");等效,在保存了基类的方法的前提下添加了新的方法
            Console.WriteLine("this is in derivedclass");
        }
       
        static void Main(string[] args)
        {
            derivedclass newclass = new derivedclass();
            newclass.show();
            Console.ReadLine();
        }
    }
}
