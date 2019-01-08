using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double discriminant, root1, root2;

            Console.Out.Write("Enter the coefficient of x squared:");
            a = int.Parse(Console.In.ReadLine());

            Console.Out.Write("Enter the coeficient if x:");
            b = int.Parse(Console.In.ReadLine());

            Console.Out.Write("Enter the constant:");
            c = int.Parse(Console.In.ReadLine());

            discriminant = Math.Pow(b, 2) - (4 * a * c);
            root1 = ((-1 * b) + Math.Sqrt(discriminant)) / (2 * a);
            root2 = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);

            Console.Out.WriteLine("root #1: " + root1);
            Console.Out.WriteLine("root #2: " + root2);

            Console.In.ReadLine();

        }
    }
}
