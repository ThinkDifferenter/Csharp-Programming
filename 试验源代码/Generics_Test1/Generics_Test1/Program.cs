﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//泛型（generic）是C#语言2.0和通用语言运行时（CLR）的一个新特性。泛型为.NET框架引入了类型参数（type parameters）的概念。类型参数使得设计类和方法时，不必确定一个或多个具体参数，其的具体参数可延迟到客户代码中声明、实现。这意味着使用泛型的类型参数T，写一个类MyList<T>，客户代码可以这样调用：MyList<int>， MyList<string>或 MyList<MyClass>。这避免了运行时类型转换或装箱操作的代价和风险。
 
 
 
//目录
//C# 中的泛型. 1
//一、泛型概述. 2
//二、泛型的优点. 5
//三、泛型类型参数. 7
//四、类型参数的约束. 8
//五、泛型类. 11
//六、泛型接口. 13
//七、泛型方法. 19
//八、泛型委托. 21
//九、泛型代码中的default 关键字. 23
//十、C++ 模板和C# 泛型的区别. 24
//十一 、运行时中的泛型. 25
//十二 、基础类库中的泛型. 27
 
 

 

//一、泛型概述
//    泛型类和泛型方法兼复用性、类型安全和高效率于一身，是与之对应的非泛型的类和方法所不及。泛型广泛用于容器（collections）和对容器操作的方法中。.NET框架2.0的类库提供一个新的命名空间System.Collections.Generic，其中包含了一些新的基于泛型的容器类。要查找新的泛型容器类（collection classes）的示例代码，请参见基础类库中的泛型。当然，你也可以创建自己的泛型类和方法，以提供你自己的泛化的方案和设计模式，这是类型安全且高效的。下面的示例代码以一个简单的泛型链表类作为示范。（多数情况下，推荐使用由.NET框架类库提供的List<T>类，而不是创建自己的表。）类型参数T在多处使用，具体类型通常在这些地方来指明表中元素的类型。类型参数T有以下几种用法：
//l        在AddHead方法中，作为方法参数的类型。
//l        在公共方法GetNext中，以及嵌套类Node的 Data属性中作为返回值的类型。
//l        在嵌套类中，作为私有成员data的类型。
 
//注意一点，T对嵌套的类Node也是有效的。当用一个具体类来实现MyList<T>时——如MyList<int>——每个出现过的T都要用int代替。
 
//using System;
//using System.Collections.Generic;
 
//public class MyList<T> //type parameter T in angle brackets
//    {
//        private Node head;
//// The nested type is also generic on T.
//        private class Node          
//        {
//            private Node next;
////T as private member data type:
//            private T data;         
////T used in non-generic constructor:
//            public Node(T t)        
//            {
//                next = null;
//                data = t;
//            }
//            public Node Next
//            {
//                get { return next; }
//                set { next = value; }
//            }
////T as return type of property:
//            public T Data           
//            {
//                get { return data; }
//                set { data = value; }
//            }
//        }
//        public MyList()
//        {
//            head = null;
//        }
////T as method parameter type:
//        public void AddHead(T t)    
//        {
//            Node n = new Node(t);
//            n.Next = head;
//            head = n;
//        }
 
//        public IEnumerator<T> GetEnumerator()
//        {
//            Node current = head;
 
//            while (current != null)
//            {
//                yield return current.Data;
//                current = current.Next;
//            }
//        }
//    }
 
//下面的示例代码演示了客户代码如何使用泛型类MyList<T>，来创建一个整数表。通过简单地改变参数的类型，很容易改写下面的代码，以创建字符串或其他自定义类型的表。
 
//class Program
//    {
//        static void Main(string[] args)
//        {
////int is the type argument.
//           MyList<int> list = new MyList<int>();
//            for (int x = 0; x < 10; x++)
//                list.AddHead(x);
 
//            foreach (int i in list)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine("Done");
//        }
//    }

 

//二、泛型的优点
//针对早期版本的通用语言运行时和C#语言的局限，泛型提供了一个解决方案。以前类型的泛化（generalization）是靠类型与全局基类System.Object的相互转换来实现。.NET框架基础类库的ArrayList容器类，就是这种局限的一个例子。ArrayList是一个很方便的容器类，使用中无需更改就可以存储任何引用类型或值类型。
 
