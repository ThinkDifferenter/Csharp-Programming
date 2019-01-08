using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.06;
            int quantity;
            double subtotal, tax, totalcost, unitprice;

            Console.Out.Write("Enter the quantity:");
            quantity = int.Parse(Console.In.ReadLine());

            Console.Out.Write("Enter the unitprice:");
            unitprice = double.Parse(Console.In.ReadLine());

            subtotal = quantity * unitprice;
            tax = subtotal * TAX_RATE;
            totalcost = subtotal + tax;


            Console.Out.WriteLine("subtotal: " + subtotal.ToString("C"));
            Console.Out.WriteLine("tax: " + tax.ToString("C"));
            Console.Out.WriteLine("totalcost: " + totalcost.ToString("C"));

          //  string fmt = "subtotal:{0,8:C } tax:{1,8:C}\n " + "\n  total:{2,8:C}";

            Console.In.ReadLine();

            
        }
    }
}
