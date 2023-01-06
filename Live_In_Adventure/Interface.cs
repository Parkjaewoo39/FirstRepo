using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Live_In_Adventure
{
    
    public class Interface
    { }

    public class User
    {
        public void userStatus() 
        {
            //!{유저 시작 랜덤스탯
            Random random = new Random();                               //배열에 담은 것을 무작위로 꺼내기위해 난수 선언
            Random ranStatus = new Random();                            // 각 배열 스테이터스의 최소부터 최대값

            int[] charStatus = new int[6] { 5, 5, 5, 5, 5, 5 };         //힘, 민첩, 지능, 카리스마, 건강, 지혜

            int[] statusSum = new int[6];

            for (int index = 0; index < charStatus.Length; index++)
            {
                int ranS = ranStatus.Next(0, 5 + 1);
                statusSum[index] = charStatus[index] + ranS;
                charStatus[index] = statusSum[index];
            }
            Console.WriteLine(
               "힘 {0} \n" + "민첩 {1}\n" + "지능 {2}\n" +
               "카리스마 {3} \n" + "건강 {4}\n" + "지혜 {5}\n",
               charStatus[0], charStatus[1], charStatus[2],
               charStatus[3], charStatus[4], charStatus[5]);

            //!}유저 시작 랜덤스탯
        }
        public void userHp() 
        {
            int MaxHp = 100;
            int userHp = 100;
            Console.Write("HP : ");
            for (int i = 0; i < userHp/MaxHp; i++)             
            {
                Console.WriteLine("■");

            }            
            
        }       //유저Hp()함수

        public void userMental() 
        {
            int userMental = 0;
            Console.Write("정신력 : ");
            for (int i = 0; i < 5; i++) 
            {
                
                Console.Write("●");
            }
        }       //유저Mental()함수
        
        

    }   //class User

    public class Inventory
    {
            
        public  void useInventory() 
        {
            List<string , int> inventory = new List<string , int>();
            
        }
           
    }
    //public class Inventory 
    //{
    //    Dictionary<string, int> inventory = new Dictionary<string, int>();
    //    //준일님 설명
    //    // 이름과 값을 같이 저장하는데 이름을 검색하면 값이 오고, 값을치면 이름이 온다.
    //    //Inventory
        
    //    void ASd()
    //    {
    //        List<string> inventoryKeys = inventory.Keys.ToList();   //순서대로 찾을때 오래 걸리니깐 리스트에 넣어서 
    //        inventoryKeys.Sort();                                   //정리를 해야 빠르다.

    //        foreach(string keys_ in inventoryKeys)
    //        {
    //            inventory[keys_] 
    //        }
    //    }


    //}
    
}