////The .NET Framework 1.1 way of creating a list
//ArrayList list1 = new ArrayList(); 
//list1.Add(3);
//list1.Add(105);
////...
//ArrayList list2 = new ArrayList();
//list2.Add(“It is raining in Redmond.”);
//list2.Add("It is snowing in the mountains.");
////...
 
//但是这种便利是有代价的，这需要把任何一个加入ArrayList的引用类型或值类型都隐式地向上转换成System.Object。如果这些元素是值类型，那么当加入到列表中时，它们必须被装箱；当重新取回它们时，要拆箱。类型转换和装箱、拆箱的操作都降低了性能；在必须迭代（iterate）大容器的情况下，装箱和拆箱的影响可能十分显著。
 
//另一个局限是缺乏编译时的类型检查，当一个ArrayList把任何类型都转换为Object，就无法在编译时预防客户代码类似这样的操作：
 
//ArrayList list = new ArrayList(); 
////Okay.  
//list.Add(3); 
////Okay, but did you really want to do this?
//list.Add(.“It is raining in Redmond.”);
 
//int t = 0;
////This causes an InvalidCastException to be returned.
//    foreach(int x in list)
//{
//  t += x;
//}
 
//虽然这样完全合法，并且有时是有意这样创建一个包含不同类型元素的容器，但是把string和int变量放在一个ArrayList中，几乎是在制造错误，而这个错误直到运行的时候才会被发现。
 
//在1.0版和1.1版的C#语言中，你只有通过编写自己的特定类型容器，才能避免.NET框架类库的容器类中泛化代码（generalized code）的危险。当然，因为这样的类无法被其他的数据类型复用，也就失去泛型的优点，你必须为每个需要存储的类型重写该类。
 
//ArrayList和其他相似的类真正需要的是一种途径，能让客户代码在实例化之前指定所需的特定数据类型。这样就不需要向上类型转换为Object，而且编译器可以同时进行类型检查。换句话说，ArrayList需要一个类型参数。这正是泛型所提供的。在System.Collections.Generic命名空间中的泛型List<T>容器里，同样是把元素加入容器的操作，类似这样：
//The .NET Framework 2.0 way of creating a list
//List<int> list1 = new List<int>();
////No boxing, no casting:
//list1.Add(3);
////Compile-time error:
//list1.Add("It is raining in Redmond.");
 
//与ArrayList相比，在客户代码中唯一增加的List<T>语法是声明和实例化中的类型参数。代码略微复杂的回报是，你创建的表不仅比ArrayList更安全，而且明显地更加快速，尤其当表中的元素是值类型的时候。

 

//三、泛型类型参数
   
//    在泛型类型或泛型方法的定义中，类型参数是一个占位符（placeholder），通常为一个大写字母，如T。在客户代码声明、实例化该类型的变量时，把T替换为客户代码所指定的数据类型。泛型类，如泛型概述中给出的MyList<T>类，不能用作as-is，原因在于它不是一个真正的类型，而更像是一个类型的蓝图。要使用MyList<T>，客户代码必须在尖括号内指定一个类型参数，来声明并实例化一个已构造类型（constructed type）。这个特定类的类型参数可以是编译器识别的任何类型。可以创建任意数量的已构造类型实例，每个使用不同的类型参数，如下：
 
//MyList<MyClass> list1  = new MyList<MyClass>();
//MyList<float> list2 = new MyList<float>();
//MyList<SomeStruct> list3 = new MyList<SomeStruct>();
 
//    在这些MyList<T>的实例中，类中出现的每个T都将在运行的时候被类型参数所取代。依靠这样的替换，我们仅用定义类的代码，就创建了三个独立的类型安全且高效的对象。有关CLR执行替换的详细信息，请参见运行时中的泛型。

 

//四、类型参数的约束
 
//若要检查表中的一个元素，以确定它是否合法或是否可以与其他元素相比较，那么编译器必须保证：客户代码中可能出现的所有类型参数，都要支持所需调用的操作或方法。这种保证是通过在泛型类的定义中，应用一个或多个约束而得到的。一个约束类型是一种基类约束，它通知编译器，只有这个类型的对象或从这个类型派生的对象，可被用作类型参数。一旦编译器得到这样的保证，它就允许在泛型类中调用这个类型的方法。上下文关键字where用以实现约束。下面的示例代码说明了应用基类约束，为MyList<T>类增加功能。
 
