using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口的实现与继承2
{
    interface IPepole
    {
        string Name
        {
            get;
            set;
        }
        string Sex
        {
            get;
            set;
        }
    }
    interface ITeacher : IPepole
    {
        void teach();
    }
    interface IStudent : IPepole
    {
        void study();
    }

    class Program:IPepole,ITeacher,IStudent
    {
        string name = "";
        string sex = "";
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
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        public void teach()
        {
            Console.WriteLine(Name + " " + Sex+ "\t教师");
        }
        public void study()
        {
            Console.WriteLine(Name + " " + Sex + "\t学生");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            ITeacher iteacher = program;
            iteacher.Name = "老鄢";
            iteacher.Sex = "男";
            iteacher.teach();
            IStudent istudent = program;
            istudent.Name = "蒋军";
            istudent.Sex = "男";
            istudent.study();
            Console.ReadLine();
        }
    }
}
