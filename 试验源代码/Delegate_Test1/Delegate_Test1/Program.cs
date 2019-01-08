using System;
using System.Collections;


//委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态地赋给参数的做法，
//可以避免在程序中大量使用if-else(switch)语句，同时使得程序具有更好的可扩展性。
//使用委托可以将多个方法绑定到同一个委托变量上(通常称这个委托变量为：委托链)，当调用此变量时，会依次调用所有绑定的方法；
//于此同时，也可以通过类似绑定的方式删除方法。委托是引用数据类型


namespace Delegate
{
    //用delegate关键字声明一个委托
    //委托原型必须与预委托的方法具有相同的返回值和参数类
    //将返回为void,参数为string类型的一类函数委托给LearnDelegate
    delegate void LearnDelegate(string name);

    public class Test
    {
        //要进行委托的方法
        static void LearnA(string name)
        {
            Console.WriteLine("小王在学" + name);
        }

        static void LearnB(string name)
        {
            Console.WriteLine("小张在学" + name);
        }

        static void LearnC(string name)
        {
            Console.WriteLine("我在学"+name);
        }

        static void Main()
        {
            //创建委托实例，并把委托函数名当作参数传递给委托对象
            
            //将方法LearnA委托给learn_AD,LearnB委托给learn_BD
            LearnDelegate learn_AD = new LearnDelegate(LearnA);
            LearnDelegate learn_BD = new LearnDelegate(LearnB);
            LearnDelegate learn_CD = new LearnDelegate(LearnC);

            //通过委托对象，给绑定的函数传递参数，其实现在的learn_AD和learn_BD就是learnA和learnB的函数别名
            //在此之后就可以通过委托操作,调用或触发方法
            learn_AD("C#");
            learn_BD("C++");
            learn_CD("Computer");

            Console.ReadLine();
        }
    }
}