using System;

namespace PokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrumpCard trumpCard = new TrumpCard();
            trumpCard.SetupTrumpCards();
<<<<<<< HEAD
            int checkCard = 0;
=======

>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852

            int playerPoint = 10000;

            int playerInput = 0;

<<<<<<< HEAD
            int[] playerDrawCard = new int[5];  //플레이어 교체할 카드 선택을 위한 카드 자리 값 배열
            int[] computerDrawCard = new int[7];
=======


>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852


            while (true)
            {
                Console.WriteLine("※***********************※");
                Console.WriteLine("※     POKER GAME    ※");
                Console.WriteLine("***********************※");
                Console.WriteLine("※Tab To Start※");
                string tabInput = string.Empty;
                tabInput = Console.ReadLine();


                Console.Clear();

                Console.WriteLine("※    컴퓨터의 카드 드로우   ※");


                trumpCard.ShuffleCards();

<<<<<<< HEAD
                trumpCard.DrawFiveCard(0); //컴퓨터 5장
=======
                trumpCard.ComputerCard(0); //컴퓨터 5장
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852

                Console.WriteLine("플레이어의 카드 드로우 차례\n내 카드를 확인 할려면 아무키나 입력하시오.");
                tabInput = Console.ReadLine();


<<<<<<< HEAD
                trumpCard.DrawFiveCard(5);   //플레이어 5장
=======
                trumpCard.ComputerCard(5);   //플레이어 5장
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852



                Console.Write("\n배팅 금을 입력하시오: 패쓰는 0 을 입력하시오.");
<<<<<<< HEAD
                Console.WriteLine("보유 칩 {0}  ", playerPoint);
                playerInput = Convert.ToInt32(Console.ReadLine());
                if (playerInput == 0)
                {
                    Console.WriteLine("배팅을 하지 않아서 다음 게임을 진행합니다.\n 보유 칩 {0}",playerPoint);
=======
                Console.WriteLine("현재 소지 배팅금 {0} ", playerPoint);
                playerInput = Convert.ToInt32(Console.ReadLine());
                if (playerInput == 0)
                {

>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
                }
                else
                {

<<<<<<< HEAD

                    Console.WriteLine("컴퓨터가 두 장을 뽑습니다.\n컴퓨의 패");
                    trumpCard.DrawFiveCard(0);
                    trumpCard.TwoCard(10);

                    Console.WriteLine("카드 교체 하시겠습니까?: \n0은 패스 1은 한장 2는 두장교체");
                    int.TryParse(Console.ReadLine(), out playerInput);

                    
                    bool isTradeCard = false;

                    trumpCard.DrawFiveCard(5);
                    for (int t = 0; t < playerInput; t++)
                    {

                        Console.WriteLine("플레이어가 교체할 카드를 뽑습니다.");
                        trumpCard.TwoCard(13);                        
                                             
                    }
                    trumpCard.FiveCardArray(playerDrawCard[0], playerDrawCard[1], playerDrawCard[2], 
                                         playerDrawCard[3], playerDrawCard[4]);


                    int checkTwoTrade = 0;
                    while (isTradeCard == false) 
                    {
                        int tradeCard = 0;
                        Console.WriteLine("교체할 카드 번호를 입력하시오.: \n패스는 0 나머지 자리는 1~5를 입력하시오 ");
                        int.TryParse(Console.ReadLine(), out tradeCard);

                        if (checkTwoTrade == 2) { break; }
                        switch (tradeCard) 
                        {
                            case 0:
                                Console.WriteLine("[딜러] 플레이어는 카드 교체를 하지 않았습니다.");
                                isTradeCard = true;
                                break;
                            case 1:
                                playerDrawCard[tradeCard - 1] = trumpCard.OneDarwCard(checkTwoTrade);
                                checkTwoTrade++;
                                checkCard++;
                                break;
                            case 2:
                                playerDrawCard[tradeCard - 1] = trumpCard.OneDarwCard(checkTwoTrade);
                                checkTwoTrade++;
                                checkCard++;
                                break;
                            case 3:
                                playerDrawCard[tradeCard - 1] = trumpCard.OneDarwCard(checkTwoTrade);
                                checkTwoTrade++;
                                checkCard++;
                                break;
                            case 4:
                                playerDrawCard[tradeCard - 1] = trumpCard.OneDarwCard(checkTwoTrade);
                                checkTwoTrade++;
                                checkCard++;
                                break;
                            default:
                                Console.WriteLine("교체할 카드 번호를 다시 입력하시오. ");
                                Console.ReadLine();
                                break;

                        }
                    }

                    /*
=======
                    Console.WriteLine("컴퓨터가 두 장을 뽑습니다.");
                    trumpCard.TwoCard(10);

                    Console.WriteLine("카드 두장을 교체 하시겠습니까?: ");
                    int.TryParse(Console.ReadLine(), out playerInput);


>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
                    //int usercard = trumpCard.ComputerCard(2);
                    //if ((comOneCard < usercard && usercard < userCard) || (userCard < usercard && usercard < comOneCard))
                    //{
                    //    Console.WriteLine("배팅에서 승리 하셨습니다.");
                    //    Console.WriteLine("배팅 승리 수당 {0} ", playerInput * 2);
                    //    playerPoint += playerInput * 2;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("배팅에서 패배 하셨습니다.");
                    //    Console.WriteLine("잃은 수당 {0} ", playerInput);
                    //    Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");

                    //    playerPoint -= playerInput;

<<<<<<< HEAD
                    //}*/
=======
                    //}
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852

                }
                if (playerPoint >= 100000)
                {
<<<<<<< HEAD

                    Console.WriteLine("\tYOU WIN!");

=======
                   
                    Console.WriteLine("\tYOU WIN!");
                   
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
                    break;
                }
                else if (playerPoint == 0)
                {
<<<<<<< HEAD

                    Console.WriteLine("최소 배팅금이 없습니다. 패배!");

=======
                    
                    Console.WriteLine("최소 배팅금이 없습니다. 패배!");
                    
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
                    break;
                }

            }
        }



    }
}

