using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//var关键字是C# 3.0开始新增的特性，称为推断类型 .
//可以赋予局部变量推断“类型”var 而不是显式类型。var 关键字指示编译器根据初始化语句右侧的表达式推断变量的类型。推断类型可以是内置类型、匿名类型、用户定义类型、.NET Framework 类库中定义的类型或任何表达式。
//上面的资料有点抽象不好理解.
//示例:
//原来我们定义变量,是要这样:
//数据类型 变量名 = 值;
//如:
//int a = 1;
//string b = "2";
//也就是说,"必须先明确地"指定你的变量是什么数据类型,才能给它赋值.这点很重要,要记住才好比较.
//现在在C# 3.0里,有了变化,就是可以不用像上面那样定义变量了.
//如:
//var a =1 ;
//那这个a,是什么类型呢?和原来的做法不一样了.
//奥妙就在这里,IDE或编译器会根据你给a 的值:1,来"推论,断定"a是一个整数类型.
//同理:
//var b = "2";
//因为给b的值是"2"这样一个字符串,所以,b就是string类型...

// 又如：

//VAR 是3.5新出的一个定义变量的类型
//其实也就是弱化类型的定义
//VAR可代替任何类型
//编译器会根据上下文来判断你到底是想用什么类型的
//至于什么情况下用到VAR   我想就是你无法确定自己将用的是什么类型
//就可以使用VAR     类似 OBJECT
//但是效率比OBJECT高点
//使用var定义变量时有以下四个特点：
//1. 必须在定义时初始化。也就是必须是var s = “abcd”形式，而不能是如下形式：
//var s;
//s = “abcd”;
//2. 一但初始化完成，就不能再给变量赋与初始化值类型不同的值了。
//3.   var要求是局部变量。
//4.   使用var定义变量和object不同，它在效率上和使用强类型方式定义变量完全一样。

namespace var_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #1: var is optional because
            // the select clause specifies a string
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;

            // Because each element in the sequence is a string, 
            // not an anonymous type, var is optional here also.
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            }

            // Example #2: var is required because
            // the select clause specifies an anonymous type
            var custQuery = from cust in customers
                            where cust.City == "Phoenix"
                            select new { cust.Name, cust.Phone };

            // var must be used because each item 
            // in the sequence is an anonymous type
            foreach (var item in custQuery)
            {
                Console.WriteLine("Name={0}, Phone={1}", item.Name, item.Phone);
            }

            Console.ReadLine();
        }
    }
}
