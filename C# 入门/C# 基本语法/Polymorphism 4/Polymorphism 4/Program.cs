                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism_4
{
    public class webset
    {
        public int visiters = 0;
    }
    abstract public class contact
    {
        protected string name;
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    public class customer:contact
    {
        webset status=new webset();
        public override string Name
        {
            get
            {
                return namr;
            }
            set
            {
                base.name=value;
                status.visiters++;
                Console.WriteLine("第{0}次访问",status)
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
