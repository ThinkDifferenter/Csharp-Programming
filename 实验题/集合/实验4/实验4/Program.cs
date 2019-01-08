using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验4
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建List泛型
            List<double> ListData = new List<double>();

            //输入数据
            int cnt=0;
            while (true)
            {
                
                string str = "";
                double t = 0.0;
                Console.WriteLine("请输入第{0}个浮点数，End则结束:", cnt + 1);
                try
                {
                    str = Console.ReadLine();
                    if (str.ToLower().Equals("end"))
                    {
                        break;
                    }

                    t = double.Parse(str);
                    cnt++;
                    ListData.Add(t);
                }
                catch (Exception er)
                {
                    Console.WriteLine("捕捉到异常:" + er.Message);
                    Console.WriteLine("输入浮点数格式错误，请重新输入！");
                }
            }

            //求最值

            double Vmax = ListData[0];
            double Vmin = ListData[0];
            for (int i = 0; i < ListData.Count; i++)
            {
                if (ListData[i] > Vmax)
                {
                    Vmax = ListData[i];
                }
                if (ListData[i] < Vmin)
                {
                    Vmin = ListData[i];
                }
            }
            Console.WriteLine("最大值:" + Vmax);
            Console.WriteLine("最小值:" + Vmin);

            //化归
            double[] X = new double[ListData.Count];

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = (ListData[i] - Vmin) / (Vmax - Vmin);
            }

            //输出化归结果
            foreach (double t in X)
            {
                Console.Write(t+"\t");
            }

            Console.ReadLine();
        }
    }
}
