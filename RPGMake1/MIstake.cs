using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMake1
{
    internal class MIstake
    {
        /*
    class Item
    {
        List<int> items = new List<int>();

        int htscore = 0;
        int sdscore = 0;
        

        public void ItemUse()
        {
            string htscoreWrite = $"공격력 +{htscore}";
            string sdscoreWrite = $"방어력 +{sdscore}";

            string input = Console.ReadLine();

            foreach (int item in items)
            {
                switch (input)
                {
                    case "1":
                        {
                            sdscore = 5;
                            Console.WriteLine($"1. 수련자 갑옷 | {sdscoreWrite} | 수련에 도움을 주는 갑옷입니다.");
                            break;
                        }
                    case "2":
                        {
                            sdscore = 9;
                            Console.WriteLine($"2. 무쇠갑옷 | {sdscoreWrite} | 무쇠로 만들어져 튼튼한 갑옷입니다.");
                            break;
                        }
                    case "3":
                        {
                            sdscore = 15;
                            Console.WriteLine($"3. 스파르타의 갑옷 | {sdscoreWrite} | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.");
                            break;
                        }
                    case "4":
                        {
                            htscore = 2;
                            Console.WriteLine($"4. 낡은 검 |  {htscoreWrite} | 쉽게 볼 수 있는 낡은 검 입니다.");
                            break;
                        }
                    case "5":
                        {
                            htscore = 5;
                            Console.WriteLine($"5. 청동 도끼 | {htscoreWrite} | 어디선가 사용됐던거 같은 도끼입니다.");
                            break;
                        }
                    case "6":
                        {
                            htscore = 7;
                            Console.WriteLine($"6. 스파르타의 창 | {htscoreWrite} | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
                            break;
                        }
                }



            }

            //ItemDelegate itemDelegate = (item) => item += "Score";
            //ItemDelegate += 


            //string itemWrite = "{itemname} | {Score} | {account}";
        }
        
    
                       
    }
    */

/*

enum Itemenum
{
    armor1 = 0,
    armor2,
    armor3,
    shord,
    ex,
    lense = 6
}


public void Itemelement()
{

    //List<int> itemGolds = new List<int>() {0, 1, 2, 3, 4, 5, 6 };
    itemGolds = new int[(int)Itemenum.lense];
    itemGolds[0] = 1000;
    itemGolds[1] = 2500;
    itemGolds[2] = 3500;
    itemGolds[3] = 600;
    itemGolds[4] = 1500;
    itemGolds[5] = 3000;


    itemNames = new string[(int)Itemenum.lense];
    itemNames[0] = "수련자 갑옷";
    itemNames[1] = "무쇠갑옷";
    itemNames[2] = "스파르타의 갑옷";
    itemNames[3] = "낡은 검";
    itemNames[4] = "청동 도끼";
    itemNames[5] = "스파르타의 창";

    itemScore = new string[(int)Itemenum.lense];
    itemScore[0] = $"{shieldScore} +5";
    itemScore[1] = $"{shieldScore} +9";
    itemScore[2] = $"{shieldScore} +15";
    itemScore[3] = $"{hitScore} +2";
    itemScore[4] = $"{hitScore} +5";
    itemScore[5] = $"{hitScore} +7";

    itemAccount = new string[(int)(Itemenum.lense)];
    itemAccount[0] = "수련에 도움을 주는 갑옷입니다.";
    itemAccount[1] = "무쇠로 만들어져 튼튼한 갑옷입니다.";
    itemAccount[2] = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
    itemAccount[3] = "쉽게 볼 수 있는 낡은 검 입니다.";
    itemAccount[4] = "어디선가 사용됐던 것  같은 도끼입니다.";
    itemAccount[5] = "스파르타의 전사들이 사용했다는 전설의 창입니다.";

    items = new string[(int)Itemenum.lense];

    for (int i = 0; i < items.Length; i++)
    {
        items[i] = $"{itemNames[i]}  |  {itemScore[i]}  |  {itemAccount[i]}  |   {itemGolds[i]}G";
    }

}
*/

        /*
        switch (input)
        {
        case "1":
            {
                item.items.Find(x => x.itemName == "수련자 갑옷");
                BuyItem();
                break;
            }
        case "2":
            {
                item.items.Find(x => x.itemName == "item2");
                BuyItem();
                break;
            }
        case "3":
            {
                item.items.Find(x => x.itemName == "item3");
                break;
            }
        case "4":
            {
                item.items.Find(x => x.itemName == "item4");
                BuyItem();
                break;
            }
        case "5":
            {
                item.items.Find(x => x.itemName == "item5");
                BuyItem();
                break;
            }
        case "6":
            {
                item.items.Find(x => x.itemName == "item6");
                BuyItem();
                break;
            }
        case "0":
            {
                MainScene mainScene = new MainScene();
                mainScene.GameStart();
                break;
            }
        default:
            {
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }
        */
    }
}
