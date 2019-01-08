using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承及多态性_base
{
    public class Welcomemessage
    {
        protected  string name = "jiangjun";
        protected  string ID = "1920154944";
        public virtual void Welcome()
        {
            Console.WriteLine("输入正确");
            Console.WriteLine("{0}同学，欢迎你！", name);
        }
    }
    class Checkmessage:Welcomemessage
    {
        public override void Welcome()
        {
            string inputname;
            string inputID;
            Console.WriteLine("请输入你的姓名:");
            inputname = Console.ReadLine();
            Console.WriteLine("请输入你的ID:");
            inputID = Console.ReadLine();
            if(((name==inputname))&&((ID==inputID)))
            {
                base.Welcome();
            }
            else
            {
                Console.WriteLine("输入信息出错拒绝欢迎。");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Checkmesssage newclass = new Checkmesssage();
            newclass.Welcome();
            Console.ReadLine();
        }
    }
}
