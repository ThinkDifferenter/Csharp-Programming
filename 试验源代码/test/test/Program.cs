using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stu
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList stu = new ArrayList
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
                "1526 丁可帅"
            };


            while (true)
            {
                Console.WriteLine("请输入要查找的学号：");
                string num = Console.ReadLine();

                if (num.ToLower().Equals("end"))
                {
                    break;
                }

                bool flag = true;
                foreach (string tem in stu)
                {
                    string[] noName = tem.Split(' ');
                    if (noName[0] == num)
                    {
                        Console.WriteLine("您要找的学生姓名：{0}", noName[1]);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("查无此人！");
                }

            }


            Console.WriteLine("按任意键结束！");
            Console.ReadKey();
        }
    }
}