//public class Employee
//{
// public class Employee
//    {
//        private string name;
//        private int id;
//        public Employee(string s, int i)
//        {
//            name = s;
//            id = i;
//        }
 
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int ID
//        {
//            get { return id; }
//            set { id = value; }
//        }
 
//    }
//}
//class MyList<T> where T: Employee
//{
// //Rest of class as before.
//  public T FindFirstOccurrence(string s)
//  {
//   T t = null;
//   Reset();
//   while (HasItems())
//   {
//      if (current != null)
//      {
////The constraint enables this:
//         if (current.Data.Name == s)
//         {
//            t = current.Data;
//            break;
//         }
//         else
//         {
//            current = current.Next;
//         }
//      } //end if
//   } // end while
//  return t;
//  }
//}
 
//约束使得泛型类能够使用Employee.Name属性，因为所有为类型T的元素，都是一个Employee对象或是一个继承自Employee的对象。
 
//同一个类型参数可应用多个约束。约束自身也可以是泛型类，如下：
 
//class MyList<T> where T: Employee, IEmployee,  IComparable<T>,  new()
//{…}
 
//    下表列出了五类约束：
//约束
//描述
//where T: struct
//类型参数必须为值类型。
//where T : class
//类型参数必须为类型。
//where T : new()
//类型参数必须有一个公有、无参的构造函数。当于其它约束联合使用时,new()约束必须放在最后。
//where T : <base class name>
//类型参数必须是指定的基类型或是派生自指定的基类型。
//where T : <interface name>
//类型参数必须是指定的接口或是指定接口的实现。可以指定多个接口约束。接口约束也可以是泛型的。
 
 
//类型参数的约束，增加了可调用的操作和方法的数量。这些操作和方法受约束类型及其派生层次中的类型的支持。因此，设计泛型类或方法时，如果对泛型成员执行任何赋值以外的操作，或者是调用System.Object中所没有的方法，就需要在类型参数上使用约束。
 
//无限制类型参数的一般用法
//没有约束的类型参数,如公有类MyClass<T>{...}中的T, 被称为无限制类型参数(unbounded type parameters)。无限制类型参数有以下规则:
//l        不能使用运算符 != 和 == ，因为无法保证具体的类型参数能够支持这些运算符。
//l        它们可以与System.Object相互转换，也可显式地转换成任何接口类型。
//l        可以与null比较。如果一个无限制类型参数与null比较，当此类型参数为值类型时，比较的结果总为false。
 
 
//无类型约束
//当约束是一个泛型类型参数时，它就叫无类型约束(Naked type constraints)。当一个有类型参数成员方法，要把它的参数约束为其所在类的类型参数时，无类型约束很有用。如下例所示：
 
//class List<T>
//{
//      //...
//    void Add<U>(List<U> items) where U:T {…}
//}
 
//在上面的示例中， Add方法的上下文中的T，就是一个无类型约束；而List类的上下文中的T，则是一个无限制类型参数。
 
//无类型约束也可以用在泛型类的定义中。注意，无类型约束一定也要和其它类型参数一起在尖括号中声明：
////naked type constraint
//public class MyClass<T,U,V> where T : V
 
//因为编译器只认为无类型约束是从System.Object继承而来，所以带有无类型约束的泛型类的用途十分有限。当你希望强制两个类型参数具有继承关系时，可对泛型类使用无类型约束。

 

//五、泛型类
 
 
//泛型类封装了不针对任何特定数据类型的操作。泛型类常用于容器类，如链表、哈希表、栈、队列、树等等。这些类中的操作，如对容器添加、删除元素，不论所存储的数据是何种类型，都执行几乎同样的操作。
 
//对大多数情况，推荐使用.NET框架2.0类库中所提供的容器类。有关使用这些类的详细信息，请参见基础类库中的泛型。
 
