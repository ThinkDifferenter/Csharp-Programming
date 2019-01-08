//***接口是对方法的抽象，而对象是对类的抽象

//接口的规定：

//(1)接口(interface)定义了一个可由类和结构实现的协定

//(2)接口可以包含方法、属性、事件和索引器

//(3)所有接口都隐式具有public访问属性

//(4)接口不能包含常量、字段、运算符、构造函数、析构函数、类型

//(5)接口不能包含abstract、public、protected、internal、private、virtual、override、static修饰符

//(6)接口不提供它所定义的成员的具体实现

//(7)一个类如果继承了接口，那么该类必须实现接口中的全部方法，包括这个接口的基接口

//(8)接口可以实现多重继承

interface IMyFirstInterface
{
    void Func();
}

//Second继承了First
interface IMySecondInterface : IMyFirstInterface
{
    //此时如果Second中具有和First中同名的方法，需要加new关键字
    new void Func();
}

//类A继承了Second接口，那么它也要实现Second所继承的First接口中的方法
class A : IMySecondInterface
{
    //因为Second和First接口中的方法同名，所以此时First中的同名方法将被覆盖，这里实现的其实是Second中的方法
    void Func()
    {

    }
}

public class Test
{
    static void Main()
    {
        A a = new A();
        a.Func();
    }
}

interface IMyFirstInterface
{
    void Func();
}

interface IMySecondInterface : IMyFirstInterface
{
    new void Func();
}

class A : IMySecondInterface
{
    //使用完全限定接口成员名作为标示符，可以解决继承接口相同名称覆盖的问题，此时这种实现的接口并不属于类的成员，仅是对接口方法的实现，所以不能使用public修饰其访问权限
    //实现的是First接口中的方法
    void IMyFirstInterface.Func()
    {
        Console.WriteLine("First");
    }

    //实现的是Second中的方法
    void IMySecondInterface.Func()
    {
        Console.WriteLine("Second");
    }
}

public class Test
{
    static void Main()
    {
        A a = new A();
        //在调用方法时，不能直接使用类的对象去调用其所实现的接口方法，只能显示的使用接口名进行访问，这也证实了这些方法不属于类的本身
        ((IMyFirstInterface)a).Func();
        ((IMySecondInterface)a).Func();
    }
}


interface IA
{
    void F();
}

interface IB : IA
{
    new void F();
}

interface IC : IA
{
    void G();
}

interface ID : IB, IC
{

}

class MyClass : ID
{
    //类继承了ID接口，所以同时要实现ID所继承的接口(IB，IC)中的方法
    public void F()
    {
        Console.WriteLine("IB.F()");
    }

    public void G()
    {

    }
}

public class Test
{
    static void Main()
    {
        MyClass c = new MyClass();
        c.F();//调用IB中的F()方法，因为类所继承的ID接口同时继承于IB接口
        ((IA)c).F();//调用IB中的F()方法，ID首先会到它继承的接口IB中查找F()方法，虽然IA中存在同名方法，但此时IA中的同名方法被覆盖，也就是说IB到IA的路径被隐藏
        ((IB)c).F();//调用IB中的F()方法，类本来就是对IB中的方法进行了实现
        ((IC)c).F();//调用IB中的F()方法，多重继承的直观隐藏规则：如果成员在任何一个访问路径中被隐藏，那么它在所有的访问路径中都被隐藏
        ((ID)c).F();//调用IB中的F()方法，因为ID继承了IB中的方法
    }
}
