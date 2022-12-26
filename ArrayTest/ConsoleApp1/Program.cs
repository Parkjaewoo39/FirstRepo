using System;

namespace ArrayTest

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                1.사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
            //    ex)
            //		첫번째 문자열 : Hello
            //        두번째 문자열: World

            //        2개의 문자열은 다릅니다.

            //    - Equals 메서드를 사용하지 않을것.

            //    - hint Length 비교를 한다던지 ?


            string strUser = String.Empty;                  //문자열 비교를 위해 string 형식으로 담는데
                                                            //

            Console.WriteLine("문자를 입력하시오 :");
            strUser = Console.ReadLine();


            string str = String.Empty;
            Console.WriteLine("문자를 입력하시오 :");
            str = Console.ReadLine();


            if (strUser != str)
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


            Console.WriteLine("\n\n\n");




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
        }
    }
}