//通常，从一个已有的具体类来创建泛型类，并每次把一个类型改为类型参数，直至达到一般性和可用性的最佳平衡。当创建你自己的泛型类时，需要重点考虑的事项有：
//l        哪些类型应泛化为类型参数。一般的规律是，用参数表示的类型越多，代码的灵活性和复用性也就越大。过多的泛化会导致代码难以被其它的开发人员理解。
//l        如果有约束，那么类型参数需要什么样约束。一个良好的习惯是，尽可能使用最大的约束，同时保证可以处理所有需要处理的类型。例如，如果你知道你的泛型类只打算使用引用类型，那么就应用这个类的约束。这样可以防止无意中使用值类型，同时可以对T使用as运算符，并且检查空引用。
//l        把泛型行为放在基类中还是子类中。泛型类可以做基类。同样非泛型类的设计中也应考虑这一点。泛型基类的继承规则     。
//l        是否实现一个或多个泛型接口。例如，要设计一个在基于泛型的容器中创建元素的类，可能需要实现类似IComparable<T>的接口，其中T是该类的参数。
 
//泛型概述中有一个简单泛型类的例子。
 
//类型参数和约束的规则对于泛型类的行为（behavior）有一些潜在的影响，——尤其是对于继承和成员可访问性。在说明这个问题前,理解一些术语十分重要。对于一个泛型类Node<T>，客户代码既可以通过指定一个类型参数来创建一个封闭构造类型(Node<int>),也可以保留类型参数未指定，例如指定一个泛型基类来创建开放构造类型(Node<T>)。泛型类可以继承自具体类、封闭构造类型或开放构造类型：
 
//// concrete type
//class Node<T> : BaseNode
////closed constructed type
//class Node<T> : BaseNode<int>
////open constructed type
//class Node<T> : BaseNode<T>
 
//非泛型的具体类可以继承自封闭构造基类，但不能继承自开放构造基类。这是因为客户代码无法提供基类所需的类型参数。
 
////No error.
//class Node : BaseNode<int>
////Generates an error.
//class Node : BaseNode<T>
 
//泛型的具体类可以继承自开放构造类型。除了与子类共用的类型参数外，必须为所有的类型参数指定类型，如下代码所示：
////Generates an error.
//class Node<T> : BaseNode<T, U> {…}
////Okay.
//class Node<T> : BaseNode<T, int>{…}
 
//继承自开放结构类型的泛型类，必须指定：
//Generic classes that inherit from open constructed types must specify must specify constraints that are a superset of, or imply, the constraints on the base type:
 
//class NodeItem<T> where T : IComparable<T>, new() {…}
//class MyNodeItem<T> : NodeItem<T> where T : IComparable<T> , new(){…}
 
 
//泛型类型可以使用多种类型参数和约束，如下：
//class KeyType<K,V>{…}
//class SuperKeyType<K,V,U> where U : IComparable<U>, where V : new(){…}
 
//开放结构和封闭构造类型型可以用作方法的参数：
//void Swap<T>(List<T> list1, List<T> list2){…}
//void Swap(List<int> list1, List<int> list2){…}

 

//六、泛型接口
//不论是为泛型容器类，还是表示容器中元素的泛型类，定义接口是很有用的。把泛型接口与泛型类结合使用是更好的用法，比如用IComparable<T>而非IComparable，以避免值类型上的装箱和拆箱操作。.NET框架2.0类库定义了几个新的泛型接口，以配合System.Collections.Generic中新容器类的使用。
 
//    当一个接口被指定为类型参数的约束时，只有实现该接口的类型可被用作类型参数。下面的示例代码显示了一个从MyList<T>派生的SortedList<T>类。更多信息，请参见泛型概述。SortedList<T>增加了约束where T : IComparable<T>。
//这使得SortedList<T>中的BubbleSort方法可以使用表中的元素的IComparable<T>.CompareTo方法。在这个例子中，表中的元素是简单类——实现IComparable<Person>的Person类。
 
//using System;
//using System.Collections.Generic;
 
////Type parameter T in angle brackets.
//public class MyList<T>
//{
//    protected Node head;
//    protected Node current = null;
 
//// Nested type is also generic on T
//    protected class Node         
//    {
//        public Node next;
////T as private member datatype.
//        private T data;         
////T used in non-generic constructor.
//        public Node(T t)        
//        {
//            next = null;
//            data = t;
//        }
//        public Node Next
//        {
//            get { return next; }
//            set { next = value; }
//        }
////T as return type of property.
//        public T Data           
//        {
//            get { return data; }
//            set { data = value; }
//        }
//    }
//    public MyList()
//    {
//        head = null;
//    }
////T as method parameter type.
//    public void AddHead(T t)    
//    {
//        Node n = new Node(t);
//        n.Next = head;
//        head = n;   
//    }
//    // Implement IEnumerator<T> to enable foreach
//    // iteration of our list. Note that in C# 2.0
//    // you are not required to implment Current and
//    // GetNext. The compiler does that for you.
//    public IEnumerator<T> GetEnumerator()
//    {
//        Node current = head;
 
