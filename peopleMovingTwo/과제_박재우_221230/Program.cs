using System;
using System.Threading.Tasks;

namespace peopleMovingTwo
{
    internal class Program
    {
        public static void PrintColorText(string text_, ConsoleColor color_)
        {
            Console.ForegroundColor = color_;
            Task.Delay(200).Wait();
            Console.Write("{0}", text_);
            Console.ForegroundColor = ConsoleColor.White;
        }       //텍스트 컬러 변경 툴. 딜레이 ++
        public static void ColorfullString()
        {
            PrintColorText("\tC", ConsoleColor.Red);
            PrintColorText("o", ConsoleColor.Green);
            PrintColorText("i", ConsoleColor.Yellow);
            PrintColorText("n ", ConsoleColor.Blue);
            PrintColorText("A", ConsoleColor.Magenta);
            PrintColorText("n", ConsoleColor.Cyan);
            PrintColorText("d ", ConsoleColor.DarkRed);
            PrintColorText("M", ConsoleColor.Green);
            PrintColorText("o", ConsoleColor.DarkRed);
            PrintColorText("v", ConsoleColor.DarkGray);
            PrintColorText("i", ConsoleColor.Yellow);
            PrintColorText("n", ConsoleColor.DarkGray);
            PrintColorText("g\n", ConsoleColor.DarkBlue);

            /*
            Console.ForegroundColor = ConsoleColor.Red;
            Task.Delay(200).Wait();
            Console.Write("\tC");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Task.Delay(200).Wait();
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Task.Delay(200).Wait();
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Task.Delay(200).Wait();
            Console.Write("n ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Task.Delay(200).Wait();
            Console.Write("A");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Task.Delay(200).Wait();
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Task.Delay(200).Wait();
            Console.Write("d ");
            Console.ForegroundColor = ConsoleColor.White;


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Task.Delay(200).Wait();
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Task.Delay(200).Wait();
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Task.Delay(200).Wait();
            Console.Write("v");
            Console.ForegroundColor = ConsoleColor.White;

            Task.Delay(200).Wait();
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Task.Delay(200).Wait();
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Task.Delay(200).Wait();
            Console.WriteLine("g");
            Console.ForegroundColor = ConsoleColor.White;
            */


        } //글자 색입혀 보기.

        public static void SeeColorText(string text_, ConsoleColor color_)
        {
            Console.ForegroundColor = color_;            
            Console.Write("{0}", text_);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ColorFullString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.Write("\tC");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.Write("n ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.Write("A");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.Write("d ");
            Console.ForegroundColor = ConsoleColor.White;


            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.Write("v");
            Console.ForegroundColor = ConsoleColor.White;

            
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Console.WriteLine("g");
            Console.ForegroundColor = ConsoleColor.White;


        }

        static void Main(string[] args)
        {
            /**
             * 과제
             * 기한은 27일 오전까지
             * 
             * 10x10 보드(사이즈 줘도 ok)
             * □ □ □ □ □ □ □ □ □ □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □  .  .  . .  . . . .  □
             * □ □ □ □ □ □ □ □ □ □
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
             * 10x10보드 고정
             * 
             * 보드판 *로 채우기
             * 사람은 9x9만 이동가능
             * 사람은 옷
             * w, a,s,d, 입력은 좌표값 +-switch 
             * 
             * C를 입력받으면 9x9칸 안중 플레이어가 없는 칸에 $가 생김
             * 
             * $랑 플레이어랑 겹치는 순간 $는 바뀌게 되고 그것이 습득으로 됨
             * 
             * 습득된 숫자만큼 출력
             */


            //고정된 보드 5x5
            const int BOARD_SIZE_X = 10;
            const int BOARD_SIZE_Y = 10;

            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];         //게임 보드 배열 사이즈

            int coinCount = 0;

            // 0이나 4값을 받으면 안되게?

            //보
            for (int y = 0; y < BOARD_SIZE_Y; y++)           //y축 보드판을 만드는동안
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)       //x축 보드판도 같이 도는데
                {
                    gameBoard[y, x] = -1; //점
                    if (y == 0 || y == 9 || x == 0 || x == 9)
                    {
                        gameBoard[y, x] = -2;
                        //가변쪽이 □
                        //Console.WriteLine(gameBoard[y, x]);
                    }
                    //가변쪽이 아니면 *별

                }
            }
            //loop 
            int playerX = 0;        //플레이어X축 정수
            int playerY = 0;        //플레이어Y축 정수
            Random ran = new Random();

