using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.GameData;
using RPGMake1.Scene;

namespace RPGMake1.Scene
{
    internal class StatusScene
    {
        private Status status1;

        public StatusScene(Status status)
        {
            status1 = status;
        }


        public void StatusScript()
        {

            Console.WriteLine("상태 보기 \n캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{status1.Playerlevel}");
            Console.WriteLine("Chad (전사)");
            Console.WriteLine($"공격력 : {status1.PlayerhitScore}");
            Console.WriteLine($"방어력 : {status1.PlayershieldScore}");
            Console.WriteLine($"체 력 : {status1.Playerstamina}");
            Console.WriteLine($"Gold : {status1.Playergold}");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            string input = Console.ReadLine();
            if (input == "0")
            {
                MainScene mainScene = new MainScene();
                //return
                mainScene.GameStart();
            }
        }
    }
}
