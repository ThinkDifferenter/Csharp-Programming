using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace 实验6
{
    class Program
    {
        static string[] Str = 
            {
             "1497 陈光辉", 
            "1498 陈乾坤", 
            "1499 范涛", 
            "1500 郭勇城", 
            "1501 洪赞", 
            "1502 邓琴", 
            "1503 黄全江", 
            "1504 江鹏", 
            "1505 柯海超", 
            "1506 蓝颖", 
            "1507 李勇", 
            "1508 居梦婷", 
            "1509 罗贤新", 
            "1510 孙伟", 
            "1511 涂知情", 
            "1512 汪磊", 
            "1513 潘双双", 
            "1514 王浩东", 
            "1515 王振国", 
            "1516 谢彬彬", 
            "1517 徐士伟", 
            "1518 许苗苗", 
            "1519 颜杰", 
            "1520 曾金平", 
            "1521 张文武", 
            "1522 赵轶群", 
            "1523 周松", 
            "1524 张懿元", 
            "1525 陈龙波", 
            "1526 丁可帅"};


        static void Main()
        {
            //创建Dictionary
            Dictionary<string, string> ht = new Dictionary<string, string>();

            //将元素添加到Dictionary
            for (int i = 0; i < Str.Length; i++)
            {
                String stu = Str[i];
                string[] res = stu.Split(' ');

                ht.Add(res[0], res[1]);
            }

            string s = "";
            while (true)
            {
                Console.Write("请输入学号:");
                s = Console.ReadLine();
            
                string name = null;
                try
                {
                    name = ht[s];//捕捉此处的异常
                    Console.WriteLine("学号为：{0}的姓名是:{1}", s, name);
                    break;
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("没有找到学号为：{0}的姓名！", s);
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
