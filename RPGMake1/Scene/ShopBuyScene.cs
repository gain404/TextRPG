using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.GameData;
using RPGMake1.System;

namespace RPGMake1.Scene
{
    class ShopBuyScene
    {

        bool buyitem = false;
        //Item item;
        //Status status1;

        //public ShopBuyScene(Status status)
        //{
        //    status1 = status;
        //}

        ////public void Buyshop(Item sharedItem, Status playerStatus)
        ////{
        ////    item = sharedItem;
        ////    status1 = playerStatus;
        ////}

        public void Buy()
        {
            var status = GameManager.Instance.Status;
            var item = GameManager.Instance.Item;

            Console.WriteLine("상점-아이템 구매\n필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{status.Playergold}G \n");

            Console.WriteLine("[아이템 목록]");
            item.IdxCall();

            Console.WriteLine();
            Console.WriteLine("0. 나가기\n");

            Console.Write("원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();

            int selectIndex;
            if (int.TryParse(input, out selectIndex) && selectIndex >= 1 && selectIndex <= item.items.Count)
            {
                ItemStruct selectedItem = item.items[selectIndex - 1];
                BuyItem(selectedItem,GameManager.Instance.Status);
            }
            else if (input == "0")
            {
                MainScene mainScene = new MainScene();
                mainScene.GameStart();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
            
        }

        public void BuyItem(ItemStruct selectedItem, Status Playergold)
        {

            /*var status = GameManager.Instance.Status; */


            //status = Playergold;
            //var item = GameManager.Instance.Item;

            //구매가 가능하다면
            if (!buyitem)
            {
                //1. 보유 금액이 충분하다면
                if (GameManager.Instance.Status.Playergold > selectedItem.itemGolds)
                {
                    Console.WriteLine($"[{selectedItem.itemName}] 아이템 구매하기");
                    Console.WriteLine("구매를 완료했습니다!");

                    Console.WriteLine($"{GameManager.Instance.Status.Playergold} - {selectedItem.itemGolds}\n");
                    GameManager.Instance.Status.Playergold -= selectedItem.itemGolds;
                    Console.WriteLine($"보유 재화 : {GameManager.Instance.Status.Playergold}\n");

                    buyitem = true;
                }
                //2. 보유 금액이 부족하다면
                else if (GameManager.Instance.Status.Playergold < selectedItem.itemGolds)
                {
                    Console.WriteLine("Gold가 부족합니다.");
                }
            }
            //이미 구매한 아이템이라면
            else if (buyitem)
            {
                Console.WriteLine("이미 구매한 아이템입니다.");
            }

            Console.WriteLine("0 : 돌아가기");
            Console.Write(">>");
            string input = Console.ReadLine();
            if (input == "0")
            {
                MainScene mainScene = new MainScene();
                mainScene.GameStart();
            }

        }

    }
}
