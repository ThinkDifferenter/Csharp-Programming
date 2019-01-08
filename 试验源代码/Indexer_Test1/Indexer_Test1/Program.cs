using System;
using System.Collections;

public class IndexerClass1
{
    private string[] name = new string[2];

    //索引器必须以this关键字定义，其实这个this就是类实例化之后的对象
    public string this[int index]
    {
        //实现索引器的get方法
        get
        {
            return name[index];
        }

        //实现索引器的set方法
        set
        {
            name[index] = value;
        }
    }
}


public class Test
{
    static void Main()
    {
        //索引器的使用
        IndexerClass1 Indexer1 = new IndexerClass1();
        
        //“=”号右边对索引器赋值，其实就是调用其set方法
        Indexer1[0] = "张三";
        Indexer1[1] = "李四";
        
        //输出索引器的值，其实就是调用其get方法
        Console.WriteLine(Indexer1[0]);
        Console.WriteLine(Indexer1[1]);

        Console.ReadLine();
    }
}