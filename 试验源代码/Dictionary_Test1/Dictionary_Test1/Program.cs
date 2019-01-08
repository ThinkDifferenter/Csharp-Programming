
//1、要使用Dictionary集合，需要导入C#泛型命名空间  
//  System.Collections.Generic（程序集：mscorlib）  
//2、描述  
//   1）、从一组键（Key）到一组值（Value）的映射，每一个添加项都是由一个值及其相关连的键组成  
//   2）、任何键都必须是唯一的  
//   3）、键不能为空引用null（VB中的Nothing），若值为引用类型，则可以为空值  
//   4）、Key和Value可以是任何类型（string，int，custom class 等）  
//3、创建及初始化  
  
　//　 Dictionary<int, string> myDictionary = new Dictionary<int, string>();  
  
//4、添加元素  
  
   //myDictionary.Add("C#",0);  
   //myDictionary.Add("C++",1);  
   //myDictionary.Add("C",2);  
   //myDictionary.Add("VB",2);  
  
//5、查找元素By Key  
  
  //if(myDictionary.ContainsKey("C#"))  
  //{  
  //  Console.WriteLine("Key:{0},Value:{1}", "C#", myDictionary["C#"]);  
  //}  
  
//6.遍历元素 By KeyValuePair  
  
  //foreach (KeyValuePair<string, int> kvp in myDictionary)  
  //{  
  //  Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);  
  //}  
  
//7、仅遍历键 By Keys 属性  
  
  //Dictionary<string, int>.KeyCollection keyCol = myDictionary.Keys;  
  //foreach (string key in keyCol/*string key in myDictionary.Keys*/)  
  //{  
  //  Console.WriteLine("Key = {0}", key);  
  //}  
  
//8、仅遍历值By Valus属性  
  
  //Dictionary<string, int>.ValueCollection valueCol = myDictionary.Values;  
  //foreach (int value in valueCol)  
  //{  
  //  Console.WriteLine("Value = {0}", value);  
  //}  
  
//9.移除指定的键值By Remove方法  
  
  //myDictionary.Remove("C#");  
  //if (myDictionary.ContainsKey("C#"))  
  //{  
  //  Console.WriteLine("Key:{0},Value:{1}", "C#", myDictionary["C#"]);  
  //}  
  //else  
  //{  
  //  Console.WriteLine("不存在 Key : C#");  
  //    }  
  
//在System.Collections.Generic命名空间中，与ArrayList相对应的泛型集合是List，与 HashTable相对应的泛型集合是Dictionary，其存储数据的方式与哈希表相似，通过键/值来保存元素，并具有泛型的全部特征，编译时检查类型约束，读取时无须类型转换。  
  
//  电话本存储的例子中，使用Dictionary来存储电话本信息，代码如下：  
  
  
//Dictionary<string,TelNote> ht=new Dictionary<string,TelNote>();  
 
//　　在Dictionary声明中，“<string,TelNote>”中的string表示集合中Key的类型，TelNote表示Value的类型，定义Dictionary泛型集合中的方法如下：  
  
  
//Dictionary students=new Dictionary();  
  
　//　其中“K”为占位符，具体定义时用存储键“Key”的数据类型代替，“V”也是占位符，用元素的值“Value”的数据类型代替，这样就在定义该集合时，声明了存储元素的键和值的数据类型，保证了类型的安全性。  
　//　Dictionary中元素的操作方法与HashTable相似，添加元素，获取元素，删除元素，遍历集合元素的方法基本相同。  
  
//Dictionary和HashTable的区别  
//Dictionary和HashTable的相同点：添加元素，删除元素，通过键访问值的方法相同。  
//Dictionary和HashTable的不同点：  
//Dictionary对添加的元素具有类型约束，HashTable可添加任意类型的元素。  
//Dictionary不需要装箱、拆箱操作，HashTable添加时装箱，读取时拆箱。  
  
//　　在Dictionary集合中，除了通过键获取值的方法外，还有一种TryGetValue(key)方法，可以通过键获取值，该方法返回值为布尔型，如果存在和键相对应的值，则返回true，否则返回false。避免了因获取不到相应值发生的异常。  
  
  
using System;  
using System.Collections.Generic;  

class Program  
{  
    static void Main()  
    {  
       //创建Dictionary,其中"键"为string数据类型,"值"为string数据类型  
       Dictionary < string, string > film = new Dictionary < string, string > ();  

       //向Dictionary中添加元素
       film.Add("韦小宝", "鹿鼎记");  
       film.Add("陆小凤", "陆小凤传奇");  
       film.Add("张无忌", "倚天屠龙记");  
       film.Add("杨过", "神雕侠侣");  
       film.Add("令狐冲", "笑傲江湖");  
       
       Console.WriteLine("集合现在的元素个数为{0}", film.Count);  
       
       //移除Dictionary中的元素
       film.Remove("杨过");  
       
       //遍历集合  
       Console.WriteLine("武侠电影的主角及电影名");  
       Console.WriteLine("/t主角/t电影");  
       foreach (KeyValuePair < string, string > kvp in film)  
       {  
        Console.WriteLine("/t{0}/t{1}", kvp.Key, kvp.Value);  
       }  
       
       //检查元素是否存在，如不存在，添加  与Hashtable集合相似
       if (!film.ContainsKey("段誉"))  
       {  
        film.Add("段誉", "天龙八部");  
       }  
       
       //获取键的集合  
       Dictionary < string, string > .KeyCollection keys = film.Keys;  
       
       //遍历键的集合  
       Console.WriteLine("受欢迎的武侠片中主角名");  
       foreach (string str in keys)  
       {  
        Console.WriteLine(str);  
       }  
       
       Dictionary < string, string > .ValueCollection values = film.Values;  
       
       //遍历值的集合  
       Console.WriteLine("最受欢迎的武侠片");  
       foreach (string strfilm in values)  
       {  
        Console.WriteLine(strfilm);  
       }  
       
       //遍历元素的另一种方法 Hashtable遍历方法foreach遍历in HashtableName.Value即可 
       Console.WriteLine("和哈希表相同的遍历元素方法");  
       foreach (string strname in film.Values)  
       {  
        Console.WriteLine(strname);  
       }  
       
       //获取键对应的值  
       string myfilm = film["令狐冲"];  
       Console.WriteLine("主角为令狐冲的电影名{0}", myfilm);  
       
       //获取键对应值的TryGetValue方法  
       string objfilm = string.Empty;//string objfilm ="";  
       if (film.TryGetValue("段誉", out objfilm))//out关键字使用无需初始化  
       {  
        Console.WriteLine("主角为段誉的电影是{0}", objfilm);  
       }  
       else  
        Console.WriteLine("没有主角为段誉的电影");  

       Console.ReadLine();  
    }  
}  
  
  
//  代码创建了一个Dictionary集合，键和值的数据类型是string类型，后边代码的元素添加，删除都和哈希表处理方法相同，遍历元素时不需要进行数据类型强制转换。Dictionary通过键取值的TryGetValue方法，此方法包括两个参数，一个是要查询的键，另一个是获取的值，注意值前面使用out关键字。  
  
//注意：使用TryGetValue方法时，参数一定要使用out关键字，否则编译失败。

