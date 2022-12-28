using System;
using System.Xml.Serialization;

namespace Slidingpuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool flag;
            //int counter = 0;
            //flag = true;


            //while (flag)    //조건이 참이고 멈추게해주지 않으면 무한히 돈다.
            //{
            //    counter = counter+1;
            //    Console.WriteLine(counter);
            //    if (counter == 10) 
            //    {
            //        flag = false;
            //    }

            //}
            //int counter = 0;

            //while (true) 
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;

            //    if (counter == 10) 
            //    {
            //        break;
            //    }
            //}
            //break가 어딜깨는지 모를때 한번 마우스 클릭해보기
            //break걸리면 완전 나가버림.
            
            //컨티뉴

            //int counter = 0;

            //while (counter<13)
            //{
            //    counter++;
            //    if (counter % 3 == 0) 
            //    {
            //        continue;
            //        //continue를 만나면 다시 가까운while로 돌아가서 실행.
            //    }
            //    Console.WriteLine(counter);
            //    Console.WriteLine("으앙 전 짝수일때 씹혀요");

            //}

            /**
             * 슬라이딩 퍼즐 프로그램 작성하기
             */
            const int BoardX = 3;
            const int BoardY = 3;


            int[,] gameBoard = new int[BoardY, BoardX];
            //3x3 배열판 기본 틀



            Random ranNum = new Random();
            //0~8까지 난수값을 저장해 놓을 변수값
            int ranArrayNum = 0;

            //3x3배열판에 1~9숫자를 담아서
            int[] numBer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int notNum = 0;

            int playerPlaceX = 0;
            int playerPlaceY = 0;

            int tryMoving = 0;
            //보드판 크기
            for (int y = 0; y < BoardY; y++)
            {
                for (int x = 0; x < BoardX; x++)
                {
                    ranArrayNum = ranNum.Next(0, 8 + 1); //

                    notNum = numBer[ranArrayNum];

                    //배열에서 담긴 값은 0으로 초기화.
                    if (notNum == 0) //예외처리 중복 쓴 숫자는 뺴게한다.
                    {
                        while (notNum == 0) //
                        {
                            ranArrayNum = ranNum.Next(0, 8 + 1);
                            //numBer 배열값이 0인지를 확인하는 변수선언
                            notNum = numBer[ranArrayNum];

                            if (notNum == 0) {/**/ }
                            else if (notNum == 9)
                            {
                                gameBoard[y, x] = 9;
                                numBer[ranArrayNum] = 0;
                                playerPlaceX = x;
                                playerPlaceY = y;
                                break;
                            }
                            else
                            {
                                gameBoard[y, x] = notNum;
                                numBer[ranArrayNum] = 0;    //난수값으로 뽑은 배열 위치값을 0으로 선언한다. 
                                break;
                            }

                        }


                    }
                    else if (notNum == 9)
                    {
                        gameBoard[y, x] = 9;
                        numBer[ranArrayNum] = 0;
                        playerPlaceX = x;
                        playerPlaceY = y;
                    }
                    else
                    {
                        gameBoard[y, x] = notNum;
                        numBer[ranArrayNum] = 0;    //난수값으로 뽑은 배열 위치값을 0으로 선언한다. 

                    }


                }
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            string movingString = string.Empty;
            Console.WriteLine("이동 횟수 {0} ", tryMoving);

            bool isGameOver = false;

            while (isGameOver == false)
            {
                ClearLine(23);
                Console.WriteLine();
                if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 3 &&
                    gameBoard[1, 0] == 4 && gameBoard[1, 1] == 5 && gameBoard[1, 2] == 6 &&
                    gameBoard[2, 0] == 7 && gameBoard[2, 1] == 8 && gameBoard[2, 2] == 9)
                {
                    isGameOver = true;

                    Console.WriteLine("========================================================");
                    Console.WriteLine("퍼즐 완성!");
                    Console.WriteLine();
                    Console.WriteLine("총 이동 횟수 {0} ", tryMoving);


                    break;
                }
                Console.WriteLine("========================================================");
                Console.WriteLine("                     슬라이딩 퍼즐 게임                    ");
                Console.WriteLine("========================================================");


                //보드상태를 플레이어한테 보여줌
                for (int y = 0; y < BoardY; y++)
                {
                    for (int x = 0; x < BoardX; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case 9:
                                Console.Write("     x \t\t".PadLeft(10, ' '));
                                break;
                            default:
                                Console.Write("     {0} \t\t".PadLeft(12, ' '), gameBoard[y, x]);
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("========================================================");
                string inPut = string.Empty;


                Console.WriteLine("w,a,s,d,를 입력해 퍼즐을 완성하시오.: ");
                Console.WriteLine("탈출버튼 = $ ");
                inPut = Convert.ToString(Console.ReadLine());
                //문자열 wasd를 입력받기위한 것.


                switch (inPut)  //유저인풋을 받고 하나하나 바뀌는 값을 담기위해 씀
                {
                    case "w":

                        int moving1 = 0;
                        moving1 = playerPlaceY - 1;
                        if (moving1 < 0)
                        {
                            break;
                        }
                        gameBoard[playerPlaceY, playerPlaceX] = gameBoard[playerPlaceY - 1, playerPlaceX];
                        gameBoard[playerPlaceY - 1, playerPlaceX] = 9;
                        playerPlaceY--;
                        tryMoving++;

                        break;
                    case "s":
                        int moving2 = 0;
                        moving2 = playerPlaceY + 1;
                        if (moving2 >= 3)
                        {
                            break;
                        }
                        gameBoard[playerPlaceY, playerPlaceX] = gameBoard[playerPlaceY + 1, playerPlaceX];
                        gameBoard[playerPlaceY + 1, playerPlaceX] = 9;//w받았을때 게임판 y,x좌표를 9로 바꿔서 x가 위로 올라가게
                        playerPlaceY++;
                        tryMoving++;
                        break;
                    case "a":
                        int moving3 = 0;
                        moving3 = playerPlaceX - 1;
                        if (moving3 < 0)
                        {
                            break;
                        }
                        gameBoard[playerPlaceY, playerPlaceX] = gameBoard[playerPlaceY, playerPlaceX - 1];
                        gameBoard[playerPlaceY, playerPlaceX - 1] = 9;     //w받았을때 게임판 y,x좌표를 9로 바꿔서 x가 위로 올라가게
                        playerPlaceX--;
                        tryMoving++;
                        break;
                    case "d":
                        int moving4 = 0;
                        moving4 = playerPlaceX + 1;
                        if (moving4 >= 3)
                        {
                            break;
                        }
                        gameBoard[playerPlaceY, playerPlaceX] = gameBoard[playerPlaceY, playerPlaceX + 1];
                        gameBoard[playerPlaceY, playerPlaceX + 1] = 9;    //w받았을때 게임판 y,x좌표를 9로 바꿔서 x가 위로 올라가게
                        playerPlaceX++;
                        tryMoving++;
                        break;
                    case "$":
                        isGameOver = true;

                        Console.WriteLine("========================================================");
                        Console.WriteLine("퍼즐 완성!");
                        Console.WriteLine();
                        Console.WriteLine("총 이동 횟수 {0} ", tryMoving);


                        break;
                }

            }




        }

        static void ClearLine(int lineNumber)
        {
            for (int i = 0; i < lineNumber; i++)
            {
                Console.WriteLine();
            }
        }


        //초기식; 조건식; 증감식


        static void BoGang() 
        {
            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1;  j < 10; j++) 
                {
                    Console.WriteLine(i + "\t곱하기\t" + j + "\t는\t"  + i * j);
                }
            }
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine(i + "는 0입니다.");
            //    }
            //    else if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + "는 2의 배수");

            //    }
            //    else 
            //    {
            //        Console.WriteLine(i + "는 3의 배수");
            //    }
            //}

            //반복문 while

        }

    }
}