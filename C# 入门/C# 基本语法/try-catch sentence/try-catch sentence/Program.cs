using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace try_catch_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputname;
            try
            {
                Console. WriteLine("input text:");
                inputname = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("inputname={0}", inputname);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);//printf error message
                Console.WriteLine("input error!");
                Console.ReadLine();
            }
        }
    }
}
