using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int  inputname;
            try//try to run some code
            {
                Console.WriteLine("input text:");
                inputname = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)//catch error
            {
                Console.WriteLine("{0}", e.Message);
            }
            finally//the finally sentence must de used after try-catch sentence(auto)
            {
                Console.WriteLine("finally senence!");
                Console.ReadLine();
            }
        }
    }
}
