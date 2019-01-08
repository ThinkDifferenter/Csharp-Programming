using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace expection_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            try
            {
                myprogram.throwexception();
            }
            catch (Exception.e)
            {
                Console.WriteLine("main function's exception");
                while (e != null)
                {
                    Console.WriteLine(" indoor:{0}", e.message);
                    e = e.inerexception;
                }
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("from main function finally block");
            }
        }
        void throwexception()
        {
            int mysize=3;
            byte[] mystreamwriter=new byte[mysize];
            int number =5;
            StreamWriter sw=new StreamWriter("exception.txt");
            try
            {
                for(byte b=0;b<number;b++)
                {
                    sw.WriteLine("byte{0}:{1}",b+1,b);
                    my
    }
}
