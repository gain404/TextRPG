using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGMake1.GameData
{

    public struct ItemStruct
    {
        public string itemName;
        public int itemScore;
        public string itemAccount;
        public int itemGolds;
    }

    public class Item
    {
        public List<ItemStruct> items = new List<ItemStruct>();
        int idx;

        public void ItemList()
        {
            ItemStruct item1;
            item1.itemName = "수련자 갑옷";
            item1.itemScore = 5;
            item1.itemAccount = "수련에 도움을 주는 갑옷입니다.";
            item1.itemGolds = 1000;
            items.Add(item1);

            ItemStruct item2;
            item2.itemName = "무쇠갑옷";
            item2.itemScore = 9;
            item2.itemAccount = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            item2.itemGolds = 2500;
            items.Add(item2);

            ItemStruct item3;
            item3.itemName = "스파르타의 갑옷";
            item3.itemScore = 15;
            item3.itemAccount = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            item3.itemGolds = 3500;
            items.Add(item3);

            ItemStruct item4;
            item4.itemName = "낡은 검";
            item4.itemScore = 2;
            item4.itemAccount = "쉽게 볼 수 있는 낡은 검입니다.";
            item4.itemGolds = 600;
            items.Add(item4);

            ItemStruct item5;
            item5.itemName = "청동 도끼";
            item5.itemScore = 5;
            item5.itemAccount = "어디선가 사용됐던 것 같은 도끼입니다.";
            item5.itemGolds = 1500;
            items.Add(item5);

            ItemStruct item6;
            item6.itemName = "스파르타의 창";
            item6.itemScore = 7;
            item6.itemAccount = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            item6.itemGolds = 3000;
            items.Add(item6);
        }

        public void ItemCall()
        {
            ItemList();

            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                Console.WriteLine($"- {item.itemName}  |  {item.itemScore}  |  {item.itemAccount}  |  {item.itemGolds} G");
            }
        }



        public void IdxCall()
        {
            ItemList();

            for (int i = 0; i < items.Count; i++)
            {
                idx = i;
                var item = items[i];
                Console.WriteLine($"- - [{idx + 1 }] {item.itemName}  |  {item.itemScore}  |  {item.itemAccount}  |  {item.itemGolds} G");
            }

        }
    }
}
