using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 誕生星座1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int month,date;
                string a = "あなたの星座は、";
                string b = "です。";
                

                Console.Write("あなたの誕生月はいつ？：");
                month = int.Parse(Console.ReadLine());

                Console.Write("あなたの誕生日はいつ？：");
                date = int.Parse(Console.ReadLine());
                if (month == 1)
                {
                    if (date <= 20)
                    {
                        Console.Write(a + "やぎ座" + b);
                    }
                    else if (date >= 21)
                    {
                        Console.Write(a + "みずがめ座" + b);
                    }
                }
                else if (month == 2)
                {
                    if (date <= 18)
                    {
                        Console.Write(a + "みずがめ座" + b);
                    }
                    else if (date >= 19)
                    {
                        Console.Write(a + "うお座" + b);
                    }
                }
                else if (month == 3)
                {
                    if (date <= 20)
                    {
                        Console.Write(a + "うお座" + b);
                    }
                    else if (date >= 21)
                    {
                        Console.Write(a + "おひつじ座" + b);
                    }
                }
                else if (month == 4)
                {
                    if (date <= 19)
                    {
                        Console.Write(a + "おひつじ座" + b);
                    }
                    else if (date >= 20)
                    {
                        Console.Write(a + "おうし座" + b);
                    }
                }
                else if (month == 5)
                {
                    if (date <= 21)
                    {
                        Console.Write(a + "おうし座" + b);
                    }
                    else if (date >= 22)
                    {
                        Console.Write(a + "ふたご座" + b);
                    }
                }
                else if (month == 6)
                {
                    if (date <= 21)
                    {
                        Console.Write(a + "ふたご座" + b);
                    }
                    else if (date >= 22)
                    {
                        Console.Write(a + "かに座" + b);
                    }
                }
                else if (month == 7)
                {
                    if (date <= 22)
                    {
                        Console.Write(a + "かに座" + b);
                    }
                    else if (date >= 23)
                    {
                        Console.Write(a + "しし座" + b);
                    }
                }
                else if (month == 8)
                {
                    if (date <= 22)
                    {
                        Console.Write(a + "しし座" + b);
                    }
                    else if (date >= 23)
                    {
                        Console.Write(a + "おとめ座" + b);
                    }
                }
                else if (month == 9)
                {
                    if (date <= 22)
                    {
                        Console.Write(a + "おとめ座" + b);
                    }
                    else if (date >= 23)
                    {
                        Console.Write(a + "てんびん座" + b);
                    }
                }
                else if (month == 10)
                {
                    if (date <= 23)
                    {
                        Console.Write(a + "てんびん座" + b);
                    }
                    else if (date >= 24)
                    {
                        Console.Write(a + "さそり座" + b);
                    }
                }
                else if (month == 11)
                {
                    if (date <= 22)
                    {
                        Console.Write(a + "さそり座" + b);
                    }
                    else if (date >= 23)
                    {
                        Console.Write(a + "いて座" + b);
                    }
                }
                else if (month == 12)
                {
                    if (date <= 21)
                    {
                        Console.Write(a + "いて座" + b);
                    }
                    else if (date >= 22)
                    {
                        Console.Write(a + "やぎ座" + b);
                    }
                }
                else if (month < 1)
                {
                    Console.Write("正しくありません");
                }else if(month > 12){
                    Console.Write("正しくありません");
                }else if(date < 1)
                {
                    Console.Write("正しくありません");
                }else if(date > 31)
                {
                    Console.Write("正しくありません");
                }
                Console.Write("終了したいばあいは、『e』を入力してください。");
                if(Console.ReadLine() == "e")
                {
                    break;
                }
                
            }
        }
    }
}
