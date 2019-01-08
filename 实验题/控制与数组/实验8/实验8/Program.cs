using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="The major reason for the good performance of the good algorithm is that the incorporation of the multhe tioperator strategy helps to select good crossover operators.";

            //foreach输出
            foreach (char ch in str)
            {
                Console.Write(char.ToUpper(ch));
            }
            
            Console.ReadLine();
        }
    }
}
