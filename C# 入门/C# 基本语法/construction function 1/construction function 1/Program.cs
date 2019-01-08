using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace construction_function_1
{
    public class myclass
    {
        public  myclass()
        {
            Console.WriteLine("myclass constructor function");
        }
        public void show()
        {
            Console.WriteLine("Is the opponent, but also a brother");
        }
    }
    class hisclass
    {
        public hisclass()
        {
            Console.WriteLine("hisclass constuction function");
        }
        public void show()
        {
            Console.WriteLine("Is the opponent, but also a brother too");
        }
        static void Main(string[] args)
        {
            myclass JJ = new myclass();//is construction function ,but also defined JJ to represent myclass
            JJ.show();
            Console.WriteLine("----------------------------------------");
            hisclass ZM = new hisclass();
            ZM.show();
            Console.ReadLine();
        }
    }
}
