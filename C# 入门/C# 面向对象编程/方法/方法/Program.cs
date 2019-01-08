using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    public class Stack
    {
        public object ss;
        public string str;
        int i = 1;
        public static Stack Cloned(Stack s)
        {
            Stack st = s;
            return st;
        }
        public static Stack Filp(Stack s)
        {
            Stack st = new Stack();
            for(int i=0;i<9;i++)
            {
                st.Push(s.Pop());
            }
            return st;
        }
        
        public object  Pop()
        {
            object o = str[str.Length - i];
            i++;
            return o;
        }
        public void  Push(object o)
        {
            str += o;
        }
        public override string ToString()
        {
            return str;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            for(int i=0;i<10;i++)
            {
                s.Push(i);
            }
            Stack flipped = Stack.Filp(s);
            Stack cloned = Stack.Cloned(s);
            Console.WriteLine("Original stack:" + s.ToString());
            Console.WriteLine("Filpped stack:" + flipped.ToString());
            Console.WriteLine("Cloned stack:" + cloned.ToString());
            Console.ReadLine();
        }
    }
}
