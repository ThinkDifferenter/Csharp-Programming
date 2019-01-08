//(1)delegate的返回类型必须是void，并以EventNameEventHandler方式命名：EventName是事件的名称，
//EventHandler是设计准则要求的统一书写方式。

//(2)delegate接受两个参数，参数名必须统一命名为sender和e；第一个参数类型是object，
//第二个参数是事件的数据类，数据类以EventNameEventArgs命名，并且需继承于System.EventArgs类。

//(3)如果在事件中不需要传递任何数据，也需要声明两个参数：第一个参数就是默认的object sender，
//第二个参数可以使用系统默认的System.EventArgs类。

//(4)在触发事件的类中提供一个受保护的方法，以OnEventName命名，在该方法中触发事件：


using System;
using System.Collections;

//简单的事件机制
//比如，我有某个银行的信用卡，我会向银行订阅每期的账单信息和相关优惠信息到手机上
namespace EventDemo
{
    //事件数据类
    public class CardEventArgs : EventArgs
    {
        private string cardInfo;
        public CardEventArgs(string info)
        {
            cardInfo = info;
        }
        public string CardInfo
        {
            get { return cardInfo; }
        }
    }
    //事件的发行者
    public class Bank
    {
        public delegate void CardAccountEventHandler(object sender, CardEventArgs e);//账单信息委托
        public delegate void CardSalesEventHandler(object sender, CardEventArgs e);//优惠信息委托

        public event CardAccountEventHandler CardAccount;//账单信息事件
        public event CardSalesEventHandler CardSales;//促销信息事件

        //此方法用于触发事件
        protected virtual void OnCardAccount(CardEventArgs e)
        {
            //声明一个临时的委托(查阅资料说这样写可以避免可能出现的线程同步问题)
            CardAccountEventHandler handler = CardAccount;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnCardSales(CardEventArgs e)
        {
            CardSalesEventHandler handler = CardSales;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //这里调用事件触发 　
        public void sendAccountInfo(string cardInfo)
        {
            Console.WriteLine(cardInfo);
            //事件在这里被触发
            OnCardAccount(new CardEventArgs(cardInfo));
        }

        public void sendSalesInfo(string cardInfo)
        {
            Console.WriteLine(cardInfo);
            OnCardSales(new CardEventArgs(cardInfo));
        }
    }

    //事件订阅者
    public class User
    {
        private string UserName;
        public User(string name)
        {
            UserName = name;
        }
        //收到事件后的处理程序(事件处理方法的类型必须和发行者类中对应的委托一致)
        public void ReceiveAccountInfo(object sender, CardEventArgs e)
        {
            Console.WriteLine(UserName + "收到" + e.CardInfo);
        }

        public void ReceiveSalesInfo(object sender, CardEventArgs e)
        {
            Console.WriteLine(UserName + "收到" + e.CardInfo);
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
            bank.CardAccount += new Bank.CardAccountEventHandler(user_A.ReceiveAccountInfo);
            bank.CardSales += new Bank.CardSalesEventHandler(user_A.ReceiveSalesInfo);

            bank.CardAccount += new Bank.CardAccountEventHandler(user_B.ReceiveAccountInfo);
            bank.CardSales += new Bank.CardSalesEventHandler(user_B.ReceiveSalesInfo);

            //银行在某个时段向订阅用户发送信息
            bank.sendAccountInfo("账单信息");
            bank.sendSalesInfo("双倍积分");

            //用户可以取消订阅
            bank.CardSales -= new Bank.CardSalesEventHandler(user_B.ReceiveSalesInfo);

            Console.WriteLine();

            //银行再发送相关信息的时候，将不会发送给取消订阅的用户
            bank.sendAccountInfo("账单信息");
            bank.sendSalesInfo("双倍积分");

            Console.ReadLine();
        }
    }
}