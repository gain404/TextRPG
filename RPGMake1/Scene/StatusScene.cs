using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.GameData;
using RPGMake1.Scene;
using RPGMake1.System;

namespace RPGMake1.Scene
{
    internal class StatusScene
    {
        //private Status status1;

        //public StatusScene(Status status)
        //{
        //    status1 = status;
        //}

        
        public void StatusScript()
        {

            Console.WriteLine("상태 보기 \n캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{GameManager.Instance.Status.Playerlevel}");
            Console.WriteLine("Chad (전사)");
            Console.WriteLine($"공격력 : {GameManager.Instance.Status.PlayerhitScore}");
            Console.WriteLine($"방어력 : {GameManager.Instance.Status.PlayershieldScore}");
            Console.WriteLine($"체 력 : {GameManager.Instance.Status.Playerstamina}");
            Console.WriteLine($"Gold : {GameManager.Instance.Status.Playergold}");
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
