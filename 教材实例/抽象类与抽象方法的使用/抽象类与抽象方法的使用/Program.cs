using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象类与抽象方法的使用
{
    public abstract class Myclass
    {
        private string id="";
        private string name="";
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
        public abstract void ShowInfo();
    }

    public class Driveclass : Myclass
    {
        public override void ShowInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Driveclass driveclass = new Driveclass();
            Myclass myclass = driveclass;//使用派生类对象实例化抽象类
            myclass.ID = "1920154944";
            myclass.Name = "jiangjun";
            Console.WriteLine("使用实例化的抽象类输出信息:");
            myclass.ShowInfo();
            Console.WriteLine("\n使用派生类输出信息:");
            driveclass.ID = "1920154944";
            driveclass.Name = "zhangming";
            driveclass.ShowInfo();
            Console.ReadLine();
        }
    }
}
