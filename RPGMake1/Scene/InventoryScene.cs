using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMake1.Scene
{
    internal class InventoryScene
    {

        public void InventoryScripts()
        {
            Console.WriteLine("인벤토리 \n보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리\n0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    EquipScene installation = new EquipScene();
                    installation.Install();
                    break;
                case "0":
                    MainScene mainScene = new MainScene();
                    mainScene.GameStart();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }    
}
