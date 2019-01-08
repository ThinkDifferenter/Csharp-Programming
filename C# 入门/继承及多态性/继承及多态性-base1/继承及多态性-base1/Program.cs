using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// base关键字不仅可以调用基类中的被重写方法，还可以调用基类中的构造函数
/// </summary>
namespace 继承及多态性_base1
{
    public class Baseclass
    {
        int num;
        public Baseclass()
        {
            Console.WriteLine("基类构造函数一:Baseclass()");
        }
        public Baseclass(int i)
        {
            num = i;
            Console.WriteLine("基类构造函数二:Baseclass(int i)");
        }
    }
    public  class Derivedclass:Baseclass
    {
        public Derivedclass() :base()//调用构造函数一
        {
        }
        public Derivedclass(int i)  :base(i)//调用构造函数二
        {

        }     
           
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derivedclass see = new Derivedclass();
            Derivedclass para = new Derivedclass(1);
            Console.ReadLine();
        }
    }
}
