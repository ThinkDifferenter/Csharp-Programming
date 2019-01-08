using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型5
{
    class Program
    {
        struct Student
        {
            public int ID;
            public string Name;
            public char Sex;
            public int Age;
            public struct Score
            {
                public double Math;
                public double English;
                public double Chinese;
                public double Computer;
            };
            public Score structScore;
            public string Address;
        };
        static void Main(string[] args)
        {
            Student std;
            std.ID = 1020;
            std.Name = "蒋军";
            std.Age = 19;
            std.Sex = '男';
            std.structScore.Chinese = 85;
            std.structScore.Math = 95;
            std.structScore.English = 89;
            std.structScore.Computer = 95;
            std.Address = "湖南";
            Console.WriteLine("学号:" + std.ID);
            Console.WriteLine("姓名:" + std.Name);
            Console.WriteLine("年龄:" + std.Age);
            Console.WriteLine("性别:" + std.Sex);
            Console.WriteLine("数学成绩:" + std.structScore.Math);
            Console.WriteLine("语文成绩:" + std.structScore.Chinese);
            Console.WriteLine("英语成绩:" + std.structScore.English);
            Console.WriteLine("计算机成绩:" + std.structScore.Computer);
            Console.WriteLine("住址:" + std.Address);
            Console.ReadLine();
        }
    }
}
