using System;
using System.Collections;


//入职信息类
public class EntrantInfo
{
    //姓名、编号、部门
    private string name;
    private int number;
    private string department;

    //EntrantInfo空构造函数
    public EntrantInfo()
    {
        ;
    }

    //EntrantInfo构造函数重载
    public EntrantInfo(string name, int num, string department)
    {
        this.name = name;
        this.number = num;
        this.department = department;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Num
    {
        get { return number; }
        set { number = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }
}

//声明一个 类EntrantInfo的索引器
public class IndexerForEntrantInfo
{
    private ArrayList ArrLst;//用于存放EntrantInfo类
    
    //构造函数创建一个ArrayList实例
    public IndexerForEntrantInfo()
    {
        ArrLst = new ArrayList();
    }

    //声明一个索引器：以名字和编号查找存取部门信息
    //多参数索引器,索引有多个选项
    public string this[string name, int num]
    {
        get
        {
            foreach (EntrantInfo en in ArrLst)
            {
                //判断多个索引是否同时相匹配
                if (en.Name == name && en.Num == num)
                {
                    return en.Department;
                }
            }
            return null;
        }

        set
        {
            //new关键字：C#规定，实例化一个类或者 "调用类的构造函数" 时，必须使用new关键
            //调用类的构造函数需要使new关键字
            ArrLst.Add(new EntrantInfo(name, num, value));
        }
    }

    //声明一个索引器：以编号查找名字和部门
    public ArrayList this[int num]
    {
        get
        {
            ArrayList temp = new ArrayList();
            foreach (EntrantInfo en in ArrLst)
            {
                if (en.Num == num)
                {
                    temp.Add(en);
                }
            }
            return temp;
        }
    }

    //还可以声明多个版本的索引器...
}

public class Test
{
    static void Main()
    {
        IndexerForEntrantInfo Info = new IndexerForEntrantInfo();
        //this[string name, int num]的使用
        Info["张三", 101] = "人事部";
        Info["李四", 102] = "行政部";
        Console.WriteLine(Info["张三", 101]);
        Console.WriteLine(Info["李四", 102]);

        Console.WriteLine();

        //this[int num]的使用
        foreach (EntrantInfo en in Info[102])
        {
            Console.WriteLine(en.Name);
            Console.WriteLine(en.Department);
        }

        Console.ReadLine();
    }

}