//        while (current != null)
//        {
//            yield return current.Data;
//            current = current.Next;
//        }
//    }
//}
 
 
//public class SortedList<T> : MyList<T> where T : IComparable<T>
//{
//    // A simple, unoptimized sort algorithm that
//    // orders list elements from lowest to highest:
 
//public void BubbleSort()
//    {
 
//        if (null == head || null == head.Next)
//            return;
//        bool swapped;
 
//        do
//        {
//            Node previous = null;
//            Node current = head;
//            swapped = false;
 
//            while (current.next != null)
//            {
//                //  Because we need to call this method, the SortedList
//                //  class is constrained on IEnumerable<T>
//                if (current.Data.CompareTo(current.next.Data) > 0)
//                {
//                    Node tmp = current.next;
//                    current.next = current.next.next;
//                    tmp.next = current;
 
//                    if (previous == null)
//                    {
//                        head = tmp;
//                    }
//                    else
//                    {
//                        previous.next = tmp;
//                    }
//                    previous = tmp;
//                    swapped = true;
//                }
 
//                else
//                {
//                    previous = current;
//                    current = current.next;
//                }
 
//            }// end while
//        } while (swapped);
//    }
 
//}
 
//// A simple class that implements IComparable<T>
//// using itself as the type argument. This is a
//// common design pattern in objects that are
//// stored in generic lists.
//public class Person : IComparable<Person>
//{
//    string name;
//    int age;
//    public Person(string s, int i)
//    {
//        name = s;
//        age = i;
//    }
//    // This will cause list elements
//    // to be sorted on age values.
//    public int CompareTo(Person p)
//    {
//        return age - p.age;
//    }
//    public override string ToString()
//    {
//        return name + ":" + age;
//    }
//    // Must implement Equals.
//    public bool Equals(Person p)
//    {
//        return (this.age == p.age);
//    }
//}
 
//class Program
//{
//    static void Main(string[] args)
//    {
//        //Declare and instantiate a new generic SortedList class.
//        //Person is the type argument.
//        SortedList<Person> list = new SortedList<Person>();
 
//        //Create name and age values to initialize Person objects.
//        string[] names = new string[]{"Franscoise", "Bill", "Li", "Sandra", "Gunnar", "Alok", "Hiroyuki", "Maria", "Alessandro", "Raul"};
//        int[] ages = new int[]{45, 19, 28, 23, 18, 9, 108, 72, 30, 35};
 
//        //Populate the list.
//        for (int x = 0; x < 10; x++)
//        {
//            list.AddHead(new Person(names[x], ages[x]));
//        }
//        //Print out unsorted list.
//        foreach (Person p in list)
//        {
//            Console.WriteLine(p.ToString());
//        }
 
//        //Sort the list.
//        list.BubbleSort();
 
//        //Print out sorted list.
//        foreach (Person p in list)
//        {
//            Console.WriteLine(p.ToString());
//        }
 
//        Console.WriteLine("Done");
//    }
//}
 
 
//可以在一个类型指定多个接口作为约束，如下:
 
//class Stack<T> where T : IComparable<T>, IMyStack1<T>{}
 
 
//一个接口可以定义多个类型参数，如下:
 
//IDictionary<K,V>
 
//接口和类的继承规则相同：
////Okay.
//IMyInterface : IBaseInterface<int>
////Okay.
//IMyInterface<T> : IBaseInterface<T>
 
////Okay.
//IMyInterface<T>: IBaseInterface<int>
////Error.
//IMyInterface<T> : IBaseInterface2<T, U>
 
//具体类可以实现封闭构造接口，如下:
//class MyClass : IBaseInterface<string>
 
//泛型类可以实现泛型接口或封闭构造接口，只要类的参数列表提供了接口需要的所有参数，如下:
////Okay.
//class MyClass<T> : IBaseInterface<T>
////Okay.
//class MyClass<T> : IBaseInterface<T, string>
 
