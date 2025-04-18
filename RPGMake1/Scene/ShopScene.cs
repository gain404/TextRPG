using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.GameData;

namespace RPGMake1.Scene
{
    public class ShopScene
    {
        
        public void Shops()
        {
            
            Status status = new Status();
            Item item = new Item();


            Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.\n");
           

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{status.Playergold}G");
            Console.WriteLine();


            Console.WriteLine("[아이템 목록]");
            item.ItemCall();

            Console.WriteLine();
            Console.WriteLine("1. 아이템 사기\n0. 나가기\n");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            string input = Console.ReadLine();
            if (input == "0")
            {
                MainScene mainScene = new MainScene();
                mainScene.GameStart();
            }
            else if (input == "1")
            {
                ShopBuyScene shopbuy = new ShopBuyScene();
                shopbuy.Buy();
            }
        }
    }
}
