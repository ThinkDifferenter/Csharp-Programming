using System;
using System.Collections;

//事件的四个步骤：

//(1)在事件发行者中定义一个事件
//(2)在事件发行者中触发事件
//(3)在事件订阅者中定义事件处理程序
//(4)向事件发行者订阅事件


//简单的事件机制
//比如，我有某个银行的信用卡，我会向银行订阅每期的账单信息和相关优惠信息到手机上
namespace EventDemo
{
    //声明一个事件的发行者
    public class Bank
    {
        //事件是通过委托的方式实现的，所以需要先定义一个委托类型
        public delegate void DelegateAccount(string cardInfo);//账单信息委托
        public delegate void DelegateSales(string cardInfo);//优惠信息委托

        //事件的声明使用event关键字，后面是委托类型和事件名称
        //事件与委托组合使用 
        public event DelegateAccount OnAccount;//账单信息事件
        public event DelegateSales OnSales;//促销信息事件

        //账单信息事件的触发方法
        public void sendAccountInfo()
        {
            //判断事件是否为空
            if (OnAccount != null)
            {
                OnAccount("账单信息");//触发事件，本质上其实就是触发一个委托链
            }
        }

        //促销优惠信息事件的触发方法
        public void sendSalesInfo()
        {
            //判断事件是否为空
            if (OnSales != null)
            {
                OnSales("双倍积分优惠信息");//触发事件，本质上其实就是触发一个委托链
            }
        }

    }

    //声明一个事件订阅者
    public class User
    {
        private string UserName;

        public User(string name)
        {
            UserName = name;
        }
        //收到事件后的处理程序(事件处理方法的类型必须和发行者类中对应的委托一致)
        public void ReceiveAccountInfo(string cardInfo)
        {
            Console.WriteLine(UserName + "收到" + cardInfo);
        }

        public void ReceiveSalesInfo(string cardInfo)
        {
            Console.WriteLine(UserName + "收到" + cardInfo);
        }
    }

    class MainFun
    {
        static void Main()
        {
            Bank bank = new Bank();
            User user_A = new User("用户A");
            User user_B = new User("用户B");

            //用户向银行订阅账单信息(向事件发行者订阅事件)
            //委托本身属于静态类型，所以只能用类名调用
            bank.OnAccount += new Bank.DelegateAccount(user_A.ReceiveAccountInfo);
            bank.OnSales += new Bank.DelegateSales(user_A.ReceiveSalesInfo);

            bank.OnAccount += new Bank.DelegateAccount(user_B.ReceiveAccountInfo);
            bank.OnSales += new Bank.DelegateSales(user_B.ReceiveSalesInfo);

            //银行在某个时段向订阅用户发送信息
            bank.sendAccountInfo();
            bank.sendSalesInfo();

            //用户可以取消订阅
            bank.OnSales -= new Bank.DelegateSales(user_B.ReceiveSalesInfo);

            Console.WriteLine();

            //银行再发送相关信息的时候，将不会发送给取消订阅的用户
            bank.sendAccountInfo();
            bank.sendSalesInfo();

            Console.ReadLine();
        }
    }
}