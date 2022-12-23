using System;

namespace Live_In_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**	-타이틀 씬	
             * -선택지를 포함한 이벤트 ->유저가 뭔가 선택 가능한 형태	
             * -보상or 패널티를 얻는 이벤트->유저가 골드 얻거나 아이템을 얻거나, 스탯치가 떨어지거나 하는 형태
             * -전투 씬 -> 오크가 등장하거나 늑대가 등장하거나 해서 싸워서 결과를 내는 형태 (어려움)
             */

            // ===========================================
            //            타이틀 씬 및 아무거나 입력시 시작.
            //===========================================
            while (true)
            {
                string tabToStart = string.Empty;                           //문자열 아무거나 입력시 시작하게 하는 버튼

                Console.WriteLine("==================================");    //가시성
                Console.WriteLine("==================================");    //가시성
                Console.WriteLine("\t  모험가 이야기 \n\tLIVE IN ADVENTURE" + //타이틀과 부제
                    "\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\t   TAP TO START ");                   //TAP하여 시작하라는 구절 출력.
                Console.WriteLine("==================================");    //가시성
                Console.WriteLine("==================================");    //가시성
                tabToStart = Console.ReadLine();                            //문자열을 입력하게 하는 선언.

                Console.WriteLine();                                        //빈공간
                Console.WriteLine();                                        //빈공간
                Console.WriteLine();                                        //빈공간



                Console.WriteLine("\t새로운 모험 \n\n" +                     //무작위 와 커스텀 모험을 알리는 구문
                    "\t무작위 모험 \n\n" +
                    "\t또는 당신만의 모험가로\n\n\t" +
                    "새로운 모험을 시작하세요!");


                Console.WriteLine();                                        //빈공간
                Console.WriteLine();                                        //빈공간
                Console.WriteLine();                                        //빈공간




                Random random = new Random();                               //배열에 담은 것을 무작위로 꺼내기위해 난수 선언

                int ran = random.Next(0, 4 + 1);                                 //int형 함수 선언과 동시에 random의 범위를 설정

                string[] strCha = new string[5] { "Alliance", "Horde", "Warrior", "Archer", "Prist" };   //문자열로 무작위 모험가 두 값을 배열에




                Random ranStatus = new Random();

                int ranS = ranStatus.Next(0, 10 + 1);                       // 각 배열 스테이터스의 최소부터 최대값

                int[] charStatus = new int[6] { 5, 5, 5, 5, 5, 5 };                           //힘, 민첩, 지능, 카리스마, 건강, 지혜

                int statusSum = 0;

                int maxStart_statusSum = 0;
                for (int index = 0; index < charStatus.Length; index++)
                {
                    statusSum += charStatus[index] + ranS;
                    maxStart_statusSum = statusSum;

                }
                //Console.WriteLine("{0}", maxStart_statusSum);


                //커스텀 모험가??                            
                //===========================================
                //        무작위 모험가 커스텀 모험가 선택
                //===========================================              

                while (true)                                                        //모험이 성공하거나 끝이 나야지만 끝나기 때문에 while문
                {
                    Console.WriteLine("무작위 모험가로 시작할려면 1을 입력하시오. \n" +   //
                        "커스텀 모험가로 시작할려면 2를 입력하시오");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("무작위 모험가 {0} \n ", strCha[ran]);
                        for (int i = 0; i < charStatus.Length; i++)
                        {

                            if (maxStart_statusSum == 50)                    //if의 조건을 배열들의 합이 50미만일때만 나오게
                            {
                                Console.WriteLine(
                                    "힘 {0} \n" + "민첩 {1}\n" + "지능 {2}\n" + "카리스마 {3} \n" + "건강 {4}\n" + "지혜 {5}\n", charStatus[i]);
                            }


                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("커스텀 모험가로 시작합니다.");
                        break;
                    }
                    else {/*Do Not THing*/}

                }


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.WriteLine("==================================");



                //===========================================
                //                 이벤트 발생
                // ===========================================
                while (true)
                {
                    Console.WriteLine("모험을 떠난 후 길을 가다가");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if 

                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("무작위 모험가 {0} 입니다.", strCha[ran]);
                    }

                    if 

                    //                1.사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
                    //    ex)
                    //		첫번째 문자열 : Hello
                    //        두번째 문자열: World

                    //        2개의 문자열은 다릅니다.

                    //    - Equals 메서드를 사용하지 않을것.

                    //    - hint Length 비교를 한다던지 ?


                    string strUser = String.Empty;
                    Console.WriteLine("문자를 입력하시오 :");
                    strUser = Console.ReadLine();


                    string str = String.Empty;
                    Console.WriteLine("문자를 입력하시오 :");
                    strUser = Console.ReadLine();


                    if (strUser.Length != str.Length)
                    {
                        Console.WriteLine("두 문자열은 다릅니다.");
                    }
                    else
                    {
                        Console.WriteLine("두 문자열은 같습니다.");
                    }


                    //2.5개의 음료(콜라, 물, 스프라이트, 주스 커피)를 판매하는 자판기 머신을 구현해보기.
                    //    사용자가1부터 5사의 숫자를 입력함.

                    //    선택한 음료를 출력함.

                    //    1~5이외의 숫자를 선택하면 오류 메시지 출력함.
                    //    ex)
                    //		콜라 , 물, 스프라이트, 주스 커피 중에서 하나를 선택하세요. 1

                    //        콜라를 선택하였습니다.

                    //        -프로그램 종료 -

                    //        hint - whitch나 if-else문 사용한다.

                    string[] dirnk = new string[5] { "콜라", "물", "스프라이트", "주스", "커피" };

                    int number = 0;

                    Console.WriteLine("콜라는 1번 물은 2번 스프라이트는 3번, 주스는 4번, 커피는 5\n" +
                        "원하는 음료의 번호를 누르세요 :");
                    int.TryParse(Console.ReadLine(), out number);               //TryParse는 데이터형식으로 시작한다.

                    while (true)
                    {
                        if (0 < number && number < 6)
                        {
                            switch (number - 1)
                            {
                                case 0:
                                    Console.WriteLine("1번 {0}을 뽑으셨습니다 ", dirnk[0]);
                                    break;
                                case 1:
                                    Console.WriteLine("2번 {0]을 뽑으셨습니다 ", dirnk[1]);
                                    break;
                                case 2:
                                    Console.WriteLine("3번 {0}을 뽑으셨습니다 ", dirnk[2]);
                                    break;
                                case 3:
                                    Console.WriteLine("4번 {0}을 뽑으셨습니다 ", dirnk[3]);
                                    break;
                                case 4:
                                    Console.WriteLine("5번 {0}을 뽑으셨습니다 ", dirnk[4]);
                                    break;

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("제대로 된 숫자를 입력해주세요 :");
                        }

                    }
                    Console.WriteLine("자판기 매진입니다.");





                    //3.배열 days[] 를 아래와 같이 초기화 하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성

                    //    -배열 days[] 는 ->31,29,31,30,31,30,31,31,30,31,30,31

                    //    ex)
                    //		1월은 31일까지 입니다.

                    //        2월은 29일까지 입니다...
                    //hint)배열의 초기화는 중괄호를 사용한다.
                    int[] days = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    int month = 0;

                    for (int index = 0; index < days.Length; index++)
                    {
                        Console.WriteLine("{0}월은 {1}일 입니다.", month + 1, days[index]);
                        month++;

                    }

                    //}

                }
            }
        }
    }
}