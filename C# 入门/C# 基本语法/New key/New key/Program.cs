using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New_key
{
    
    class Program
    {
        struct info
        {
            public string name;
            public int id;
        }

        //public static string name = "jiangjun";
        //public static  int id = 4944;
        static void myfunction(string name, int id)
        {
                Console.WriteLine("name:" + name);
                Console.WriteLine("id:" + id);
        }

        static void Main(string[] args)
        {
            //string name="jiangjun";
           // int id=4944;
            info mydate = new info();
            mydate.name = "jiangjun";
            mydate.id = 4944;

            myfunction(mydate.name,mydate.id);
            Console.ReadLine();
        }
    }
}
