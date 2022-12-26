using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    public class TicTaToe
    {

        /**
         * Tic-Tac_Toe 게임
         * 컴퓨터와 사람이 번갈아 가면서 o, x를 둔다.
         * 보드 크기는 3 x 3
         * 컴퓨터의 룰은 간단하게
         *  1. 중앙이 비었으면 중앙을 선점 하려고 함.
         *  2. 이후에 빈자리 아무곳이나 적당히 찾아서 둔다.
         */

        enum TicTacToePlayerType                        //enum???
        {
            NONE = 0, PLAYER, COMPUTER                  // None???? None 선언과 동시에 초기화?
        }
        public static void Main()
        {
            int[,] gameBoard = new int[3, 3];                   //게임판을 3x3 정수형 배열로 받기 위해 초기화
            int playerX, playerY = 0;                           //플레이어 좌표로 입력을 받아서 판별하기 위해 int형 두가지 선언과 초기화

            bool isValidLocation = false;                       //
            bool isPlayerTurn = false;
            bool isGameover = false;

            string playerIcon = string.Empty; //
            string playerType = string.Empty;

            while (isGameover == false)                     //게임오버가 아닐 동안 루프가 돈다 
            {
                //플레이어 턴 진행
                isPlayerTurn = true;
                playerType = "[플레이어]";

                //{플레이어에게서 좌표를 입력 받는다.
                playerX = 0;
                playerY = 0;

                isValidLocation = false;                    //한번더 명시적으로 false 선언

                while (true)                                //while문은 조건을 걸기 보단 true로 계속 돌리고 탈출 조건을 걸어서 끝내는게 편하다
                {
                    if (isValidLocation == true) { break; }
                    //루프 탈출 조건. 제대로 된 입력을 받을 경우 탈출.

                    Console.Write("[플레이어] (x) 좌표: ");
                    int.TryParse(Console.ReadLine(), out playerX);
                    Console.Write("[플레이어] (y) 좌표: ");
                    int.TryParse(Console.ReadLine(), out playerY);
                    //플레이어 턴/ 좌표 입력 받음

                    if (gameBoard[playerY, playerX].Equals((int)TicTacToePlayerType.NONE))
                    {
                        gameBoard[playerY, playerX] = (int)(TicTacToePlayerType.PLAYER);
                        isValidLocation = true;
                        //if:보드가 빈 곳인 경우
                    }
                    else
                    {
                        Console.WriteLine("[Syetem] 해당 좌표는 비어있지 않습니다. / 다른 좌표를 입력하세요");
                        isValidLocation = false;
                        //else 보드가 빈 곳이 아닌 경우
                    }
                }       //loop : 플레이어의 좌표 입력을 받는 루프

                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    Console.WriteLine("---|---|---");
                    for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                    {
                        switch (gameBoard[y, x])                        //switch case: break; 형식 잊지말기.
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        }       //switch
                        Console.Write(" {0} ", playerIcon);

                        //Print Separator
                        if (x == gameBoard.GetUpperBound(1)) {/*Do nothing*/}
                        else { Console.Write("|"); }
                        //loop: 한줄에서 출력할 내용을 연산한다.
                    }
                    Console.WriteLine();
                    //loop
                }
                Console.WriteLine("---|---|---");
                //플레이어 턴 진행을 보드에 출력한다.

                //{게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameover = false;
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameover = true;
                    }
                    else { continue; }
                }//loop 가로 방향으로 검사하는 루프

                for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                {
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameover = true;
                    }
                    else { continue; }
                }//세로방향으로 검사하는 루프

                //대각선 방향으로 검사

                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameover = true;
                }

                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameover = true;
                }

                //}게임이 끝났는지 보드 검사

                // 게임이 끝난 경우 루프를 탈출한다.
                if (isGameover) { break; }

                //게임이 끝나지 않은 경우 턴을 교체한다

                isPlayerTurn = false;
                playerType = "[컴퓨터]";
                bool isComputerDoing = false;

                Console.WriteLine("{0}의 턴", playerType);
                //컴퓨터의 간단한 룰
                // {1. 중앙이 비어 있으면 선점
                if (isComputerDoing == false)
                {
                    if (gameBoard[1, 1].Equals((int)TicTacToePlayerType.NONE))
                    {
                        gameBoard[1, 1] = (int)TicTacToePlayerType.COMPUTER;
                        isComputerDoing = true;
                        //if: 중앙이 비어 있는 경우
                    }
                    else {/*DO nothing*/ }
                    //if : 컴퓨터가 아직 아무것도 하지 않은 경우
                }
                else {/*Do nothing*/ }
                //} 1. 중앙이 비어 있으면 선점

                //{ 2. 적당히 빈 자리 찾아서 착수
                if (isComputerDoing == false)
                {
                    for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                    {
                        for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                        {
                            if (isComputerDoing == false &&
                                gameBoard[y, x].Equals((int)TicTacToePlayerType.NONE))
                            {
                                gameBoard[y, x] = (int)TicTacToePlayerType.COMPUTER;
                                isComputerDoing = true;
                                break;
                            }      //if : 서치한 자리가 비어있는 경우
                            else { continue; }
                        }   //loop: Search horizontal
                    }     //loop: Search vertical
                }   //if: 컴퓨터가 아직 아무것도 하지 않은 경우
                else {/*Do nothing*/ }
                //}2. 적당히 빈 자리 찾아서 착수

                //{ 컴퓨터의 턴 진행을 보드에 출력한다
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    Console.WriteLine("---|---|---");
                    for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "0";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        }       //switch
                        Console.Write(" {0} ", playerIcon);

                        //Pringt Separator
                        if (x == gameBoard.GetUpperBound(1)) {/*Do nothing*/ }
                        else { Console.Write("|"); }
                        //loop: 한 줄에서 출력할 내용을 연산한다.
                    }
                    Console.WriteLine();
                }   //loop
                Console.WriteLine("---|---|---");
                //}컴퓨터의 턴 진행을 보드에 출력한다.

                //{게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameover = false;         //게임이 어떻든 초기화

                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameover = true;
                    }
                    else { continue; }
                }   //loop: 가로 방향으로 검사

                for (int x = 0; x <= gameBoard.GetUpperBound(0); x++)
                {
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameover = true;
                    }
                    else { continue; }
                }   //loop: 세로 방향으로 검사

                //대각선 방향으로 검사
                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameover = true;
                }
                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameover = true;
                }  //}게임이 끝났는지 보드 검사
                   //loop: 틱 택 토 게임 종료
                
            }
            Console.WriteLine("{0}의 승리", playerType);

        }
    }
}

