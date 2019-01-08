using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IReadBook
{
    interface IReadBook //接口里面不能有字段(成员变量)
    {
        void ReadBook();
    }

    class Undergraduate : IReadBook
    {
        public void ReadBook()
        {
            Console.WriteLine("本科生读教材");
        }
    }

    class Master : IReadBook
    {
        public void ReadBook()
        {
            Console.WriteLine("硕士生读中文学术期刊");
        }
    }

    class Doctor : IReadBook
    {
        public void ReadBook()
        {
            Console.WriteLine("博士生读外文学术期刊");
        }
    }

    class Program
    {
        static void ReadBook(IReadBook stu) //接口实现多态
        {
            stu.ReadBook();
        }

        static void Main(string[] args)
        {
            Undergraduate ua = new Undergraduate();
            Master ma = new Master();
            Doctor da = new Doctor();

            //将类的实例交给接口管理
            //通过类的实例实例化接口
            Console.WriteLine("接口操作方法:");
            IReadBook readbook = ua;
            
            //通过接口操做对象的数据和服务
            readbook.ReadBook();

            Console.Write("\n本科生:");
            ReadBook(ua);
            Console.Write("硕士生:");
            ReadBook(ma);
            Console.Write("博士生:");
            ReadBook(da);

            Console.ReadLine();
        }
    }
}
