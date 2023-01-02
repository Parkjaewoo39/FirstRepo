//using System;

//namespace BlackJack
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            TrumpCard trumpCard = new TrumpCard();
//            trumpCard.SetupTrumpCards();


//            int playerPoint = 10000;

//            int playerInput = 0;






//            while (true)
//            {
//                Console.WriteLine("※***********************※");
//                Console.WriteLine("※     카드 뽑기 게임    ※");
//                Console.WriteLine("※***********************※");

//                Console.WriteLine("※   상대 컴퓨터의 턴    ※");


//                trumpCard.ShuffleCards();
//                int comOneCard = trumpCard.ComputerCard(0);
//                int comTwoCard = trumpCard.ComputerCard(1);
//                int comThreeCard = trumpCard.ComputerCard(2);
//                int comForeCard = trumpCard.ComputerCard(3);
//                int comFiveCard = trumpCard.ComputerCard(4);

//                카드 두번 뽑고 그값을 어디에 저장해야하는디?

//                Console.Write("\n배팅 금을 입력하시오: 패쓰는 0 을 입력하시오.");
//                Console.WriteLine("현재 소지 배팅금 {0} ", playerPoint);
//                playerInput = Convert.ToInt32(Console.ReadLine());
//                if (playerInput == 0)
//                {

//                }
//                else
//                {
//                    Console.WriteLine("플레이어가 ");

//                    int usercard = trumpCard.ComputerCard(2);
//                    if ((comOneCard < usercard && usercard < comTwoCard) || (comTwoCard < usercard && usercard < comOneCard))
//                    {
//                        Console.WriteLine("배팅에서 승리 하셨습니다.");
//                        Console.WriteLine("배팅 승리 수당 {0} ", playerInput * 2);
//                        playerPoint += playerInput * 2;
//                    }
//                    else
//                    {
//                        Console.WriteLine("배팅에서 패배 하셨습니다.");
//                        Console.WriteLine("잃은 수당 {0} ", playerInput);
//                        Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");

//                        playerPoint -= playerInput;

//                    }

//                }
//                if (playerPoint >= 100000)
//                {
//                    Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");
//                    Console.WriteLine("YOU ARE BLACK JACK!");
//                    Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");
//                    break;
//                }
//                else if (playerPoint == 0)
//                {
//                    Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");
//                    Console.WriteLine("최소 배팅금이 없습니다. 패배!");
//                    Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★");
//                    break;
//                }

//            }
//        }
//    }
//    internal class BlackJack
//    {
//        public static void BlackJackGame()
//        {
//            /**
//             * -컴퓨터가 5장을 뽑음
//             * -내가 5장을 뽑음
//             * - 배팅
//             * -배팅을 안하면 새 게임
//             * - 컴퓨터 2장 추가로 받음 -총 7장
//             * - 나는 2장을 교체할수 있음(카드1장 교체를 두번)
//             * - 결과 체크 족보
//             * -이기면 포인트 2배 지면 잃음
//             * 
//             */



//        }
//    }
//    public class TrumpCard
//    {
//        private int[] trumpCardSet;      //내가 사용할 카드 세트
//        private string[] trumpCardMark;  // 트러픔 카드의 마크

//        public void SetupTrumpCards()
//        {
//            trumpCardSet = new int[52];
//            for (int i = 0; i < trumpCardSet.Length; i++)
//            {
//                trumpCardSet[i] = i + 1;

//            }   //loop: 카드를 셋업하는 루프
//            트러픔 카드 마크 셋업
//            trumpCardMark = new string[4] { "♥", "♠", "◆", "♣" };
//        }       //SetupTrumpCards()

//        !카드를 섞는 함수
//        public void ShuffleCards()
//        {
//            ShuffleCards(200);
//        }
//        ! 한장의 카드를 뽑아서 보여주는 함수

//        !셔플 하고서 카드를 한 장 뽑아서 출력하는 함수
//        public void DrawCard()
//        {
//            ShuffleCards();
//            ComputerCard(200);
//        }   //ReRollCard()

//        public int ComputerCard(int comValue)
//        {


//            int cardValue = 0;

//            int card = trumpCardSet[comValue];
//            string cardMark = trumpCardMark[(card - 1) / 13];
//            string cardNumber = Math.Ceiling(card % 13.1).ToString(); //13으로 나누면 14번째 카드가 0으로 나와서 double형으로 ㄷ올림 처리
//            cardValue = (int)Math.Ceiling(card % 13.1);

//            switch (cardNumber)
//            {
//                case "11":
//                    cardNumber = "J";
//                    break;
//                case "12":
//                    cardNumber = "Q";
//                    break;
//                case "13":
//                    cardNumber = "K";
//                    break;

//            }

//            Console.WriteLine("뽑은 카드는 {0} {1}  입니다.", cardMark, cardNumber);


//            Console.WriteLine("  ----- ");
//            Console.WriteLine("|{0} {1}|", cardMark, cardNumber);
//            Console.WriteLine("|    |");
//            Console.WriteLine("|{0} {1}|", cardNumber, cardMark);
//            Console.WriteLine("  -----");

//            return cardValue;
//        }   //RollCard
//        public int MyCard()
//        {
//            int numValue = 0;


//            int card = trumpCardSet[0];
//            string cardMark = trumpCardMark[(card - 1) / 13];
//            string cardNumber = Math.Ceiling(card % 13.1).ToString(); //13으로 나누면 14번째 카드가 0으로 나와서 double형으로 ㄷ올림 처리
//            numValue = (int)Math.Ceiling(card % 13.1);

//            switch (cardNumber)
//            {
//                case "11":
//                    cardNumber = "J";
//                    break;
//                case "12":
//                    cardNumber = "Q";
//                    break;
//                case "13":
//                    cardNumber = "K";
//                    break;

//            }

//            Console.WriteLine("내가 뽑은 카드는 {0} {1}  입니다.", cardMark, cardNumber);
//            Console.WriteLine(" -----");
//            Console.WriteLine("|{0} {1}|", cardMark, cardNumber);

//            Console.WriteLine("|    |");
//            Console.WriteLine("|{0} {1}|", cardNumber, cardMark);
//            Console.WriteLine(" -----");

//            return numValue;
//        }   //RollCard


//        public void PrintCardSet()
//        {
//            foreach (int card in trumpCardSet)
//            {
//                Console.Write("{0} ", card);
//            }   //PrintCardSet()
//        }

//        !내부에서 사용하는 배열을 1번 섞는 함수.
//        public int[] ShuffleOnce(int[] intArray)
//        {
//            Random random = new Random();
//            int sourIndex = random.Next(0, intArray.Length);
//            int destIndex = random.Next(0, intArray.Length);

//            int tempVarible = intArray[sourIndex];
//            intArray[sourIndex] = intArray[destIndex];
//            intArray[destIndex] = tempVarible;

//            return intArray;
//        }

//        private void ShuffleCards(int howManyLoop)
//        {
//            for (int i = 0; i < howManyLoop; i++)
//            {
//                trumpCardSet = ShuffleOnce(trumpCardSet);
//            } //ShuffleCard//
//        }
//    }
//}