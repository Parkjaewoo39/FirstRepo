using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Linq.Expressions;
=======
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{

    public class TrumpCard
    {

        private int[] trumpCardSet;      //내가 사용할 카드 세트
        private string[] trumpCardMark;  // 트러픔 카드의 마크

        public void SetupTrumpCards()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;

            }   //loop: 카드를 셋업하는 루프
                //트러픔 카드 마크 셋업
            trumpCardMark = new string[4] { "♣", "♥", "◆", "♠" };
        }       //SetupTrumpCards()

        //!카드를 섞는 함수
        public void ShuffleCards()
        {
            ShuffleCards(200);
        }
        //! 한장의 카드를 뽑아서 보여주는 함수

        //!셔플 하고서 카드를 한 장 뽑아서 출력하는 함수
<<<<<<< HEAD
        //public void DrawCard()
        //{
        //    ShuffleCards();
        //    ComputerCard(200);
        //}   //ReRollCard()

        public void DrawFiveCard(int comValue)      //5개 뽑는식 
=======
        public void DrawCard()
        {
            ShuffleCards();
            DrawFiveCard(200);
        }   //ReRollCard()

<<<<<<< HEAD
        
        //!5개 뽑는식
        public void DrawFiveCard(int comValue)     
=======
        public void ComputerCard(int comValue)      //5개 뽑는식 
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
>>>>>>> 9b6781786f7284cfb9de843b803fc865fdef7b7c
        {
            int[] cardArray = new int[comValue + 5];
            //int[] cardNumberArray = new int[comValue + 5];
            string[] cardMark = new string[comValue + 5];
            string[] cardNumber = new string[comValue + 5];
            //카드 숫자와 카드 문양을 배열에 담는데 

            int cardValue = 0;

            for (int i = comValue; i < comValue + 5; i++)
            {
                cardArray[i] = trumpCardSet[i];

                cardMark[i] = trumpCardMark[(cardArray[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(cardArray[i] % 13.1).ToString();

                //cardValue = (int)Math.Ceiling(card % 13.1);
                

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "K";
                        break;

                }

            }

            Console.WriteLine("뽑은 카드는 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}입니다."
<<<<<<< HEAD
                , cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1], cardMark[comValue + 2],
                cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3], cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");
            Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1],
                cardMark[comValue + 2], cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3],
                cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine("|    | |    | |    | |    | |    |");
            Console.WriteLine("|{1} {0}| |{3} {2}| |{5} {4}| |{7} {6}| |{9} {8}|",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1],
=======
                , cardMark[comValue +0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1], cardMark[comValue + 2], 
                cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3], cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");
            Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                cardMark[comValue +0], cardNumber[comValue +0], cardMark[comValue + 1], cardNumber[comValue + 1], 
                cardMark[comValue + 2], cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3],
                cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine("|    | |    | |    | |    | |    | ");
            Console.WriteLine("|{1} {0}| |{3} {2}| |{5} {4}| |{7} {6}| |{9} {8}|",
                cardMark[comValue+0], cardNumber[comValue+0], cardMark[comValue + 1], cardNumber[comValue + 1],
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
                cardMark[comValue + 2], cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3],
                cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");

        }   //DrawFiveCard() 5장뽑는 함수 

