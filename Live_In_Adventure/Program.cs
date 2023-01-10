using System;
using static Live_In_Adventure.Interface;

namespace Live_In_Adventure
{
    public class Program
    {
        static void Main(string[] args)
        {


            //User user = new User();
            Screen screen = new Screen();

            Console.SetCursorPosition(0, 0);
            //{!타이틀 구현
            screen.ScreenTitle();

            Console.SetCursorPosition(0, 0);
            screen.SetScreen();

            //{!게임 실행
            while (true)
            {                                
                Console.SetCursorPosition(0, 0);
                screen.ScreenGame();               
            }   //Main      
                

        }       //class program
        /*
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
        */



    }       //namespace
}