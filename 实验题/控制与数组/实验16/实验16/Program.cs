using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验16
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建map数组
            int[,] map = new int[20, 20];
            Random rd = new Random();

            //随机赋值到map
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int t = rd.Next(1,100);
                    if (t < 30)
                    {
                        map[i, j] = 0;
                    }
                    else
                    {
                        map[i, j] = 1;
                    }
                }
            }

            //从i=5,j=5初始位置开始
            int r=5;
            int l=5;
            for(int i=0;i<100;i++)
            {
                //all
                if (map[r - 1, l] == 0 && map[r + 1, l]==0 && map[r, l - 1]==0 && map[r, l + 1]==0)
                {
                    Console.WriteLine("四周都是障碍!");
                    break;
                }
                //up
                if (map[r - 1, l] != 0 && r-1> 0)
                {
                    r = r - 1;
                    Console.WriteLine("向上走一步");
                }
                else 
                {
                    //down
                    if (map[r + 1, l] != 0 && r+1<20)
                    {
                        r = r + 1;
                        Console.WriteLine("向下走一步");
                    }
                    else
                    {
                        //left
                        if (map[r, l - 1] != 0 && l-1>0)
                        {
                            l = l - 1;
                            Console.WriteLine("向左走一步");
                        }
                        else
                        {
                            //right
                            if (map[r, l + 1] != 0 &&l+1<20)
                            {
                                l = l + 1;
                                Console.WriteLine("向右走一步");
                            }
                        }
                    }
                }
            }

            //最终结果
            Console.WriteLine("最终位置:第{0}行,第{1}列", r, l);

            Console.ReadLine();
        }
    }
}
