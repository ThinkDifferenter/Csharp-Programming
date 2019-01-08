using System;


namespace 实验9
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '\0';
            string[] strList = new string[] { "major", "reason", "for", "the", "good", "performance", "off", "the", "good", "algorithm", "is", "that", "the", "incorporation", "off" };
            string[] strList2 = new string[strList.Length];

            //foreach遍历字符串并首字母变大写
            int i = 0;
            string Tstr = "";
            foreach (string str in strList)
            {
                if (str[0] <= 'z' && str[0] >= 'a')
                {
                    ch=(char)((int)str[0]-32);
                }

                Tstr = str.Remove(0, 1);
                Tstr = str.Insert(0, Convert.ToString(ch));
                strList2[i++] = Tstr;
            }

            //遍历输出strList2
            foreach (string str in strList2)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
