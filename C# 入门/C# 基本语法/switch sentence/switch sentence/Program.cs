using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switch_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beauty english sentence");
            const string a = "a", b = "b", c = "c", d = "d";
            int i=0;
            //string keyin = Console.ReadLine();
            while (i<=10) 
            {
                string keyin = Console.ReadLine();
                switch (keyin)
                {
                    case a:
                        Console.WriteLine("To be or not to be ,that's a question");
                        break;
                    case b:
                        Console.WriteLine("if you cannot hold the sand,statter it!");
                        break;
                    case c:
                        Console.WriteLine("i can't live without you");
                        break;
                    case d:
                        Console.WriteLine("i don't want to live ,i want to love first and live insidentally");
                        break;
                    default:
                        Console.WriteLine("just do the best one");
                        break;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