//泛型类、泛型结构，泛型接口都具有同样方法重载的规则。详细信息，请参见泛型方法。

 

//七、泛型方法
 
//泛型方法是声名了类型参数的方法，如下：
 
//void Swap<T>( ref T lhs, ref T rhs)
//{
//  T temp;
//  temp = lhs;
//  lhs = rhs;
//  rhs = temp;
//}
 
 
//下面的示例代码显示了一个以int作为类型参数，来调用方法的例子：
 
//int a = 1;
//int b = 2;
////…
//Swap<int>(a, b);
 
//也可以忽略类型参数，编译器会去推断它。下面调用Swap的代码与上面的例子等价：
//Swap(a, b);
 
 
//静态方法和实例方法有着同样的类型推断规则。编译器能够根据传入的方法参数来推断类型参数；而无法单独根据约束或返回值来判断。因此类型推断对没有参数的方法是无效的。类型推断发生在编译的时候，且在编译器解析重载方法标志之前。编译器对所有同名的泛型方法应用类型推断逻辑。在决定（resolution）重载的阶段，编译器只包含那些类型推断成功的泛型类。更多信息，请参见C# 2.0规范，20.6.4类型参数推断
 
//在泛型方法中，非泛型方法能访问所在类中的类型参数，如下：
//class MyClass<T>
//{
//  //…
//  void Swap (ref T lhs, ref T rhs){…}
//}
 
//[JX1] 定义一个泛型方法，和其所在的类具有相同的类型参数；试图这样做，编译器会产生警告CS0693。
 
//class MyList<T>
//{
//// CS0693
//    void MyMethod<T>{...}   
//}
 
//class MyList<T>
//{
////This is okay, but not common.
//    void SomeMethod<U>(){...}   
//}
 
//使用约束可以在方法中使用更多的类型参数的特定方法。这个版本的Swap<T>称为SwapIfGreater<T>，它只能使用实现了IComparable<T>的类型参数。
//void SwapIfGreater<T>( ref T lhs, ref T rhs) where T: IComparable<T>
//{
//  T temp;
//  if(lhs.CompareTo(rhs) > 0)
//    {
//      temp = lhs;
//      lhs = rhs;
//      rhs = temp;
//    }
//}
 
//泛型方法通过多个类型参数来重载。例如，下面的这些方法可以放在同一个类中：
//void DoSomething(){}
//void DoSomething<T>(){}
//void DoSomething<T,U>(){}
 

 

//八、泛型委托
//无论是在类定义内还是类定义外，委托可以定义自己的类型参数。引用泛型委托的代码可以指定类型参数来创建一个封闭构造类型，这和实例化泛型类或调用泛型方法一样，如下例所示：
 
//public delegate void MyDelegate<T>(T item);
//public void Notify(int i){}
////...
 
//MyDelegate<int> m = new MyDelegate<int>(Notify);
 
//C#2.0版有个新特性称为方法组转换（method group conversion），具体代理和泛型代理类型都可以使用。用方法组转换可以把上面一行写做简化语法：
//MyDelegate<int> m = Notify;
 
//在泛型类中定义的委托，可以与类的方法一样地使用泛型类的类型参数。
//class Stack<T>
//{
//T[] items;
//      int index
////...
//public delegate void StackDelegate(T[] items);
//}
 
//引用委托的代码必须要指定所在类的类型参数，如下：
 
//Stack<float> s = new Stack<float>();
//Stack<float>.StackDelegate myDelegate = StackNotify;
 
 
//泛型委托在定义基于典型设计模式的事件时特别有用。因为sender[JX2] ，而再也不用与Object相互转换。
//public void StackEventHandler<T,U>(T sender, U eventArgs);
//class Stack<T>
//{
//    //…
//    public class StackEventArgs : EventArgs{...}
//    public event StackEventHandler<Stack<T>, StackEventArgs> stackEvent;
//    protected virtual void OnStackChanged(StackEventArgs a)
//    {
//      stackEvent(this, a);
//    }
//}
//class MyClass
//{
//  public static void HandleStackChange<T>(Stack<T> stack, StackEventArgs args){...};
//}
//Stack<double> s = new Stack<double>();
//MyClass mc = new MyClass();
//s.StackEventHandler += mc.HandleStackChange;
 

 

