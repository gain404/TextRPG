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
        Item item;
        Status status1;

        public ShopBuyScene(Status status)
        {
            status1 = status;
        }

        //public void Buyshop(Item sharedItem, Status playerStatus)
        //{
        //    item = sharedItem;
        //    status1 = playerStatus;
        //}

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
                BuyItem(selectedItem);
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
            //Status status = new Status();
            //Item item = new Item();
            /*var status = GameManager.Instance.Status; *///얘는 지금... Status의 값을 status에다가 복사한거라서 원본에는 아무런 변경점이 없고
            //저 변수에만 변화가 생긴 거지
            //todo 이 status의 값을 원본에다 다시 보내는 방법 또는
            //원본을 참조해서 넣으라고?
            //근데 참조가 너무 어려워
            //getter setter 메소드 찾아보기 지금은졸려
            //참조가 너무 어려워................
            status1 = Playergold;
            var item = GameManager.Instance.Item;

            //구매가 가능하다면
            if (!buyitem)
            {
                //1. 보유 금액이 충분하다면
                if (status1.Playergold > selectedItem.itemGolds)
                {
                    Console.WriteLine($"[{selectedItem.itemName}] 아이템 구매하기");
                    Console.WriteLine("구매를 완료했습니다!");

                    Console.WriteLine($"{status1.Playergold} - {selectedItem.itemGolds}\n");
                    status1.Playergold -= selectedItem.itemGolds;
                    Console.WriteLine($"보유 재화 : {status1.Playergold}\n");

                    buyitem = true;
                }
                //2. 보유 금액이 부족하다면
                else if (status1.Playergold < selectedItem.itemGolds)
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
