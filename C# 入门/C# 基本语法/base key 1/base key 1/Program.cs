using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_key_1
{
    public class myclass
    {
        public virtual void show()
        {
            Console.WriteLine("my name is jiangjun");
        }
    }
    class hisclass:myclass
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("his name is zhangming");
        }
        static void Main(string[] args)
        {
            hisclass sd = new hisclass();
            sd.show();
            Console.ReadLine();
        }
    }
}