//九、泛型代码中的 default 关键字
 
//在泛型类和泛型方法中会出现的一个问题是，如何把缺省值赋给参数化类型，此时无法预先知道以下两点：
//l        T将是值类型还是引用类型
//l        如果T是值类型，那么T将是数值还是结构
 
//对于一个参数化类型T的变量t，仅当T是引用类型时，t = null语句才是合法的； t = 0只对数值的有效，而对结构则不行。这个问题的解决办法是用default关键字，它对引用类型返回空，对值类型的数值型返回零。而对于结构，它将返回结构每个成员，并根据成员是值类型还是引用类型，返回零或空。下面MyList<T>类的例子显示了如何使用default关键字。更多信息，请参见泛型概述。
 
//public class MyList<T>
//{
//    //...
//        public T GetNext()
//        {
//            T temp = default(T);
//            if (current != null)
//            {
//                temp = current.Data;
//                current = current.Next;
//            }
//            return temp;
//        }
//}

 

//十、 C++ 模板和 C# 泛型的区别
//（未翻译）
 
//C# Generics and C++ templates are both language features that provide support for parameterized types. However, there are many differences between the two. At the syntax level, C# generics are a simpler approach to parameterized types without the complexity of C++ templates. In addition, C# does not attempt to provide all of the functionality that C++ templates provide. At the implementation level, the primary difference is that C# generic type substitutions are performed at runtime and generic type information is thereby preserved for instantiated objects. For more information, see Generics in the Runtime.
 
//The following are the key differences between C# Generics and C++ templates:
//·                     C# generics do not provide the same amount of flexibility as C++ templates. For example, it is not possible to call arithmetic operators in a C# generic class, although it is possible to call user defined operators.
//·                     C# does not allow non-type template parameters, such as template C<int i> {}.
//·                     C# does not support explicit specialization; that is, a custom implementation of a template for a specific type.
//·                     C# does not support partial specialization: a custom implementation for a subset of the type arguments.
//·                     C# does not allow the type parameter to be used as the base class for the generic type.
//·                     C# does not allow type parameters to have default types.
//·                     In C#, a generic type parameter cannot itself be a generic, although constructed types can be used as generics. C++ does allow template parameters.
//·                     C++ allows code that might not be valid for all type parameters in the template, which is then checked for the specific type used as the type parameter. C# requires code in a class to be written in such a way that it will work with any type that satisfies the constraints. For example, in C++ it is possible to write a function that uses the arithmetic operators + and - on objects of the type parameter, which will produce an error at the time of instantiation of the template with a type that does not support these operators. C# disallows this; the only language constructs allowed are those that can be deduced from the constraints.

 

//十一 、运行时中的泛型
//Specialized generic types are created once for each unique value type used as a parameter.
 
//当泛型类或泛型方法被编译为微软中间语言(MSIL)后，它所包含的元数据定义了它的类型参数。根据所给的类型参数是值类型还是引用类型，对泛型类型所用的MSIL也是不同的。
//    当第一次以值类型作为参数来构造一个泛型类型，运行时用所提供的参数或在MSIL中适当位置被替换的参数，来创建一个专用的泛型类型。[JX3] 
 
//    例如，假设你的程序代码声名一个由整型构成的栈，如：
 
//Stack<int> stack;
 
//此时，运行时用整型恰当地替换了它的类型参数，生成一个专用版本的栈。此后，程序代码再用到整型栈时，运行时复用已创建的专用的栈。下面的例子创建了两个整型栈的实例，它们共用一个Stack<int>代码实例：
 
//Stack<int> stackOne = new Stack<int>();
//Stack<int> stackTwo = new Stack<int>();
 
//    然而，如果由另一种值类型——如长整型或用户自定义的结构——作为参数，在代码的其他地方创建另一个栈，那么运行时会生成另一个版本的泛型类型。这次是把长整型替换到MSIL中的适当的位置。由于每个专用泛型类原本就包含值类型，因此不需要再转换。
 
//    对于引用类型，泛型的工作略有不同。当第一次用任何引用类型构造泛型类时，运行时在MSIL中创建一个专用泛型类，其中的参数被对象引用所替换。之后，每当用一个引用类型作为参数来实例化一个已构造类型时，就忽略其类型，运行时复用先前创建的专用版本的泛型类。这可能是由于所有的引用的大小都相同。
 
