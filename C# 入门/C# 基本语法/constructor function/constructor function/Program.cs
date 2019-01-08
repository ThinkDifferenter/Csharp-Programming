using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_function
{
    class myclass
    {
        public myclass()
        {
            Console.WriteLine("my name is jiangjun");
        }
        public void  hisclass()
        {
            Console.WriteLine("his name is zhangming");
        }
        static void Main(string[] args)
        {
            myclass JJ = new myclass();//constructor function
            JJ.hisclass();
            Console.ReadLine();
        }
    }
}
