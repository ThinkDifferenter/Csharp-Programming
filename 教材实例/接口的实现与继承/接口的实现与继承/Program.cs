using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口的实现与继承
{
    interface Imyinterface//创建接口
    {
        string ID
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        void ShowInfo()
        {
            Console.WriteLine("编号\t" + "姓名");
            Console.WriteLine(ID + "\t" + Name);
        }
    }

    class Program:Imyinterface//继承接口
    {
        string id = "";
        string name = "";
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
        public void ShowInfo()
        {
            Console.WriteLine("编号\t" + "姓名");
            Console.WriteLine(ID + "\t" + Name);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Imyinterface imyinterface = program;//接口实例化
            imyinterface.ID = "1920154944";
            imyinterface.Name = "jiangjun";
            imyinterface.ShowInfo();
            Console.ReadLine();
        }
    }
}
