using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验7
{
    public class Student
    {
        public string Name;
        public Student(string Name)
        {
            this.Name = Name;
        }
    }

    public class CloneCopyArray
    {
        public static void Main()
        {
            Student stu0 = new Student("studentA");
            Student stu1 = new Student("studentB");
            Student stu2 = new Student("studentC");

            Student[] arrStu = new Student[] { stu0, stu1, stu2 };

            Student[] arrStuClone = (Student[])arrStu.Clone();// 克隆数组

            Student[] arrStuCopy = new Student[arrStu.Length];
            Array.Copy(arrStu, arrStuCopy, arrStu.Length);//拷贝数组

            Console.WriteLine("原来数组内容");
            PrintIndexAndValues(arrStu);
            Console.WriteLine("克隆数组内容:");
            PrintIndexAndValues(arrStuClone);

            Console.WriteLine("改变克隆数组内容之前");
            Console.WriteLine("arrStu[2].Name: {0}", arrStu[2].Name);
            Console.WriteLine("arrStuClone[2].Name: {0}", arrStuClone[2].Name);
            Console.WriteLine("arrStuCopy[2].Name: {0}", arrStuCopy[2].Name);

            arrStuClone[2].Name = "studentBCloneNew";
            //arrStuCopy[2].Name = "studentBCopyNew";

            Console.WriteLine("改变克隆数组内容之后");
            Console.WriteLine("arrStu[2].Name: {0}", arrStu[2].Name);
            Console.WriteLine("arrStuClone[2].Name: {0}", arrStuClone[2].Name);
            Console.WriteLine("arrStuCopy[2].Name: {0}", arrStuCopy[2].Name);
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0);
                    i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
            Console.ReadLine();
        }

        
    }
}
