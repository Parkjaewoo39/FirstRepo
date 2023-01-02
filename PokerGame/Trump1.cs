using System;
using System.Collections.Generic;
using System.Linq;
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
        public void DrawCard()
        {
            ShuffleCards();
            ComputerCard(200);
        }   //ReRollCard()

        public void ComputerCard(int comValue)      //5개 뽑는식 
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

            Console.WriteLine("뽑은 카드는 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}입니다."
                , cardMark[comValue +0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1], cardMark[comValue + 2], 
                cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3], cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");
            Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                cardMark[comValue +0], cardNumber[comValue +0], cardMark[comValue + 1], cardNumber[comValue + 1], 
                cardMark[comValue + 2], cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3],
                cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine("|    | |    | |    | |    | |    | ");
            Console.WriteLine("|{0} {1}| |{2} {3}| |{4} {5}| |{6} {7}| |{8} {9}|",
                cardMark[comValue+0], cardNumber[comValue+0], cardMark[comValue + 1], cardNumber[comValue + 1],
                cardMark[comValue + 2], cardNumber[comValue + 2], cardMark[comValue + 3], cardNumber[comValue + 3],
                cardMark[comValue + 4], cardNumber[comValue + 4]);
            Console.WriteLine(" -----  -----  -----  -----  ----- ");

        }   //RollCard

        


        public void TwoCard(int comValue)
        {
            int[] cardArray = new int[comValue + 2];
            //int[] cardNumberArray = new int[comValue + 5];
            string[] cardMark = new string[comValue + 2];
            string[] cardNumber = new string[comValue + 2];
            //카드 숫자와 카드 문양을 배열에 담는데 

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
            Console.WriteLine("|{0} {1}\t|{2} {3}| ",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine("|    |\t|    |  ");
            Console.WriteLine("|{0} {1}|\t|{2} {3}|",
                cardMark[comValue + 0], cardNumber[comValue + 0], cardMark[comValue + 1], cardNumber[comValue + 1]);
            Console.WriteLine(" -----  ----- ");
        }   //RollCard


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

