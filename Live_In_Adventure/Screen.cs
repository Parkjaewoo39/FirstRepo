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
        int arrow_y = 50;
        int[,] gameBoard = new int[BOARD_Y, BOARD_X];       //정수형 게임판 선언



        bool isTitleEnter = false;      //타이틀 끝내는 bool
        bool isGameOver = false;        //게임 끝내는 bool

        string enterStart = string.Empty;                           //string 타입으로 타이틀 넘기는 용도
        string userNameInput = string.Empty;                        //모험가의 이름 입력용도   
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
            Console.WriteLine("이름을 생각하시오 : ".PadLeft(44, ' '));
            Console.SetCursorPosition(53, 20);
            userNameInput = Console.ReadLine();
            Console.Clear();
        }    //ScreenTitle()        
        
        //!}타이틀

        public void SetScreen()
        {
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
                }

            }
            //모양을 위해 좌표값 필요한 부분은 지정해서 바꿈.
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
            gameBoard[arrow_y, arrow_x] = 0;
        }

        //!{게임화면
        public void ScreenGame()
        {
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
            Console.SetCursorPosition(0, 0);

            ConsoleKeyInfo c;

            gameBoard[arrow_y, arrow_x] = 0;

           
            c = Console.ReadKey();
            switch (c.Key)
            {
                case ConsoleKey.UpArrow:
                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y -= 2;
                    gameBoard[arrow_y, arrow_x] = 0;
                    
                    break;

                case ConsoleKey.DownArrow:
                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_y += 2;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.LeftArrow:
                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x -= 2;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;

                case ConsoleKey.RightArrow:
                    gameBoard[arrow_y, arrow_x] = -1;
                    arrow_x += 2;
                    gameBoard[arrow_y, arrow_x] = 0;
                    break;
            }



            //!}유저 이름 체력 정신력                

            // Shop shop = new Shop();
            // Console.ReadKey();
            // Command Command = new Command();
            Inventory inventory = new Inventory();

            //===========================================
            //                 이벤트 발생
            // ===========================================

            //while (true)
            //{



            //}//while 이벤트 
        }    //}!게임 실행
             //isGameOver = true;
             //Console.WriteLine();
    }
    //!}게임화면


}




