using System;
using static Live_In_Adventure.Interface;

namespace Live_In_Adventure
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

                                  
            //{!게임 실행
            while (true)
            {
                //{!타이틀 구현

                string enterStart = string.Empty;                           //타이틀 넘기는 용도
                string userNameInput = string.Empty;                        //모험가의 이름 입력용도                

                Console.WriteLine("==================================");
                Console.WriteLine("==================================");
                Console.WriteLine("\t  죽으러 가는 자\n\n\t     기억의 샘 " +   //타이틀과 부제
                    "\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\t   E N T E R ");                       //TAP하여 시작하라는 구절 출력.
                Console.WriteLine("==================================");
                Console.WriteLine("==================================");
                enterStart = Console.ReadLine();                            //문자열을 입력하게 하는 선언.

                Console.WriteLine();                                        //빈공간
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("================================");

                //!{유저의 이름 입력

                Console.Write("이름 입력 : ");
                userNameInput = Console.ReadLine();

                Console.WriteLine("================================");

                //!}유저의 이름 입력

                Console.WriteLine("??? : 어이!, {0}! 여기서 또 잠들어 있구만.", userNameInput);
                Console.WriteLine("{0} : (깨질듯한 두통", userNameInput);

                //}!타이틀 구현

                Console.WriteLine("{0}", userNameInput);
                user.userStatus();
                user.userHp();
                user.userMental();

                //!{유저 이름 체력 정신력
                string userName;
                userName = userNameInput;
                
                //!}유저 이름 체력 정신력


                //!{인벤토리
                //집에서
                //!}인벤토리

                //===========================================
                //                 이벤트 발생
                // ===========================================
                while (true)
                {
                    int userHp = 100;
                    int userHpMAX = 100;
                    int userMental = 0;

                    






                }//while 이벤트 
            }    //}!게임 실행
        }   //Main      

    }       //class program
    //public struct User 
    //{
    //    public string Name;
    //    public int HP;
    //    public int MENTAL;

    //    public int STR;
    //    public int DEX;
    //    public int INT;
    //    public int CHARISMA;
    //    public int HEALTH;
    //    public int WISDOM;

    //    public int LevelUpStat;
    //    public int Exp;

    //    public void UserStatus()
    //    {
    //        Console.WriteLine("");
    //        Console.WriteLine("힘 {0} \n" + "민첩 {1}\n" + "지능 {2}\n" +
    //               "카리스마 {3} \n" + "건강 {4}\n" + "지혜 {5}\n",STR,DEX,INT,CHARISMA,HEALTH,WISDOM );
    //    }
    //}
    //public void userSta 
    //{
        
    //}

    

}       //namespace