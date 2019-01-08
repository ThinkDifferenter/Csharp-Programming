using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    delegate void somedelegate(string sender);

    class Program
    {
        public event somedelegate sevent;
        string sender = "Event";
        public void sfun()
        {
            somefun(sender);
        }
        public void Somefun(string sender)
        {
            Console.WriteLine(sender);
        }
        public void somefun(string sender)
        {
            if (sender != null)
            {
                sevent(sender);
            }
        }
        static void Main(string[] args)
        {
            Program sd = new Program();
            sd.sevent += new somedelegate(sd.Somefun);
            sd.sfun();
            Console.ReadLine();
        }
    }
}
