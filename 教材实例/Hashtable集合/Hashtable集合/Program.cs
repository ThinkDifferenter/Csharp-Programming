using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hashtable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add("id","1920154944");//向Hashtable中添加键值对

            HT.Add("name","jiangjun");
            HT.Add("sex","men");
            Console.WriteLine("Hashtable中的元素个数为:");
            Console.Write(HT.Count);
            Console.WriteLine("\t键\t值");
            foreach (DictionaryEntry dic in HT)//hashtable元素遍历
            {
                Console.WriteLine("\t" + dic.Key + "\t" + dic.Value);
            }
            HT.Remove("sex");//删除hashtable中的元素
            Console.WriteLine("Hashtable中的元素个数为:");
            Console.Write(HT.Count);
            Console.WriteLine("\t键\t值");
            foreach (DictionaryEntry dic in HT)
            {
                Console.WriteLine("\t" + dic.Key + "\t" + dic.Value);
            }
            Console.WriteLine("\t键\t值");
            foreach (DictionaryEntry dic in HT)
            {
                Console.WriteLine("\t" + dic.Key + "\t" + dic.Value);
            }
            Console.WriteLine(HT.Contains("id"));
            Console.WriteLine(HT.ContainsKey("name"));
            Console.WriteLine(HT.ContainsValue("jiangjun"));
            Console.ReadLine();
        }
    }
}
