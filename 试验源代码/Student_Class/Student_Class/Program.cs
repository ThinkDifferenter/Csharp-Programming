using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Class
{
    public class Student
    {
        private string name;
        private string number;
        private int age;
        private int chinese;
        private int math;

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

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public int Chinese
        {
            get
            {
                return chinese;
            }
            set
            {
                chinese = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Math
        {
            get
            {
                return math;
            }
            set
            {
                math = value;
            }
        }

        public void GetTotal()
        {
            Console.WriteLine("Total scroe:" + (Math + Chinese));
        }

        public static void Comparer(Student stu1,Student stu2)
        {
            if ((stu1.Chinese + stu1.Math) > (stu2.Chinese + stu2.Math))
            {
                Console.WriteLine("First bigger");
            }
            else if ((stu1.Chinese + stu1.Math) == (stu2.Chinese + stu2.Math))
            {
                Console.WriteLine("Equal!");
            }
            else
            {
                Console.WriteLine("Later bigger");
            }
        }

        public override string ToString()
        {
            return string.Format("Name:{0},Age:{1},Math:{2},Chinese:{3},Total:{4}", Name, Age, Math, Chinese,(Chinese + Math));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student();

            stu1.Name = "jiangjun";
            stu1.Age = 20;
            stu1.Number = "4944";
            stu1.Math = 89;
            stu1.Chinese = 99;

            Console.WriteLine(stu1.ToString());

            Console.ReadLine();
        }
    }
}
