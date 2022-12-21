using System;
using System.Reflection.Metadata;

namespace Whatisobjector
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /**
             *제어문 소개
             *프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문),
             *반복 구조(반복문)가 있다.
             *
             *순차문 프로그램은 기본적으로 Main() 메서드 시작 시점부터 끝 지점까지 코드가 나열되면 순서대로
             *실행 후 종료한다.
             *
             *제어문
             *프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             *조건문과 반복문으로 구분한다.
             *
             *조건문(선택문)
             *조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             *하기도 한다.
             *
             *반복문
             *특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
             *
             */

            /**
             * if/ else 문
             * 프로그램 흐름을 여러가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if문을 사용한다.
             * if문은 조건을 비교해서 판단하는 구문으로 if, else, else if 세가지 키워드가 있다.
             */

            //02.3 예제
            // 두개의 정수 중에서 더 큰 수를 찾는 프로그램.
            int numberX, numberY;
            Console.Write("X값을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numberX);
            Console.Write("Y값을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numberY);

            if (numberY < numberX)
            {
                Console.WriteLine("x가y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("y가x보다 큽니다.");
            }

            Console.WriteLine();
            /**
             * 02.4 중간점검
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100이상은 200ml미만은 medium, 200ml이상은
             * large라고 출력하는 if-else 문을 작성.
             */

            Console.Write("컵사이즈를 입력하시오:");
            int mug = Convert.ToInt32(Console.ReadLine());
            if (mug < 100)
            {
                Console.WriteLine("small");
            }
            else if (mug <= 200)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("large");
            }

            Console.WriteLine();



            Console.WriteLine("비밀코드를 입력하시오.: ");
            
            const char CODE = 'h';//char 문자를 객체 값으로 매김.
           char USER_INPUT = Convert.ToChar(Console.ReadLine());
            //    인풋 함수랑 covnert.To 함수랑 같아야함.
            

            

            bool charBigger = false;
            if ( 'h' < USER_INPUT)
            {
                Console.WriteLine("앞에있음: ");
                Console.WriteLine();
            }
            else if(USER_INPUT < 'h')
            {
                Console.WriteLine("뒤에있음.");
            }
            else
            {
                Console.WriteLine("정답. ");
            }

            Console.WriteLine();

           
            Console.WriteLine("첫번째 정수를 적으시오");
            int A = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("두번째 정수를 적으시오");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("세번째 정수를 적으시오");
            int C = Convert.ToInt32(Console.ReadLine());

            int MAX = int.MinValue;
            

           
            if (MAX > A)
            {
                if (MAX > B)
                { 
                   
                    Console.WriteLine("가장 큰 정수는{0}", MAX);
                }
            }
            else if (MAX > B) 
            {
                if (MAX > C)
                {
                    Console.WriteLine("가장 큰 정수는{0}", MAX);
                }
            }
            else 
            {
                
                    Console.WriteLine("가장 큰 정수는{0}", MAX);
               
            }


            //const char SECRET_CODE2 = '%';

            //bool isSmallAlphabet = false;
            //bool isBigAlphabet = false;
            //bool isAlphabet = false;

            //isSmallAlphabet = ('a' <= SECRET_CODE2 && SECRET_CODE2 <= 'z');
            //isBigAlphabet = ('A' <= SECRET_CODE2 && SECRET_CODE2 <= 'z');

            //isAlphabet = isSmallAlphabet|| isBigAlphabet;

            //if (isAlphabet)
            //{
            //    Console.WriteLine("{0}은 알파벳이 맞습니다.", SECRET_CODE2);
            //}
            //else 
            //{
            //    Console.WriteLine("{0}은 알파벳이 아닙니다.", SECRET_CODE2);
            //}
        }
            
    }
}