<<<<<<< HEAD
        //!플레이어 카드 값과 바뀐 카드를 보기위한 함수
        public void PlayerFiveCardValue(int comValue1, int comValue2, int comValue3, int comValue4, int comValue5)
        {
            int[] cardArray = new int[5] { comValue1, comValue2, comValue3, comValue4, comValue5};
            
            string[] cardMark = new string[5];
            string[] cardNumber = new string[5];
            //카드 숫자와 카드 문양을 배열에 담는데 

            int cardValue = 0;

            for (int i = 0; i < 5; i++)
            {
                
                cardMark[i] = trumpCardMark[(cardArray[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(cardArray[i] % 13.1).ToString();

                //cardValue = (int)Math.Ceiling(card % 13.1);
=======
<<<<<<< HEAD

=======
        
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
>>>>>>> 9b6781786f7284cfb9de843b803fc865fdef7b7c


                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "K";
                        break;

                }

            }

            Console.WriteLine("뽑은 카드는 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}입니다."
                , cardMark[0], cardNumber[0], cardMark[1], cardNumber[1], cardMark[2],
                cardNumber[2], cardMark[3], cardNumber[3], cardMark[4], cardNumber[4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");
            Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                cardMark[0], cardNumber[0], cardMark[1], cardNumber[1],
                cardMark[2], cardNumber[2], cardMark[3], cardNumber[3],
                cardMark[4], cardNumber[4]);
            Console.WriteLine("|    | |    | |    | |    | |    | ");
            Console.WriteLine("|{1} {0}| |{3} {2}| |{5} {4}| |{7} {6}| |{9} {8}|",
                cardMark[0], cardNumber[0], cardMark[1], cardNumber[1],
                cardMark[2], cardNumber[2], cardMark[3], cardNumber[3],
                cardMark[4], cardNumber[4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");

        }   //DrawFiveCard() 5장뽑는 함수 


        //! 2장씩 뽑는거
        public void DrawTwoCard(int comValue)       
        {
            int[] cardArray = new int[comValue + 2];
            //int[] cardNumberArray = new int[comValue + 5];
            string[] cardMark = new string[comValue + 2];
            string[] cardNumber = new string[comValue + 2];
            
            int cardValue = 0;

            for (int i = comValue; i < comValue + 2; i++)
            {
                cardArray[i] = trumpCardSet[i];

                cardMark[i] = trumpCardMark[(cardArray[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(cardArray[i] % 13.1).ToString();

                //cardValue = (int)Math.Ceiling(card % 13.1);
                //comValue++;

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "K";
                        break;

                }

            }

            Console.WriteLine("뽑은 카드는 {0} {1} {2} {3}입니다."
                , cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine(" -----  ----- ");
<<<<<<< HEAD
            Console.WriteLine("|{0} {1}|\t|{2} {3}| ",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine("|    |\t|    |  ");
            Console.WriteLine("|{1} {0}|\t|{3} {2}|",
=======
<<<<<<< HEAD
            Console.WriteLine("|{0} {1}|\t|{2} {3}|",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine("|    |\t|    | ");
            Console.WriteLine("|{1} {0}|\t|{3} {2}|",
=======
            Console.WriteLine("|{0} {1}\t|{2} {3}| ",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine("|    |\t|    |  ");
            Console.WriteLine("|{0} {1}|\t|{2} {3}|",
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
>>>>>>> 9b6781786f7284cfb9de843b803fc865fdef7b7c
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine(" -----  ----- ");
        }   //TwoCard

        //! 1장씩 뽑는거
        public int DrawOneCard(int comValue)
        {
            int[] cardArray = new int[comValue+1 ];
            //int[] cardNumberArray = new int[comValue + 5];
            string[] cardMark = new string[comValue +1];
            string[] cardNumber = new string[comValue +1];

            int cardValue = 0;

            for (int i = comValue; i < comValue + 1; i++)
            {
                cardArray[i] = trumpCardSet[i];

                cardMark[i] = trumpCardMark[(cardArray[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(cardArray[i] % 13.1).ToString();

                //cardValue = (int)Math.Ceiling(card % 13.1);
                //comValue++;

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "K";
                        break;

                }

            }

            Console.WriteLine("뽑은 카드는 {0} {1} 입니다."
                , cardMark[comValue ], cardNumber[comValue]);
            Console.WriteLine(" -----  ");
            Console.WriteLine("|{0} {1}| ",
                cardMark[comValue ], cardNumber[comValue]);
            Console.WriteLine("|    |");
            Console.WriteLine("|{0} {1}| ",
                cardMark[comValue], cardNumber[comValue]);
            Console.WriteLine(" ----- ");
            return cardArray[comValue];

        }   //oneCard

        //! 1장씩 뽑는 값
        public int DrawOneCardValue(int comValue)       //덱set의 순서에 카드 한장의 값을 리턴해서 담은 함수
        {

            int a = trumpCardSet[comValue];
            return a;
            
        }   //DrawOneCardValue

<<<<<<< HEAD
        public void FiveCardArray(int cardOne, int cardTwo, int cardThree, int cardFour, int cardFive)  //카드 교체 배열값 담기
        {
            int[] card = new int[5] { cardOne, cardTwo, cardThree, cardFour, cardFive };
            int[] cardValue = new int[5];
            string[] cardMark = new string[5];
            string[] cardNumber = new string[5];

            for (int i = 0; i < 5; i++)
            {



                cardMark[i] = trumpCardMark[(card[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(card[i] % 13.1).ToString();

                cardValue[i] = (int)Math.Ceiling(card[i] % 13.1);

                //cardValue = (int)Math.Ceiling(card % 13.1);
                //comValue++;



                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "K";
                        break;

                }   //switch



                Console.WriteLine("뽑은 카드는 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}입니다."
                    , cardMark[ 0], cardNumber[ 0], cardMark[ 1], cardNumber[ 1], cardMark[ 2],
                    cardNumber[+ 2], cardMark[ 3], cardNumber[ 3], cardMark[ 4], cardNumber[ 4]);
                Console.WriteLine(" -----  -----  -----  -----  ----- ");
                Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                    cardMark[ 0], cardNumber[ 0], cardMark[ 1], cardNumber[ 1],
                    cardMark[ 2], cardNumber[ 2], cardMark[ 3], cardNumber[ 3],
                    cardMark[ 4], cardNumber[ 4]);
                Console.WriteLine("|    | |    | |    | |    | |    |");
                Console.WriteLine("|{1} {0}| |{3} {2}| |{5} {4}| |{7} {6}| |{9} {8}|",
                    cardMark[0], cardNumber[0], cardMark[1], cardNumber[1],
                    cardMark[2], cardNumber[2], cardMark[3], cardNumber[3],
                    cardMark[4], cardNumber[4]);
                Console.WriteLine(" -----  -----  -----  -----  ----- ");

                for (int index = 0; index < 5; index++) 
                {
                    Console.WriteLine("교체할 카드는 {0} {1}", cardMark[i], cardNumber[i]);
                    Console.WriteLine();
                    
                }
            }
        }       //FiveCardDarw
        public int OneDarwCard(int oneDraw)
        {

            int cardVal = 0;
            int card = trumpCardSet[oneDraw];

            string cardMark = trumpCardMark[(card - 1) / 13];
            string cardNumber = Math.Ceiling(card % 13.1).ToString();

            cardVal = (int)Math.Ceiling(card % 13.1);


            switch (cardNumber)
            {
                case "11":
                    cardNumber = "J";
                    break;
                case "12":
                    cardNumber = "Q";
                    break;
                case "13":
                    cardNumber = "k";
                    break;
                default:
                    /* Do Nothing*/
                    break;

            } // switch


            Console.WriteLine(" ----");
            Console.WriteLine("|{0}{1} |", cardMark, cardNumber);
            Console.WriteLine("|    |");
            Console.WriteLine("| {0}{1}|", cardNumber, cardMark);
            Console.WriteLine(" ----");
            Console.WriteLine("뽑은 카드는 {0}{1} 입니다.", cardMark, cardNumber);

            return card;

        }// 

=======
>>>>>>> ccdb80088b1eac270c71eab8e7d224f757f52852
        public void PrintCardSet()
        {
            foreach (int card in trumpCardSet)
            {
                Console.Write("{0} ", card);
            }   //PrintCardSet()
        }

        //!내부에서 사용하는 배열을 1번 섞는 함수.
        public int[] ShuffleOnce(int[] intArray)
        {
            Random random = new Random();
            int sourIndex = random.Next(0, intArray.Length);
            int destIndex = random.Next(0, intArray.Length);

            int tempVarible = intArray[sourIndex];
            intArray[sourIndex] = intArray[destIndex];
            intArray[destIndex] = tempVarible;

            return intArray;
        }

        private void ShuffleCards(int howManyLoop)
        {
            for (int i = 0; i < howManyLoop; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);
            } //ShuffleCard//
        }
    }
}

