using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验3
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建List泛型
            List<double> ListData = new List<double>();

            double Sum = 0.0;
            double Aver = 0.0;
            double Diff = 0.0;

            //输入数据
            int i = 0;
            while (true)
            {
                string str = "";
                double t=0.0;
                Console.WriteLine("请输入第{0}个浮点数，End则结束:", i + 1);
                try
                {
                    str = Console.ReadLine();
                    if (str.ToLower().Equals("end"))
                    {
                        break;
                    }

                    t = double.Parse(str);
                    i++;
                    ListData.Add(t);
                }
                catch (Exception er)
                {
                    Console.WriteLine("捕捉到异常:" + er.Message);
                    Console.WriteLine("输入浮点数格式错误，请重新输入！");
                }
            }

            //输出数据
            Console.WriteLine("您输入的数据是：");
            foreach (double adata in ListData)
            {
                Console.WriteLine("{0}", adata);
                Sum = Sum + adata;
            }

            //求平均值
            Aver = Sum / ListData.Count;
            Console.WriteLine("您输入的数据平均值为：{0}", Aver);

            //求方差
            foreach (double adata in ListData)
            {
                Diff = Diff + (Aver - adata) * (Aver - adata);   //Math.Pow(Aver - adata, 2);
            }
            Console.WriteLine("您输入的数据方差为：{0}", Diff);

            Console.ReadLine();
        }
    }
}
