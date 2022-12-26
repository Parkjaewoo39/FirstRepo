using System;

namespace peopleshift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 과제
             * 기한은 27일 오전까지
             * 
             * 5x5 보드(사이즈 줘도 ok)
             * □ □ □ □ □
             * □.  .  .  □
             * □.  .  .  □
             * □.  .  .  □
             * □ □ □ □ □
             * 
             * □는 벽
             * .(닷)은 빈칸을 의미
             * w, a, s, d 입력 받아서
             * 빈 곳중에 아무곳이나 사람(이모티콘) 또는 옷)을 초기화 해서
             * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성.
             * - 사람은 빈 곳을 다닐 수 있음.
             * - 사람은 벽을 넘어다닐 수 없음.
             */

            /**
             * 풀이전 생각
             * 5x5보드 고정
             * 
             * 보드판 *로 채우기
             * 사람은 3x3만 이동가능
             * 사람은 옷
             * w, a,s,d, 입력은 좌표값 +-switch 
             * 
             * 
             */


            //고정된 보드 5x5
            const int BOARD_SIZE_X = 5;
            const int BOARD_SIZE_Y = 5;


            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];         //게임 보드 배열 사이즈
          
            // 0이나 4값을 받으면 안되게?

            //보
            for (int y = 0; y < BOARD_SIZE_Y; y++)           //y축 보드판을 만드는동안
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)       //x축 보드판도 같이 도는데
                {
                    gameBoard[y, x] = -1; //점
                    if (y == 0 || y == 4 || x == 0 || x == 4)
                    {
                        gameBoard[y, x] = -2;
                        //가변쪽이 □
                    }
                    //가변쪽이 아니면 *별

                }
            }
            //loop 


            int playerX = 2;        //플레이어X축 정수
            int playerY = 2;        //플레이어Y축 정수

            gameBoard[playerX, playerY] = 0;    //게임판 배열에 [2.2] 중앙 값을 플레이어에게 넣고 0값은 옷을 넣기 위해 선언.

            bool isGameOver = false;
            //시작
            while (isGameOver == false)
            {
                
                //{현재 보드 상태를 플레이 시점으로 보여준다.
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case -2:
                                Console.Write("□".PadRight(2, ' '));
                                break;
                            case -1:
                                Console.Write("*".PadRight(3, ' '));
                                break;
                            case 0:
                                Console.Write("옷".PadRight(2, ' '));
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                bool peopleShiftValue = false;
                //}현재 보드 상태를 플레이 시점으로 보여준다. 끝.
                string inPut = string.Empty;

                Console.Write("wasd를 입력해 사람을 움직이시오.: ");
                inPut = Convert.ToString(Console.ReadLine());

                //wasd 문자열 입력

                int checkWallW = 0;
                switch (inPut)
                {
                    

                    case "w":
                        
                        checkWallW = playerY- 1;
                        if (checkWallW == 0) 
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY - 1, playerX] = 0;
                        playerY--;                            
                        
                        break;
                    case "s":
                        checkWallW = playerY +1;
                        if (checkWallW == 4)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }

                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY + 1, playerX] = 0;
                        playerY++;

                        break;
                    case "a":
                        checkWallW = playerX - 1;
                        if (checkWallW == 0)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY, playerX-1] = 0;
                        playerX--;
                        break;
                    case "d":
                        checkWallW = playerX + 1;
                        if (checkWallW == 4)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY, playerX+1] = 0;
                        playerX++;
                        break;
                    case "$":
                        isGameOver = true;
                        break;
                }


            }





        }
    }
}