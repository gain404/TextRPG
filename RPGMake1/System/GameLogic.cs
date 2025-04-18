using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.Scene;

namespace RPGMake1.System
{
    class GameLogic
    {
        static void Main()
        {
            GameManager gameManager = new GameManager();

            var mainScene = new MainScene();
            mainScene.GameStart();

            Console.Write(GameManager.Instance.ToString);

        }
    }
}
