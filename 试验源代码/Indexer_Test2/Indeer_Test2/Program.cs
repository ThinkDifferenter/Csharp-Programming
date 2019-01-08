using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


public class IndexerClass
{
    private Hashtable name = new Hashtable();

    //索引器定义方式 this 前为"值"的数据类型,this 后中括号为索引数据类型
    //1：通过key存取Values
    public string this[int index]
    {
        get
        {
            return name[index].ToString();
        }
        set
        {
            //hashtable添加数据方法
            name.Add(index, value);
        }
    }
    //public string this[int index]
    //{
    //    get
    //    {
    //        return name[index].ToString();
    //    }

    //    set
    //    {
    //        name.Add(index, value);
    //    }
    //}

    //2：通过Values存取key
    public int this[string aName]
    {
        get
        {
            foreach (DictionaryEntry d in name)
            {
                if(d.Value.ToString() == aName)
                {
                    return Convert.ToInt32(d.Key);
                }
            }
            return -1;
        }
        set
        {
            name.Add(value, aName);
        }
    }


    //public int this[string aName]
    //{
    //    get
    //    {
    //        //Hashtable中实际存放的是DictionaryEntry(字典)类型，如果要遍历一个Hashtable，就需要使用到DictionaryEntry
    //        foreach (DictionaryEntry d in name)
    //        {
    //            if (d.Value.ToString() == aName)
    //            {
    //                return Convert.ToInt32(d.Key);
    //            }
    //        }
    //        return -1;
    //    }

    //    set
    //    {
    //        name.Add(value, aName);
    //    }
    //}
}


public class Test
{
    static void Main()
    {
        IndexerClass Indexer = new IndexerClass();

        //第一种索引器的使用
        Indexer[1] = "张三";//set访问器的使用
        Indexer[2] = "李四";
        Console.WriteLine("编号为1的名字：" + Indexer[1]);//get访问器的使用
        Console.WriteLine("编号为2的名字：" + Indexer[2]);

        Console.WriteLine();
        //第二种索引器的使用
        Console.WriteLine("张三的编号是：" + Indexer["张三"]);//get访问器的使用
        Console.WriteLine("李四的编号是：" + Indexer["李四"]);
        Indexer["王五"] = 3;//set访问器的使用
        Console.WriteLine("王五的编号是：" + Indexer["王五"]);

        Console.ReadLine();
    }
}