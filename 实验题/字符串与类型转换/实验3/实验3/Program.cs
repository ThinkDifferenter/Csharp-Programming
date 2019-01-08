using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this strategy can guarantee a good convergence; to the Pareto front because the search directions of operators are, too disperse and many of them may. be opposite to the Pareto front in the objective space.";
            string nstr;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; i < str.Length; j++)
                {
                    if (str[i] != ';' || str[i] != ',' || str[i] != '.')
                    {
                        nstr[j] = str[i];
                    }
                }
            }

            string[] splitstring = nstr.Split(' ');

            for (int i = 0; i < splitstring.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, splitstring[i].Substring(0, 1).ToUpper);
            }

            Console.ReadLine();
        }
    }
}
