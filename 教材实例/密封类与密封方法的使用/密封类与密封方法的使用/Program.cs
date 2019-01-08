using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 密封类与密封方法的使用
{
    public class Myclass1
    {
        public virtual void ShowInfo()
        {
        }
    }
    public sealed class Myclass2:Myclass1
    {
        private string id="";
        private string name = "";
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id=value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        public sealed override void ShowInfo()//密封并重写积累中的方法
        {
            Console.WriteLine(ID+" "+Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 mycalss2 = new Myclass2();
            Console.WriteLine("学号\t" + "\t姓名");
            mycalss2.ID = "1920154944";
            mycalss2.Name = "jiangjun";
            mycalss2.ShowInfo();
            Console.ReadLine();
        }
    }
}
