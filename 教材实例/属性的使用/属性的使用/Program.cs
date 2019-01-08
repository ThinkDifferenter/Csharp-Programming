using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 属性的使用
{
    class Myclass
    {
        private string id = "";
        private string name = "";
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
                name = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.ID = "20154944";//属性get可写
            myclass.Name = "jiangjun";
            Console.WriteLine(myclass.ID + " " + myclass.Name);//属性get可读
            myclass.ID="20154955";
            myclass.Name="zhangming";
            Console.WriteLine(myclass.ID+ " " +myclass.Name);
            Console.ReadLine();
        }
    }
}
