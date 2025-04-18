using System;
using System.ComponentModel;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading.Tasks.Sources;
using RPGMake1.GameData;

namespace RPGMake1.Scene
{
    

    class MainScene
    {
        private Status status;

        //public string name { get; set; }

        public void GameStart()
        {
            StatusScene shareData = new StatusScene(status);
            var a = new StatusScene(status);
            var b = new Status();


            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다!");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기 \n2. 인벤토리 \n3. 상점");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.\n>>");

            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    a.StatusScript();
                    break;
                case "2":
                    InventoryScene inventory = new InventoryScene();
                    inventory.InventoryScripts();
                    break;
                case "3":
                    ShopScene shop = new ShopScene();
                    shop.Shops();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }

        }
    }
      

}
