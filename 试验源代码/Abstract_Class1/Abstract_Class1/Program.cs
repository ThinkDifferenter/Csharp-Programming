//abstract修饰符可以和类、方法、属性、索引器及事件一起使用，在类声明中使用abstract修饰符以表明这个类只能是其他类的基类。

//抽象类的特性

//(1)抽象类不能被实例化

//(2)抽象类可以包含抽象方法和抽象访问器

//(3)不能用sealed修饰符修改抽象类，因为抽象类本身就是用来给其他类继承的

//(4)抽象类的非抽象子类必须实现其继承的所有抽象方法和抽象访问器

//抽象方法

//(1)抽象方法是隐式的虚方法

//(2)抽象方法只允许声明在抽象类中

//(3)抽象方法不能提供实际的实现，所以没有方法体；抽象方法的实现是在非抽象的派生类中以override重写实现的

//(4)抽象方法声明中不可以使用static或者virtual修饰符

//(5)abstract关键字不能修饰静态方法或静态属性

//抽象类的构造函数

//(1)不要再抽象类中定义public或protected internal访问权限的构造函数

//(2)应在抽象类中定义protected或private访问权限的构造函数

//(3)如果在抽象类中定义一个protected构造函数，则在实例化派生类时，基类可以执行初始化任务

//抽象方法和虚方法的区别

//虚方法有实现部分，并且派生类对其重写是可选的；抽象方法没有实现部分，并且强制非抽象派生类对其重写


using System;
using System.Collections;

//抽象类
public abstract class Animal
{
    protected string face;
    //声明为protected的构造函数，在实例化派生类时，基类可以执行初始化工作
    protected Animal() { this.face = "^_^"; /*抽象类构造函数初始化的例子*/}
    public abstract void eat();
    public abstract string Face
    {
        get;
    }
}

public class dog : Animal
{
    //重写基类中的抽象访问器Face
    public override string Face
    {
        get
        {
            return face;
        }
    }
    //重写基类中的抽象方法eat
    public override void eat()
    {
        Console.WriteLine("狗吃骨头 " + Face);
    }
}

public class cat : Animal
{
    public override string Face
    {
        get
        {
            return face;
        }
    }

    public override void eat()
    {
        Console.WriteLine("猫吃鱼 " + Face);
    }
}

public class panda : Animal
{
    public override string Face
    {
        get
        {
            return face;
        }
    }

    public override void eat()
    {
        Console.WriteLine("熊猫吃竹子 " + Face);
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
        Console.ReadKey();
    }
}