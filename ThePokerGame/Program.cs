using PokerGame;

namespace ThePokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrumpCard trumpCard = new TrumpCard();
            trumpCard.SetupTrumpCards();

            int checkCard = 0;


            int drawCardCount = 0;
            int playerPoint = 10000;        //플레이어 포인트

            //입력값

            int[] playerTradeArray = new int[5];        //내 자리 교체를 위한 자리값을 담기 위한 배열
            int[] computerTradeArray = new int[7];



            int[] playerDrawCard = new int[5];  //플레이어 교체할 카드 선택을 위한 카드 자리 값 배열
            int[] computerDrawCard = new int[7];



            int playerInput = 0;
            bool isGameOver = false;
            //!게임 시작
            while (isGameOver == false)
            {
                Console.WriteLine("※***********************※");
                Console.WriteLine("※     POKER GAME    ※");
                Console.WriteLine("***********************※");
                Console.WriteLine("※Tab To Start※");
                string tabInput = string.Empty;
                tabInput = Console.ReadLine();

                trumpCard.SetupTrumpCards();
                trumpCard.ShuffleCards();

                Console.WriteLine("※    상대의 카드 드로우   ※");
                Console.WriteLine("");
                trumpCard.DrawFiveCard(drawCardCount); //컴퓨터 5장 
                Console.WriteLine("");
                for (int i = 0; i < 5; i++)
                {
                    computerTradeArray[i] = trumpCard.DrawOneCardValue(drawCardCount);
                    drawCardCount++;
                }

                Console.WriteLine("플레이어의 카드 드로우 차례\n내 카드를 확인 할려면 아무키나 입력하시오.");
                tabInput = Console.ReadLine();

                Console.WriteLine("※   플레이어의 카드 드로우   ※");
                Console.WriteLine("");
                trumpCard.DrawFiveCard(drawCardCount);   //플레이어 5장
                Console.WriteLine("");
                for (int i = 0; i < 5; i++)
                {
                    playerTradeArray[i] = trumpCard.DrawOneCardValue(drawCardCount);
                    drawCardCount++;
                }//drawCardCount 0~9

                Console.Write("배팅 금을 입력하시오: \n패스는 0 을 입력하시오.");
                Console.WriteLine("보유 칩 {0} ", playerPoint);
                playerInput = Convert.ToInt32(Console.ReadLine());


                if (playerInput == 0)
                {
                    Console.WriteLine("배팅을 하지 않아서 다음 게임을 진행합니다.\n 보유 칩 {0}", playerPoint);
                    Console.WriteLine("현재 소지 배팅금 {0} ", playerPoint);
                }

                else if (0 < playerInput)
                {


                    trumpCard.DrawTwoCard(drawCardCount);
                    Console.WriteLine("딜러가 두 장을 뽑습니다.");
                    for (int i = 0; i < 2; i++)
                    {
                        computerTradeArray[i] = trumpCard.DrawOneCardValue(drawCardCount);
                        drawCardCount++;
                    }

                    int loopTwoCheck = 0;
                    Console.WriteLine("카드 교체를 하시겠습니까?: \n패스는 0 교체는1");
                    int.TryParse(Console.ReadLine(), out playerInput);

                    if (playerInput == 0)
                    {
                        /*Do Pass*/
                    }
                    else if (playerInput == 1)
                    {
                        while (true)
                        {
                            trumpCard.PlayerFiveCardValue(playerTradeArray[0], playerTradeArray[1],
                                playerTradeArray[2], playerTradeArray[3], playerTradeArray[4]);

                            if (loopTwoCheck == 2)
                            {
                                break;
                            }

                            Console.WriteLine("교체할 카드 한장을 뽑습니다.");

                            trumpCard.DrawOneCard(drawCardCount);

                            Console.WriteLine("교체할 카드를 선택하시오.: \n패스는0 교체는1~5");
                            int.TryParse(Console.ReadLine(), out playerInput);

                            Console.WriteLine("※    상대의 카드 패   ※");
                            Console.WriteLine("");
                            trumpCard.DrawFiveCard(drawCardCount - 10);
                            Console.WriteLine("");

                            trumpCard.DrawTwoCard(drawCardCount);
                            switch (playerInput)
                            {
                                case 0:
                                    loopTwoCheck = 2;
                                    break;

                                case 1:
                                    playerTradeArray[0] = trumpCard.DrawOneCardValue(drawCardCount);
                                    loopTwoCheck++;
                                    break;

                                case 2:
                                    playerTradeArray[1] = trumpCard.DrawOneCardValue(drawCardCount);
                                    loopTwoCheck++;
                                    break;

                                case 3:
                                    playerTradeArray[2] = trumpCard.DrawOneCardValue(drawCardCount);
                                    loopTwoCheck++;
                                    break;

                                case 4:
                                    playerTradeArray[3] = trumpCard.DrawOneCardValue(drawCardCount);
                                    loopTwoCheck++;
                                    break;

                                case 5:
                                    playerTradeArray[4] = trumpCard.DrawOneCardValue(drawCardCount);
                                    loopTwoCheck++;
                                    break;

                                default:
                                    Console.WriteLine("정확한 숫자를 입력하시오. ");
                                    break;
                            }
                            drawCardCount++;
                        }
                    }   //else if
                    else
                    {
                        Console.WriteLine("제대로 된 숫자를 입력하시오.: ");
                    }


                }
                else
                { }
                Array.Sort(playerTradeArray);//값 담은 배열을 순서대로 정렬
                Array.Sort(computerTradeArray);//값 담은 배열을 순서대로 정렬                              

                //!족보 시작

                //!플레이어 족보 비교
                int[] playerPedigree = new int[14];

                int cardCounter = 0;
                int playerTwo = 0;

                int nonPair = 0;       //노페어

                int oneCard = 0;        //원페어
                int twoCard = 0;        //투페어
                int threeCard = 0;      //트리플

                int straightCard = 0;       //스트레이트
                int backStraightCard = 0;       //백스트레이트
                int mountainCard = 0;        //마운틴
                int flushCard = 0;      //플러쉬


                int fullHouse = 0;
                int fourCard = 0;

                //나누기 값이 몇개냐 

                //!플레이어 교환카드 값 담은 후 비교를위한
                for (int i = 0; i < playerTradeArray.Length; i++)
                {
                    if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 1)
                    {
                        playerPedigree[0]++;
                        playerPedigree[13]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 2)
                    {
                        playerPedigree[1]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 3)
                    {
                        playerPedigree[2]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 4)
                    {
                        playerPedigree[3]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 5)
                    {
                        playerPedigree[4]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 6)
                    {
                        playerPedigree[5]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 7)
                    {
                        playerPedigree[6]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 8)
                    {
                        playerPedigree[7]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 9)
                    {
                        playerPedigree[8]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 10)
                    {
                        playerPedigree[9]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 11)
                    {
                        playerPedigree[10]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 12)
                    {
                        playerPedigree[11]++;
                    }
                    else if ((int)Math.Ceiling(playerTradeArray[i] % 13.1) == 13)
                    {
                        playerPedigree[12]++;
                    }
                    else {/*Do Nothing*/}
                }
                int twoPairCount = 0;//

                for (int i = 0; i < playerPedigree.Length; i++) //13번 돌아서 비교
                {
                    if (0 < playerPedigree[i])
                    {
                        nonPair = i + 1;
                    }
                    else { /* Do Nothing */ }

                    if (i == 0 || i == 13)
                    {
                        if (i == 0)
                        { /* Do Nothing */ }

                        else
                        { 

                            if (playerPedigree[13] == 4)
                            {
                                fourCard = 14;

                            }
                            else if (playerPedigree[13] == 3)
                            {

                                threeCard = 14;
                            }
                            else if (playerPedigree[13] == 2)
                            {
                                oneCard = 14;

                                twoPairCount++;


                                if (2 <= twoPairCount)
                                {
                                    twoCard = 14;
                                }

                            }
                            else
                            {

                            }

                        }
                    }
                    else
                    {


                        if (playerPedigree[i] == 4)//포카드 
                        {
                            fourCard = i + 1;
                        }
                        else if (playerPedigree[i] == 3)//트리플
                        {
                            threeCard = i + 1;
                        }
                        else if (playerPedigree[i] == 2) //원페어
                        {
                            oneCard = i + 1;
                            twoPairCount++;
                            if (2 <= twoPairCount)
                            {
                                twoCard = i + 1;  //투페어
                            }
                        }
                        else { /*Do Nothing*/}
                    }
                }
                int[] flushCheck = new int[4];

                //플러쉬
                for (int i = 0; i < playerTradeArray.Length; i++)
                {
                    if (0 < playerTradeArray[i] && playerTradeArray[i] <= 13)
                    {
                        flushCheck[0]++;
                    }
                    else if (13 < playerTradeArray[i] && playerTradeArray[i] <= 26)
                    {
                        flushCheck[1]++;
                    }
                    else if (26 < playerTradeArray[i] && playerTradeArray[i] <= 39)
                    {
                        flushCheck[2]++;
                    }
                    else if (39 < playerTradeArray[i] && playerTradeArray[i] <= 52)
                    {
                        flushCheck[3]++;
                    }
                }   //플러쉬

                int straightCount = 0;
                //스트레이트
                for (int i = 0; i < playerPedigree.Length; i++)
                {
                    if (0 == playerPedigree[i])
                    {

                        straightCount = 0;

                    }
                    else
                    {
                        straightCount++;
                    }

                    if (straightCount == 5)
                    {
                        straightCard = i + 1;
                    }
                    else {/*Do Nothing*/ }
                }   //스트레이트 조건


                //!딜러 족보 
                int[] computerPedigree = new int[14];

                int comCardCounter = 0;
                int comrTwo = 0;

                int comNonPair = 0;       //노페어

                int comOneCard = 0;        //원페어
                int comTwoCard = 0;        //투페어
                int comThreeCard = 0;      //트리플

                int comStraightCard = 0;       //스트레이트
                int comBackStraightCard = 0;       //백스트레이트
                int comMountainCard = 0;        //마운틴
                int comFlushCard = 0;      //플러쉬


                int comFullHouse = 0;
                int comFourCard = 0;

                for (int i = 0; i < computerTradeArray.Length; i++)
                {
                    if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 1)
                    {
                        computerPedigree[0]++;
                        computerPedigree[13]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 2)
                    {
                        computerPedigree[1]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 3)
                    {
                        computerPedigree[2]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 4)
                    {
                        computerPedigree[3]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 5)
                    {
                        computerPedigree[4]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 6)
                    {
                        computerPedigree[5]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 7)
                    {
                        computerPedigree[6]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 8)
                    {
                        computerPedigree[7]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 9)
                    {
                        computerPedigree[8]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 10)
                    {
                        computerPedigree[9]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 11)
                    {
                        computerPedigree[10]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 12)
                    {
                        computerPedigree[11]++;
                    }
                    else if ((int)Math.Ceiling(computerTradeArray[i] % 13.1) == 13)
                    {
                        computerPedigree[12]++;
                    }
                    else {/*Do Nothing*/}

                }

                int comTwoPairCount = 0;//

                for (int i = 0; i < computerPedigree.Length; i++) //13번 돌아서 비교
                {

                    if (0 < computerPedigree[i]) //노페어값 비교용
                    {
                        comNonPair = i + 1;
                    }
                    else {/*Do Nothing*/ }
                    if (i == 0 || i == 13)
                    {
                        if (i == 0)
                        {/*Do Nothing*/ }
                        else
                        {
                            comNonPair = 14;
                            if (computerPedigree[i] == 4)//포카드 
                            {
                                comFourCard = i + 1;
                            }
                            else if (computerPedigree[i] == 3)//트리플
                            {
                                comThreeCard = i + 1;
                            }
                            else if (computerPedigree[i] == 2) //원페어
                            {
                                comOneCard = i + 1;
                                comTwoPairCount++;
                                if (2 <= comTwoPairCount)
                                {
                                    comTwoCard = i + 1;  //투페어
                                }
                            }
                            else { /*Do Nothing*/}
                        }
                    }
                }

                int[] comFlushCheck = new int[4];

                //컴 플러쉬
                for (int i = 0; i < computerTradeArray.Length; i++)
                {
                    if (0 < computerTradeArray[i] && computerTradeArray[i] <= 13)
                    {
                        comFlushCheck[0]++;
                    }
                    else if (13 < computerTradeArray[i] && computerTradeArray[i] <= 26)
                    {
                        comFlushCheck[1]++;
                    }
                    else if (26 < computerTradeArray[i] && computerTradeArray[i] <= 39)
                    {
                        comFlushCheck[2]++;
                    }
                    else if (39 < computerTradeArray[i] && computerTradeArray[i] <= 52)
                    {
                        comFlushCheck[3]++;
                    }
                }   //컴 플러쉬

                int comStraightCount = 0;
                //컴 스트레이트
                for (int i = 0; i < computerPedigree.Length; i++)
                {
                    if (0 == computerPedigree[i])
                    {

                        comStraightCount = 0;

                    }
                    else
                    {
                        comStraightCount++;
                    }

                    if (comStraightCount == 5)
                    {
                        comStraightCard = i + 1;
                    }
                    else {/*Do Nothing*/ }
                }   //딜러스트레이트 조건



                //!승패

                if (0 < fourCard || 0 < comFourCard)
                {
                    if (comFourCard < fourCard)
                    {
                        Console.WriteLine("포카드로 승리");
                        playerPoint = +(playerInput * 2);

                    }
                    else
                    {
                        Console.WriteLine("딜러의 포카드로 패배");
                        playerPoint -= playerInput;
                    }
                }
                //!flush 승패 
                else if (5 == flushCheck[0] || 5 == flushCheck[1] || 5 == flushCheck[2] || 5 == flushCheck[3] ||
                    5 == comFlushCheck[0] || 5 == comFlushCheck[1] || 5 == comFlushCheck[2] || 5 == comFlushCheck[3])
                {
                    if (comFlushCheck[3] == 5 || flushCheck[3] == 5)
                    {
                        if (comFlushCheck[3] < flushCheck[3])
                        {
                            Console.WriteLine("플레이어의 플래쉬로 승리");
                            playerPoint = +(playerInput * 2);
                        }
                        else if (flushCheck[3] < comFlushCheck[3])
                        {
                            Console.WriteLine("딜러의 플래쉬로 패배");
                            playerPoint = -playerInput;
                        }
                        else {/*Do Nothing*/ }
                    }

                    else if (comFlushCheck[2] == 5 || flushCheck[2] == 5)
                    {
                        if (comFlushCheck[2] < flushCheck[2])
                        {
                            Console.WriteLine("플레이어의 플래쉬로 승리");
                            playerPoint = +(playerInput * 2);
                        }
                        else if (flushCheck[2] < comFlushCheck[2])
                        {
                            Console.WriteLine("딜러의 플래쉬로 패배");
                            playerPoint = -playerInput;
                        }
                        else {/*Do Nothing*/ }
                    }

                    else if (comFlushCheck[1] == 5 || flushCheck[1] == 5)
                    {
                        if (comFlushCheck[1] < flushCheck[1])
                        {
                            Console.WriteLine("플레이어의 플래쉬로 승리");
                            playerPoint = +(playerInput * 2);
                        }
                        else if (flushCheck[1] < comFlushCheck[1])
                        {
                            Console.WriteLine("딜러의 플래쉬로 패배");
                            playerPoint = -playerInput;
                        }
                        else {/*Do Nothing*/ }
                    }

                    else if (comFlushCheck[0] == 5 || flushCheck[0] == 5)
                    {
                        if (comFlushCheck[0] < flushCheck[0])
                        {
                            Console.WriteLine("플레이어의 플래쉬로 승리");
                            playerPoint = +(playerInput * 2);
                        }
                        else if (flushCheck[0] < comFlushCheck[0])
                        {
                            Console.WriteLine("딜러의 플래쉬로 패배");
                            playerPoint -= playerInput;
                        }
                    }
                    else {/*Do Nothing*/ }
                }   //flush 승패 

                else if (0 < comStraightCard || 0 < straightCard)
                {
                    if (comStraightCard < straightCard)
                    {
                        Console.WriteLine("플레이어의 스트레이트로 승리");
                        playerPoint += (playerInput * 2);
                    }
                    else if (straightCard < comStraightCard)
                    {
                        Console.WriteLine("딜러의 스트레이트로 패배");
                        playerPoint -= playerInput;
                    }
                    else
                    {
                        Console.WriteLine("무승부!");
                        playerPoint -= playerInput;
                    }
                }

                else if (0 < threeCard || 0 < comThreeCard)
                {
                    if (comThreeCard < threeCard)
                    {
                        Console.WriteLine("플레이어의 트리플로 승리");
                        playerPoint += (playerInput * 2);
                    }
                    else if (threeCard < comThreeCard)
                    {
                        Console.WriteLine("딜러의 트리플로 패배");
                        playerPoint -= playerInput;
                    }
                    else
                    {
                        Console.WriteLine("무승부");
                        playerPoint -= playerInput;
                    }
                }

                else if (0 < twoCard || 0 < comTwoCard)
                {
                    if (comTwoCard < twoCard)
                    {
                        Console.WriteLine("플레이어의 투페어로 승리");
                        playerPoint += (playerInput * 2);
                    }
                    else if (twoCard < comTwoCard)
                    {
                        Console.WriteLine("딜러의 투페어로 패배");
                        playerPoint -= playerInput;
                    }
                    else
                    {
                        Console.WriteLine("무승부");
                        playerPoint -= playerInput;
                    }
                }
                else if (0 < oneCard || 0 < comOneCard)
                {
                    if (comOneCard < oneCard)
                    {
                        Console.WriteLine("플레이어의 원페어로 승리");
                        playerPoint += (playerInput * 2);
                    }
                    else if (oneCard < comOneCard)
                    {
                        Console.WriteLine("딜러의 원페어로 패배");
                        playerPoint -= playerInput;
                    }
                    else
                    {
                        Console.WriteLine("무승부");
                        playerPoint -= playerInput;
                    }
                }

                //승리와 패배 조건.
                if (100000 <= playerPoint)
                {
                    isGameOver = true;
                    Console.WriteLine("\tYOU WIN!");

                }
                else if (playerPoint == 0)
                {
                    isGameOver = true;
                    Console.WriteLine("최소 배팅금이 없습니다. 패배!");

                    break;
                    Console.ReadLine();
                    Console.Clear();
                }

            }





        }
    }
}