            playerX = ran.Next(4, 5 + 1);
            playerY = ran.Next(4, 5 + 1);

            gameBoard[playerY, playerX] = 0;    //게임판 배열에 [.] 중앙 값을 플레이어에게 넣고 0값은 옷을 넣기 위해 선언.

            bool isVictory = false;
            bool isGameOver = false;

            bool onestop = false;
            //시작
            while (isGameOver == false)
            {
                Console.Clear();
                    Console.WriteLine("===============================");

                while (onestop == true) 
                {
                    ColorFullString();
                    break;
                }
                while (onestop == false)
                {

                    ColorfullString();
                    onestop= true;
                    break;
                }
                Console.WriteLine("===============================");
                Console.Write("      현재 먹은 코인 :");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" {0} 개", coinCount);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===============================\n\n");

                //{현재 보드 상태를 플레이 시점으로 보여준다.
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case -2:
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Write("■".PadRight(2, ' '));
                                Console.ForegroundColor = ConsoleColor.White;
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

                            case 2:
                                Console.Write("△".PadRight(2, ' '));
                                break;
                            case 3:
                                Console.Write("▽".PadRight(2, ' '));
                                break;
                            case 4:
                                Console.Write("◁".PadRight(2, ' '));
                                break;
                            case 5:
                                Console.Write("▷".PadRight(2, ' '));
                                break;

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


                        if (checkWallW == 0)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        int w = 0;
                        w = gameBoard[playerY - 1, playerX];
                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY - 1, playerX] = 2;
                        playerY--;
                        Console.Write("△".PadRight(2, ' '));

                        if (w == 1)
                        {
                            coinCount++;
                        }

                        break;

                    case "s":
                        checkWallW = playerY + 1;
                        if (checkWallW == 9)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        int s = 0;
                        s = gameBoard[playerY + 1, playerX];

                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY + 1, playerX] = 3;
                        playerY++;

                        Console.Write("▽".PadRight(2, ' '));
                        if (s == 1)
                        {
                            coinCount++;
                        }


                        break;

                    case "a":
                        Console.Write("◁".PadRight(2, ' '));
                        checkWallW = playerX - 1;
                        if (checkWallW == 0)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        int a = 0;
                        a = gameBoard[playerY, playerX - 1];

                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY, playerX - 1] = 4;
                        playerX--;

                        Console.Write("◁".PadRight(2, ' '));

                        if (a == 1)
                        {
                            coinCount++;
                        }
                        break;

                    case "d":

                        checkWallW = playerX + 1;
                        if (checkWallW == 9)
                        {
                            Console.WriteLine("벽에 막혔습니다. 다시 입력하세요");
                            break;
                        }
                        int d = 0;
                        d = gameBoard[playerY, playerX + 1];

                        gameBoard[playerY, playerX] = -1;
                        gameBoard[playerY, playerX + 1] = 5;
                        playerX++;

                        Console.Write("▷".PadRight(2, ' '));
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
                            coinY = coY.Next(1, 8 + 1 );

                            if (gameBoard[coinY, coinX] == 0)
                            {
                                /*Do Nothing*/
                            }
                            else if (gameBoard[coinY, coinX] == 1)
                            {
                                /*Do Nothing*/
                            }
                            else if (gameBoard[coinY, coinX] == 2)
                            {
                                /*Do Nothing*/
                            }
                            else if (gameBoard[coinY, coinX] == 3)
                            {
                                /*Do Nothing*/
                            }
                            else if (gameBoard[coinY, coinX] == 4)
                            {
                                /*Do Nothing*/
                            }
                            else if (gameBoard[coinY, coinX] == 5)
                            {
                                /*Do Nothing*/

                            }
                            
                            else
                            {
                                gameBoard[coinY, coinX] = 1;
                                whatTheCoin++;
                            }

                            if (whatTheCoin == 5) 
                            {
                                fiveC= true;
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







