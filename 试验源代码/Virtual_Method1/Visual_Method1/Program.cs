//虚方法作用：子类可以对父类中的虚方法进行重写，虚方法是多态特性的一种体现
using System;
using System.Collections;

public class Animal
{
    public Animal() { }
    public virtual void eat()
    {

    }
}

public class dog : Animal
{
    public override void eat()
    {
        //如果父类的虚方法中有我们需要的数据，可以在子类的覆盖方法中调用它：
        //base.eat();
        Console.WriteLine("狗吃骨头");
    }
}

public class cat : Animal
{
    public override void eat()
    {
        Console.WriteLine("猫吃鱼");
    }
}

public class panda : Animal
{
    public override void eat()
    {
        Console.WriteLine("熊猫吃竹子");
    }
}

public class MainFun
{
    static void Main()
    {
        Animal[] anim = new Animal[3];
        anim[0] = new dog();
        anim[1] = new cat();
        anim[2] = new panda();
        anim[0].eat();
        anim[1].eat();
        anim[2].eat();
    }
}