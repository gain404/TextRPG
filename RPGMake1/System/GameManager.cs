using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMake1.GameData;
using RPGMake1.Scene;

namespace RPGMake1.System
{
    public  class GameManager
    {

        //싱글톤 인스턴스 선언
        public static GameManager Instance; 
        

        public GameManager()
        {
            Instance = this;
        }

        //프로퍼티로 만들기
        //값을 캡슐화해서 마음대로 설정하고 출력할 수 있음
        public Status Status { get; set; } //Status 클래스를 프로퍼티화 한 것 //왜?????
        public Item Item { get; set; }
        public ShopScene Shop { get; set; }
        public Inventory Inventory { get; set; }

        

        void Gamemanager()
        {
            Status = new Status();  //여기부터 아래까지 전부 초기화용
            Item = new Item();
            Shop = new ShopScene();
            Inventory = new Inventory();

            Item.ItemList();
        }


    }
}
