using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_In_Adventure
{



    public class Screen
    {

        User user = new User();


        const int BOARD_X = 50;     //배열판 가로
        const int BOARD_Y = 60;     //배열판 세로
        int arrow_x = 40;
        int arrow_y = 47;
        int[,] gameBoard = new int[BOARD_Y, BOARD_X];       //정수형 게임판 선언

        bool isTitleEnter = false;      //타이틀 끝내는 bool
        bool isGameOver = false;        //게임 끝내는 bool

        string enterStart = string.Empty;                //string 타입으로 타이틀 넘기는 용도                                 
        string userNameInput = string.Empty;             //모험가의 이름 입력용도 

        //!{타이틀
        public void ScreenTitle()
        {
            while (isTitleEnter == false)
            {
                for (int y = 0; y < BOARD_Y; y++)
                {
                    for (int x = 0; x < BOARD_X; x++)
                    {
                        gameBoard[y, x] = -1;
                        //-1빈칸
                        if (x == 0 || x == 49)
                        {
                            gameBoard[y, x] = -3;
                        }    //조건식 테두리
                        else if (y == 0 || y == 59)
                        {
                            gameBoard[y, x] = -4;
                        }

                    }
                    gameBoard[59, 0] = -7;
                    gameBoard[0, 0] = -5;
                    gameBoard[0, 49] = -6;
                    gameBoard[59, 49] = -8;

                }
                for (int y = 0; y < BOARD_Y; y++)
                {
                    for (int x = 0; x < BOARD_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case -8:
                                Console.Write("┛".PadRight(2, ' '));
                                break;
                            case -7:
                                Console.Write("┗".PadRight(2, ' '));
                                break;
                            case -6:
                                Console.Write("┓".PadRight(2, ' '));
                                break;
                            case -5:
                                Console.Write("┏".PadRight(2, ' '));
                                break;
                            case -4:
                                Console.Write("━".PadRight(2, ' '));
                                break;
                            case -3:
                                Console.Write("│".PadRight(2, ' '));
                                break;

                            case -1:
                                Console.Write(" ".PadRight(2, ' '));
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                isTitleEnter = true;
            }   //while
            Console.SetCursorPosition(1, 20);
            Console.WriteLine("죽으러 가는 자".PadLeft(45, ' '));   //타이틀과 부제                
            Console.SetCursorPosition(1, 30);
            Console.WriteLine("E N T E R".PadLeft(48, ' '));                       //TAP하여 시작하라는 구절 출력.
            enterStart = Console.ReadLine();

            Console.SetCursorPosition(1, 30);
            Console.WriteLine(" ".PadLeft(48, ' '));
            //!{유저의 이름 입력
            Console.SetCursorPosition(1, 20);
            Console.WriteLine("이름을 입력하시오 : ".PadLeft(44, ' '));
            Console.SetCursorPosition(53, 20);
            userNameInput = Console.ReadLine();
            Console.Clear();
        }    //ScreenTitle()        

        //!}타이틀

        //!{판때기 셋업
        public void SetScreen()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < BOARD_Y; y++)       //판때기 y
            {
                for (int x = 0; x < BOARD_X; x++)       //판때기x

                {
                    gameBoard[y, x] = -1;
                    //-1빈칸
                    if (x == 0 || x == 49)
                    {
                        gameBoard[y, x] = -3;
                    }    //조건식 테두리
                    else if ((x == 11 && 45 <= y) || (x == 38 && 45 <= y))
                    {
                        gameBoard[y, x] = -3;
                    }
                    else if (y == 0 || y == 59 || y == 45)
                    {
                        gameBoard[y, x] = -4;
                    }
                    gameBoard[0, 0] = -5;
                    gameBoard[0, 49] = -6;
                    gameBoard[59, 0] = -7;
                    gameBoard[59, 49] = -8;
                    gameBoard[45, 0] = -9;
                    gameBoard[45, 49] = -10;
                    gameBoard[45, 11] = -12;
                    gameBoard[45, 38] = -12;
                    gameBoard[59, 11] = -11;
                    gameBoard[59, 38] = -11;
                }

            }
            for (int y = 0; y < BOARD_Y; y++)
            {
                for (int x = 0; x < BOARD_X; x++)
                {
                    switch (gameBoard[y, x])
                    {
                        case -12:
                            Console.Write("┳".PadRight(2, ' '));
                            break;
                        case -11:
                            Console.Write("┹".PadRight(2, ' '));
                            break;
                        case -10:
                            Console.Write("┫".PadRight(2, ' '));
                            break;
                        case -9:
                            Console.Write("┣".PadRight(2, ' '));
                            break;
                        case -8:
                            Console.Write("┛".PadRight(2, ' '));
                            break;
                        case -7:
                            Console.Write("┗".PadRight(2, ' '));
                            break;
                        case -6:
                            Console.Write("┓".PadRight(2, ' '));
                            break;
                        case -5:
                            Console.Write("┏".PadRight(2, ' '));
                            break;
                        case -4:
                            Console.Write("━".PadRight(2, ' '));
                            break;
                        case -3:
                            Console.Write("│".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write(" ".PadRight(2, ' '));
                            break;

                        case 0:
                            Console.Write("▷");
                            break;

                    }       //보여주는 판 
                }
                Console.WriteLine();


            }
            gameBoard[arrow_y, arrow_x] = 0;

            //모양을 위해 좌표값 필요한 부분은 지정해서 바꿈.

            //!유저 이름
            Console.SetCursorPosition(4, 52);
            Console.WriteLine("이름 : {0} ".PadLeft(2, ' '), userNameInput.PadLeft(1, ' '));

            //!체력
            Console.SetCursorPosition(4, 53);
            user.userHp();

            Console.WriteLine();

            //!정신력
            Console.SetCursorPosition(4, 55);
            user.userMental();

            //!메이 화면의 선택지들 출력문
            Console.SetCursorPosition(83, 47);
            Console.Write("* 능력치");
            Console.SetCursorPosition(83, 50);
            Console.Write("* 인벤토리");
            Console.SetCursorPosition(83, 53);
            Console.Write("* 진행 한다");
            Console.SetCursorPosition(83, 56);
            Console.Write("* 무시 한다");
        }   //SetScreen()
        //!}판때기 셋업

        /*
        //public void SetScreen2()    //중간 출력창 초기화
        //{
        //    Console.SetCursorPosition(45, 11);
        //    while (isTitleEnter == false)
        //    {
        //        for (int y = 45; y < BOARD_Y; y++)
        //        {
        //            for (int x = 11; x <38; x++)
        //            {
        //                gameBoard[y, x] = -1;
        //                //-1빈칸
        //                if (x == 11 || x == 38)
        //                {
        //                    gameBoard[y, x] = -3;
        //                }    //조건식 테두리
        //                else if (y == 45 || y == 59)
        //                {
        //                    gameBoard[y, x] = -4;
        //                }

        //            }
        //            gameBoard[59, 11] = -7;
        //            gameBoard[59, 38] = -8;
        //            gameBoard[45, 11] = -5;
        //            gameBoard[45, 38] = -6;

        //        }
        //        for (int y = 0; y < BOARD_Y; y++)
        //        {
        //            for (int x = 0; x < BOARD_X; x++)
        //            {
        //                switch (gameBoard[y, x])
        //                {
        //                    case -8:
        //                        Console.Write("┛".PadRight(2, ' '));
        //                        break;
        //                    case -7:
        //                        Console.Write("┗".PadRight(2, ' '));
        //                        break;
        //                    case -6:
        //                        Console.Write("┓".PadRight(2, ' '));
        //                        break;
        //                    case -5:
        //                        Console.Write("┏".PadRight(2, ' '));
        //                        break;
        //                    case -4:
        //                        Console.Write("━".PadRight(2, ' '));
        //                        break;
        //                    case -3:
        //                        Console.Write("│".PadRight(2, ' '));
        //                        break;

        //                    case -1:
        //                        Console.Write(" ".PadRight(2, ' '));
        //                        break;
        //                }
        //            }
        //            Console.WriteLine();
        //        }

        //        isTitleEnter = true;
        //    }   //while
        //}   //SetScreen2() 
        */

        public class User
        {

            public const int BOARD_X = 50;     //배열판 가로
            public const int BOARD_Y = 60;     //배열판 세로
            public bool isCheckStat = false;
            public int arrow_x = 40;
            public int arrow_y = 47;
            public int[,] gameBoard = new int[BOARD_Y, BOARD_X];
            //힘 민 지 카 건 지
            public int[] saveStat = new int[6];

            public int[] charStatus = new int[6] { 5, 5, 5, 5, 5, 5 };         //힘, 민첩, 지능, 카리스마, 건강, 지혜

            public void userStatus()
            {
                //!{유저 시작 랜덤스탯
                Random random = new Random();                               //배열에 담은 것을 무작위로 꺼내기위해 난수 선언
                Random ranStatus = new Random();                            // 각 배열 스테이터스의 최소부터 최대값
                ConsoleKeyInfo c;


                //int[] statusSum = new int[6];
                bool statStop = false;

                if (isCheckStat == false)
                {

                    for (int index = 0; index < charStatus.Length; index++)
                    {
                        int ranS = ranStatus.Next(0, 5 + 1);
                        charStatus[index] = charStatus[index] + ranS;
                        saveStat[index] = charStatus[index];

                    }
                }
                else { /*Do Nothing*/}

                Console.SetCursorPosition(38, 48);
                Console.WriteLine("힘 {0}", charStatus[0]);
                Console.SetCursorPosition(48, 48);
                Console.WriteLine("민첩 {0}", charStatus[1]);
                Console.SetCursorPosition(38, 50);
                Console.WriteLine("지능 {0}", charStatus[2]);
                Console.SetCursorPosition(48, 50);
                Console.WriteLine("카리스마 {0}", charStatus[3]);
                Console.SetCursorPosition(38, 52);
                Console.WriteLine("건강 {0}", charStatus[4]);
                Console.SetCursorPosition(48, 52);
                Console.WriteLine("지혜 {0}", charStatus[5]);
                isCheckStat = true;
                Console.ReadLine();
                //!}유저 시작 랜덤스탯           

            }   //userStatus()
            public void userHp()
            {
                int userHp = 100;
                int userHpMax = userHp;
                int playerHpPer = userHp * 100 / userHp;
                Console.Write("체력 :{0}/{1}", userHp, userHpMax);
                Console.SetCursorPosition(2, 54);
                for (int i = 0; i < playerHpPer / 10; i++)
                {
                    Console.Write("■");
                }
                for (int i = 10; playerHpPer / 10 < i; i -= 1)
                {
                    Console.Write("□");
                }
            }       //userHP()                   

            public void userMental()
            {
                int userMental = 5;
                int userMentalMax = userMental;
                Console.Write("정신력 : {0}/{1}\n", userMental, userMentalMax);
                Console.SetCursorPosition(2, 56);
                for (int i = 0; i < userMental; i++)
                {
                    Console.Write("●");
                }
                for (int i = 5; userMental < i; i -= 1)
                {
                    Console.Write("◎");
                }
                Console.WriteLine();
            }       //유저Mental()함수       

        }   //class User

        //!{게임화면
        public void ScreenGame()
        {


            Story story = new Story();
            for (int y = 0; y < BOARD_Y; y++)
            {
                for (int x = 0; x < BOARD_X; x++)
                {
                    switch (gameBoard[y, x])
                    {
                        case -12:
                            Console.Write("┳".PadRight(2, ' '));
                            break;
                        case -11:
                            Console.Write("┹".PadRight(2, ' '));
                            break;
                        case -10:
                            Console.Write("┫".PadRight(2, ' '));
                            break;
                        case -9:
                            Console.Write("┣".PadRight(2, ' '));
                            break;
                        case -8:
                            Console.Write("┛".PadRight(2, ' '));
                            break;
                        case -7:
                            Console.Write("┗".PadRight(2, ' '));
                            break;
                        case -6:
                            Console.Write("┓".PadRight(2, ' '));
                            break;
                        case -5:
                            Console.Write("┏".PadRight(2, ' '));
                            break;
                        case -4:
                            Console.Write("━".PadRight(2, ' '));
                            break;
                        case -3:
                            Console.Write("│".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write(" ".PadRight(2, ' '));
                            break;

                        case 0:
                            Console.Write("▷");
                            break;

                    }       //보여주는 판 
                }
                Console.WriteLine();
            }


            //!유저 이름
            Console.SetCursorPosition(4, 52);
            Console.WriteLine("이름 : {0} ".PadLeft(2, ' '), userNameInput.PadLeft(1, ' '));

            //!체력
            Console.SetCursorPosition(4, 53);
            user.userHp();

            Console.WriteLine();

            //!정신력
            Console.SetCursorPosition(4, 55);
            user.userMental();

            //!메이 화면의 선택지들 출력문
            Console.SetCursorPosition(83, 47);
            Console.Write("* 능력치");
            Console.SetCursorPosition(83, 50);
            Console.Write("* 인벤토리");
            Console.SetCursorPosition(83, 53);
            Console.Write("* 진행 한다");
            Console.SetCursorPosition(83, 56);
            Console.Write("* 무시 한다");

            Console.SetCursorPosition(0, 0);

            //!방향키 입력
            ConsoleKeyInfo c;
            gameBoard[arrow_y, arrow_x] = 0;
            c = Console.ReadKey();
            switch (c.Key)
            {
                case ConsoleKey.UpArrow:
                    if (47 >= arrow_y) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y -= 3;
                    gameBoard[arrow_y, arrow_x] = 0;

                    break;

                case ConsoleKey.DownArrow:
                    if (56 <= arrow_y) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y += 3;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.LeftArrow:
                    if (arrow_x <= 40) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x -= 4;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.RightArrow:
                    if (44 <= arrow_x) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x += 4;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.Spacebar:

                    if (47 == arrow_y)
                    {
                        SetScreen();
                        Console.SetCursorPosition(83, 47);
                        user.userStatus();

                    }
                    else if (50 == arrow_y)
                    {
                        SetScreen();
                        Inventory inventory = new Inventory();
                    }
                    else if (53 == arrow_y)
                    {
                        SetScreen();
                        Console.SetCursorPosition(38, 48);
                        story.mainStoryOne();
                    }
                    else if (56 == arrow_y)
                    {
                        SetScreen();

                    }
                    break;



            }    //!}게임 실행
                 //isGameOver = true;
                 //Console.WriteLine();
        }
        public void SetBattleScreen()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < BOARD_Y; y++)       //판때기 y
            {
                for (int x = 0; x < BOARD_X; x++)       //판때기x

                {
                    gameBoard[y, x] = -1;
                    //-1빈칸
                    if (x == 0 || x == 49)
                    {
                        gameBoard[y, x] = -3;
                    }    //조건식 테두리
                    else if ((x == 11 && 45 <= y) || (x == 38 && 45 <= y))
                    {
                        gameBoard[y, x] = -3;
                    }
                    else if (y == 0 || y == 59 || y == 45)
                    {
                        gameBoard[y, x] = -4;
                    }
                    gameBoard[0, 0] = -5;
                    gameBoard[0, 49] = -6;
                    gameBoard[59, 0] = -7;
                    gameBoard[59, 49] = -8;
                    gameBoard[45, 0] = -9;
                    gameBoard[45, 49] = -10;
                    gameBoard[45, 11] = -12;
                    gameBoard[45, 38] = -12;
                    gameBoard[59, 11] = -11;
                    gameBoard[59, 38] = -11;
                }

            }
            for (int y = 0; y < BOARD_Y; y++)
            {
                for (int x = 0; x < BOARD_X; x++)
                {
                    switch (gameBoard[y, x])
                    {
                        case -12:
                            Console.Write("┳".PadRight(2, ' '));
                            break;
                        case -11:
                            Console.Write("┹".PadRight(2, ' '));
                            break;
                        case -10:
                            Console.Write("┫".PadRight(2, ' '));
                            break;
                        case -9:
                            Console.Write("┣".PadRight(2, ' '));
                            break;
                        case -8:
                            Console.Write("┛".PadRight(2, ' '));
                            break;
                        case -7:
                            Console.Write("┗".PadRight(2, ' '));
                            break;
                        case -6:
                            Console.Write("┓".PadRight(2, ' '));
                            break;
                        case -5:
                            Console.Write("┏".PadRight(2, ' '));
                            break;
                        case -4:
                            Console.Write("━".PadRight(2, ' '));
                            break;
                        case -3:
                            Console.Write("│".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write(" ".PadRight(2, ' '));
                            break;

                        case 0:
                            Console.Write("▷");
                            break;

                    }       //보여주는 판 
                }
                Console.WriteLine();


                gameBoard[47, 40] = 0;
            }

            //모양을 위해 좌표값 필요한 부분은 지정해서 바꿈.

            //!유저 이름
            Console.SetCursorPosition(4, 52);
            Console.WriteLine("이름 : {0} ".PadLeft(2, ' '), userNameInput.PadLeft(1, ' '));

            //!체력
            Console.SetCursorPosition(4, 53);
            user.userHp();

            Console.WriteLine();

            //!정신력
            Console.SetCursorPosition(4, 55);
            user.userMental();

            //!메이 화면의 선택지들 출력문
            Console.SetCursorPosition(83, 47);
            Console.Write("* 싸운다");
            Console.SetCursorPosition(83, 50);
            Console.Write(" ");
            Console.SetCursorPosition(83, 53);
            Console.Write(" ");
            Console.SetCursorPosition(83, 56);
            Console.Write("* 무시 한다");

            ConsoleKeyInfo c;
            gameBoard[arrow_y, arrow_x] = 0;
            c = Console.ReadKey();
            switch (c.Key)
            {
                case ConsoleKey.UpArrow:
                    if (47 >= arrow_y) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y -= 3;
                    gameBoard[arrow_y, arrow_x] = 0;

                    break;

                case ConsoleKey.DownArrow:
                    if (56 <= arrow_y) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y += 3;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.LeftArrow:
                    if (arrow_x <= 40) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x -= 4;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.RightArrow:
                    if (44 <= arrow_x) { break; }

                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x += 4;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;
                case ConsoleKey.Spacebar:

                    if (47 == arrow_y)
                    {
                        SetScreen();
                        Console.SetCursorPosition(83, 47);


                    }
                    else if (56 == arrow_y)
                    {
                        SetScreen();

                    }
                    break;
            }   //SetScreen()

            //!}게임화면

        }
    }
}