//    例如，假如你有两个引用类型，一个Customer类和一个Order类；进一步假设你创建了一个Customer的栈：
 
//Stack<Customer> customers;
 
//    此时，运行时生成一个专用版本的栈，用于稍后存储对象的引用，而不是存储数据。假如下一行代码创建了一个另一种引用类型的栈，名为Order：
 
//Stack<Order> orders = new Stack<Order>();
 
//    和值类型不同，运行时并没有为Order类型创建另一个栈的专用版本。相反，运行时创建了一个专用版本栈实例，并且变量orders指向这个实例。如果之后是一行创建Customer类型的栈的代码：
 
//customers = new Stack<Customer>();
 
//和之前以Order类型创建的栈一样，创建了专用栈的另一个实例，并且其中所包含的指针指向一块大小与Customer类一致的内存。由于不同程序间引用类型的数量差别很大，而编译器只为引用类型的泛型类创建一个专用类，因此C#对泛型的实现极大地降低了代码膨胀。
//    此外，当用类型参数实现一个泛型C#类时，想知道它是指类型还是引用类型，可以在运行时通过反射确定它的真实类型和它的类型参数。
 
 

 

//十二 、基础类库中的泛型
//    2.0版的.NET框架类库提供了一个新的命名空间，System.Collections.Generic，其中包含了一些已经可以使用的泛型容器类和相关的接口。和早期版本的.NET框架提供的非泛型容器类相比，这些类和接口更高效且是类型安全的。在设计、实现自定义的容器类之前，请你考虑是否使用或继承所列出类中的一个。
 
//    下面的表格列出了新的泛型类和接口，旁边是对应的非泛型类和接口。在一些地方要特别注意，如List<T>和Dictionary<T>，新泛型类的行为（behavior）与它们所替换的非泛型类有些不同，也不完全兼容。更详细的内容，请参考System.Collections.Generic的文档
 
//泛型类或接口
//描述
//对应的非泛型类型
//Collection<T>
//ICollection<T>
//为泛型容器提供基类
//CollectionBase
//ICollection
//Comparer<T>
//IComparer<T>
//IComparable<T>
//比较两个相同泛型类型的对象是否相等、可排序。
//Comparer
//IComparer
//IComparable
//Dictionary<K, V>
//IDictionary<K,V>
//表示用键组织的键/值对集合。
//Hashtable
//IDictionary
//Dictionary<K, V>.KeyCollection
//表示Dictionary<K, V>中键的集合。
//None.
//Dictionary<K, V>.ValueCollection
//表示Dictionary<K, V>中值的集合。
//None.
//IEnumerable<T>
//IEnumerator<T>
//表示可以使用foreach 迭代的集合。
//IEnumerable
//IEnumerator
//KeyedCollection<T, U>
//表示有键值的集合。
//KeyedCollection
//LinkedList<T>
//表示双向链表。
//None.
//LinkedListNode<T>
//表示LinkedList<T>中的节点。
//None.
//List<T>
//IList<T>
//使用大小可按需动态增加的数组实现 IList 接口
//ArrayList
//IList
//Queue<T>
//表示对象的先进先出集合。
//Queue
//ReadOnlyCollection<T>
//为泛型只读容器提供基类。
//ReadOnlyCollectionBase
//SortedDictionary<K, V>
// 表示键/值对的集合，这些键和值按键排序并可按照键访问，实现IComparer<T>接口。
//SortedList
//Stack<T>
//表示对象的简单的后进先出集合。
//Stack



namespace Generics_Test1
{
    public class MyList<T> //type parameter T in angle brackets
    {
        private Node head;
        // The nested type is also generic on T.
        private class Node
        {
            private Node next;
            //T as private member data type:
            private T data;
            //T used in non-generic constructor:
            public Node(T t)
            {
                next = null;
                data = t;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            //T as return type of property:
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        public MyList()
        {
            head = null;
        }
        //T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }


    class Program
    {
        static void main(string[] args)
        {
            //int is the type argument.
            MyList<int> list = new MyList<int>();
            for (int x = 0; x < 10; x++)
                list.AddHead(x);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
                 
    }
}
