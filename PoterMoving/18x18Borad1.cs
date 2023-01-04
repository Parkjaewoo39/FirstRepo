using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoterMoving
{
   
    public class Board1
    {            
        public Board1()
        {
            Game();
        }

        public void Game()
        {
            const int BOARD_SIZE_X = 18;
            const int BOARD_SIZE_Y = 18;

            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];         //게임 보드 배열 사이즈

            int coinCount = 0;

            // 0이나 4값을 받으면 안되게?
            Color colorName = new Color();

            //판때기

            //loop 
            int playerX = 0;        //플레이어X축 정수
            int playerY = 0;        //플레이어Y축 정수
            Random ran = new Random();

            playerX = ran.Next(1, 18 + 1);
            playerY = ran.Next(1, 18 + 1);

            gameBoard[playerY, playerX] = 0;    //게임판 배열에 [.] 중앙 값을 플레이어에게 넣고 0값은 옷을 넣기 위해 선언.

            bool isVictory = false;
            bool isGameOver = false;

            bool onestop = false;



            for (int y = 0; y < BOARD_SIZE_Y; y++)           //y축 보드판을 만드는동안
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)       //x축 보드판도 같이 도는데
                {
                    gameBoard[y, x] = -1; //점
                    if (y == 0 || y == 18 || x == 0 || x == 18)
                    {
                        gameBoard[y, x] = -2;
                        gameBoard[playerY, playerX] = 0;                        
                        
                    }
                    //가변쪽이 아니면 *별

                }
            }

            //시작
            while (isGameOver == false)
            {
                /*
                //Console.WriteLine("===============================");

                //while (onestop == true)
                //{
                //   // Color.ColorFullString();
                //    break;
                //}
                //while (onestop == false)
                //{
                //    //colorName.ColorfullString();
                //    onestop = true;
                //    break;
                //}  
                */

                //{현재 보드 상태를 플레이 시점으로 보여준다.
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case -3:
                                Console.Write("○".PadRight(2, ' '));
                                break;

                            case -2:

                                Console.Write("■".PadRight(2, ' '));

                                break;
                            case -1:
                                Console.Write("*".PadRight(3, ' '));
                                break;
                            case 0:
                                Console.Write("◇".PadRight(2, ' '));
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("$".PadRight(3, ' '));
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                            //case 2:
                            //    Console.Write("△".PadRight(2, ' '));
                            //    break;
                            //case 3:
                            //    Console.Write("▽".PadRight(2, ' '));
                            //    break;
                            //case 4:
                            //    Console.Write("◁".PadRight(2, ' '));
                            //    break;
                            //case 5:
                            //    Console.Write("▷".PadRight(2, ' '));
                            //    break;

                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                bool peopleShiftValue = false;
                //}현재 보드 상태를 플레이 시점으로 보여준다. 끝.
                string inPut = string.Empty;
                string inPutTwo = string.Empty;

                Console.Write("wasd를 입력해 사람을 움직이시오.: \n게임 종료 버튼 [@]\n$을 생성할려면 C를 누르시오.\n클리어 조건 : 코인 10개수집");

                inPut = Convert.ToString(Console.ReadLine());

                //wasd 문자열 입력
                //Console.Clear();

                int coinX = 0;
                int coinY = 0;
                Random coX = new Random();
                Random coY = new Random();
                coinX = coX.Next(1, 10 + 1);
                coinY = coY.Next(1, 10 + 1);


                int checkWallW = 0;
                switch (inPut)
                {
                    
                    case "w":

                        checkWallW = playerY - 1;

                        int w = 0;
                        w = gameBoard[playerY - 1, playerX];

                        if (checkWallW == 0 && playerX == 4)
                        {
                            if (gameBoard[checkWallW, playerX] == -3)
                            {
                                gameBoard[checkWallW, playerX] = -2;
                                gameBoard[9, playerX] = -3;
                                gameBoard[playerY, playerX] = -1;
                                gameBoard[playerY = 8, playerX] = 0;
                            }
                        }
                        else if (checkWallW == 0)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                        }
                        else
                        {
                            gameBoard[playerY, playerX] = -1;
                            gameBoard[playerY - 1, playerX] = 0;
                            playerY--;
                        }

                        
                        if (w == 1)
                        {
                            coinCount++;
                        }

                        break;

                    case "s":
                        checkWallW = playerY + 1;
                        int s = 0;
                        s = gameBoard[playerY + 1, playerX];

                        if (playerX == 4 && checkWallW == 9)
                        {
                            if (gameBoard[checkWallW, playerX] == -3)
                            {
                                gameBoard[checkWallW, playerX] = -2;
                                gameBoard[0, playerX] = -3;
                                gameBoard[playerY, playerX] = -1;
                                gameBoard[playerY = 1, playerX] = 0;
                            }
                        }
                        else if (checkWallW == 9)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                        }
                        else
                        {
                            gameBoard[playerY, playerX] = -1;
                            gameBoard[playerY + 1, playerX] = 0;
                            playerY++;
                        }
                                                
                        if (s == 1)
                        {
                            coinCount++;
                        }
                        break;

                    case "a":

                        checkWallW = playerX - 1;

                        int a = 0;
                        a = gameBoard[playerY, playerX - 1];
                        if (playerY == 4 && checkWallW == 0)
                        {

                            if (gameBoard[playerY, checkWallW] == -3)//플레이어 좌표가 포탈이면
                            {
                                gameBoard[playerY, checkWallW] = -2;//플레이어가 이동했던 곳은 벽이되고
                                gameBoard[playerY, 9] = -3;          //
                                gameBoard[playerY, playerX] = -1;
                                gameBoard[playerY, playerX = 8] = 0;
                            }
                            else
                            {
                                Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            }

                        }
                        else if (checkWallW == 0)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        else
                        {
                            gameBoard[playerY, playerX] = -1;
                            gameBoard[playerY, playerX - 1] = 0;
                            playerX--;
                        }
                        

                        if (a == 1)
                        {
                            coinCount++;
                        }
                        break;


                    case "d":
                        checkWallW = playerX + 1;
                        //if (9 == checkWallW)

                        int d = 0;
                        d = gameBoard[playerY, playerX + 1];
                        if (playerY == 4 && checkWallW == 9)//포탈위치
                        {

                            if (gameBoard[playerY, checkWallW] == -3)
                            {
                                gameBoard[playerY, checkWallW] = -2;
                                gameBoard[playerY, 0] = -3;
                                //반대편 포탈 생성

                                gameBoard[playerY, playerX] = -1;
                                gameBoard[playerY, playerX = 1] = 0;
                            }
                            else
                            {
                                Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");

                            }
                        }
                        else if (checkWallW == 9)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");

                        }
                        else
                        {
                            gameBoard[playerY, playerX] = -1;
                            gameBoard[playerY, playerX + 1] = 0;
                            playerX++;
                        }

                        if (d == 1)
                        {
                            coinCount++;
                        }

                        break;


                    case "C":
                        bool fiveC = false;
                        int whatTheCoin = 0;
                        while (fiveC == false)
                        {
                            
                            coinX = coX.Next(1, 8 + 1);
                            coinY = coY.Next(1, 8 + 1);

                            if (gameBoard[coinY, coinX] == 0)
                            {
                                
                            }
                            //else if (gameBoard[coinY, coinX] == 1)
                            //{
                            //    /*Do Nothing*/
                            //}
                            //else if (gameBoard[coinY, coinX] == 2)
                            //{
                            //    /*Do Nothing*/
                            //}
                            //else if (gameBoard[coinY, coinX] == 3)
                            //{
                            //    /*Do Nothing*/
                            //}
                            //else if (gameBoard[coinY, coinX] == 4)
                            //{
                            //    /*Do Nothing*/
                            //}
                            //else if (gameBoard[coinY, coinX] == 5)
                            //{

                            //    /*Do Nothing*/

                            //}

                            else
                            {
                                gameBoard[coinY, coinX] = 1;
                                whatTheCoin++;
                            }

                            if (whatTheCoin == 5)
                            {
                                fiveC = true;
                            }

                        }
                        break;

                    case "@":
                        isGameOver = true;
                        break;
                }

                if (10 <= coinCount)
                {

                    Console.WriteLine("주머니 가득 코인을 채워서 떠납니다!");
                    isGameOver = true;
                }


            }



        }
    }
}
