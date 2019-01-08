using System;
using System.Collections;

namespace Delegate
{
    //用delegate关键字声明一个委托
    //委托原型必须与预委托的方法具有相同的返回值和参数类型
    delegate void AnimalDelegate(string AnimalName);
    
    class Animal
    {
        //空的构造函数
        public Animal()
        {
            ;
        }

        //要进行委托的方法
        public void Miaow(string name)
        {
            Console.WriteLine(name + " 喵喵叫");
        }

        //要进行委托的方法
        public void Bark(string name)
        {
            Console.WriteLine(name + " 汪汪叫");
        }

        //要进行委托的方法
        public void Baa(string name)
        {
            Console.WriteLine(name + " 咩...");
        }

    }

    public class MainFunc
    {
        //创建方法使用委托作参数传入,当传入不同的name时delegate会匹配相应的方法
        static void choseAnimal(string name, AnimalDelegate delegateFun)
        {
            //委托式调用函数
            delegateFun(name);
        }
        static void Main()
        {
            /*AnimalDelegate cat = new AnimalDelegate(new Animal().Miaow);
            cat("猫咪");
            AnimalDelegate dog = new AnimalDelegate(new Animal().Bark);
            dog("狗狗");*/

            //上下的两种调用方式是等价的
            
            //函数后面一个参数传进的是一个被委托的函数
            choseAnimal("喵星人", new Animal().Miaow);
            choseAnimal("汪星人", new Animal().Bark);
            choseAnimal("喜洋洋", new Animal().Baa);

            Console.ReadLine();
        }
    }
}
