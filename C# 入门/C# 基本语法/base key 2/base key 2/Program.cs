using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_key_2
{
    public class welcomemessage
    {
        protected string myname="jiangjun";
        protected string myid="1920154944";
        protected string hisname = "zhangming";
        protected string hisid = "1920154945";
        public virtual void show()
        {
            Console.WriteLine("key in right");
           // Console.WriteLine("Hello,Welcome!");
        }
    }
    public class cheakmessage : welcomemessage
    {
        public override void show()
        {
            string inputname;
            string inputid;
            Console.WriteLine("Please input name:");
            inputname = Console.ReadLine();
            Console.WriteLine("Please inout id:");
            inputid = Console.ReadLine();
            if ((inputname == myname) && (inputid == myid))
            {
                base.show();
                Console.WriteLine("Hello {0},Welcome!",myname);
            }
            else if ((inputname == hisname) && (inputid == hisid))
            {
                base.show();
                Console.WriteLine("Hello {0},Welcome!",hisname);
            }
            else
            {
                Console.WriteLine("input error!");
            }
        }
    }
    public class myclass
    {
        static void Main(string[] args)
        {
            cheakmessage newclass = new cheakmessage();
            newclass.show();
            Console.ReadLine();
        }
    }
}