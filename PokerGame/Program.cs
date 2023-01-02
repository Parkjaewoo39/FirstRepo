using System;

namespace PokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrumpCard trumpCard = new TrumpCard();
            trumpCard.SetupTrumpCards();


            int playerPoint = 10000;

            int playerInput = 0;





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

                trumpCard.ComputerCard(0); //컴퓨터 5장

                Console.WriteLine("플레이어의 카드 드로우 차례\n내 카드를 확인 할려면 아무키나 입력하시오.");
                tabInput = Console.ReadLine();


                trumpCard.ComputerCard(5);   //플레이어 5장



                Console.Write("\n배팅 금을 입력하시오: 패쓰는 0 을 입력하시오.");
                Console.WriteLine("현재 소지 배팅금 {0} ", playerPoint);
                playerInput = Convert.ToInt32(Console.ReadLine());
                if (playerInput == 0)
                {

                }
                else
                {

                    Console.WriteLine("컴퓨터가 두 장을 뽑습니다.");
                    trumpCard.TwoCard(10);

                    Console.WriteLine("카드 두장을 교체 하시겠습니까?: ");
                    int.TryParse(Console.ReadLine(), out playerInput);


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

                    //}

                }
                if (playerPoint >= 100000)
                {
                   
                    Console.WriteLine("\tYOU WIN!");
                   
                    break;
                }
                else if (playerPoint == 0)
                {
                    
                    Console.WriteLine("최소 배팅금이 없습니다. 패배!");
                    
                    break;
                }

            }
        }



    }
}

