using System;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            // *선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수있다. 조건을 처리할 내용이 많은 경우 유용하다.
            // *switch, casem default 키워드를 사용하여 조건을 처리한다.
            // */

           
            //        //////////////////////////////////

            //        //모음 a,i,u,e,o
            //        //모음이 아니면 자음으로 갯수 세기
            //        //

            //        int vowels = 0;//모음값
            //int consonent = 0;//자음값
            //char endValue = '$';//끝내는 값.
            

            //while (endValue != '#') //while 반복하는데 끝내는값이 들어갈대까지) != 다르다.
            //{
            //    Console.Write("영문자를 입력하세요. : ");// 
            //    char endAl = Convert.ToChar(Console.ReadLine());

            //    switch (endAl)//
            //    {
            //        case 'A': //case로 대문자 A 분류 후
            //            vowels++;//A의 개수를 vowels값에 더함 
            //            break;//case'A'를 세는걸 멈춤
            //        case 'a':
            //            vowels++;
            //            break;
            //        case 'I':
            //            vowels++;
            //            break;
            //        case 'i':
            //            vowels++;
            //            break;
            //        case 'O':
            //            vowels++;
            //            break;
            //        case 'o':
            //            vowels++;
            //            break;
            //        case 'U':
            //            vowels++;
            //            break;
            //        case 'u':
            //            vowels++;
            //            break;
            //        case 'E':
            //            vowels++;
            //            break;
            //        case 'e':
            //            vowels++;
            //            break;
            //        case '#':
            //            endValue = '#';
            //            break;
            //        default:
            //            consonent++;
            //            break;

                        
            //    }
                

            //}
            //Console.WriteLine("모음은 {0} 개 ", vowels);
            //Console.WriteLine("자음은 {0} 개 ", consonent);




            //Console.WriteLine();
            ///**
            // * -프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에, 사용자가 결정한 번호를
            //    컴퓨터가 추측 하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를 컴퓨터에 알려야 한다.
            //    컴퓨터가 맞힐때까지 반복(어려움1)

            //    -사용자가 결정한 값의 범위는 (1~100) 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수 있도록
            //    어려운거 1을 수정하시오.
            // */
            ////산수 문제를 자동으로 출제하는 프로그램을 작성해보자. 덧셈 문제들을 자동으로 생성하여야 한다.
            ////피연산자는 0~99사이의 숫자(난수) 한 번이라도 맞으면 종료. 틀리면 리트라이. (기본형)

            ////A+B=C

            //Random random = new Random();
            //int ranNum1 = random.Next(100);
            //int ranNum2 = random.Next(100);

            //int ranNumAdd = ranNum1+ ranNum2;//덧셈값
            //// 프로그램이 내는 두가지값
            //int solution = 0;
            //while ( solution != ranNumAdd)
            //{
            //    Console.WriteLine("{0} + {1}의 값을 입력하시오.", ranNum1, ranNum2);
            //      solution = Convert.ToInt32(Console.ReadLine()); //

            //    if (solution == ranNumAdd)
            //    {
            //        Console.WriteLine("정답입니다. ");                    
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("값을 다시 적으시오. : ");
                     
            //    }
               
                
            //}
            ////곱셈
            //Random random_Mul = new Random();
            //int ranNumMul_1 = random_Mul.Next(100);
            //int ranNum2Mul_2 = random_Mul.Next(100);

            //int ranNumMulAdd = ranNumMul_1 * ranNum2Mul_2;//int로 
            //// 프로그램이 내는 두가지값
            //int solution_Mul = 0;
            //while (solution_Mul != ranNumMulAdd)
            //{
            //    Console.WriteLine("{0} * {1}의 값을 입력하시오.", ranNumMul_1, ranNum2Mul_2);
            //    solution_Mul = Convert.ToInt32(Console.ReadLine()); //

            //    if (solution_Mul == ranNumMulAdd)
            //    {
            //        Console.WriteLine("정답입니다. ");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("값을 다시 적으시오. : ");

            //    }


            //}
            //Random random_Div = new Random();
            //float ranNumDiv_1 = random_Div.Next(100);
            //float ranNumDiv_2 = random_Div.Next(100);
            
            //float ranNumDiv_Add = 0.0f;
            

            //ranNumDiv_Add = ranNumDiv_1 / ranNumDiv_2;//
            //// 프로그램이 내는 두가지값
            //float solution_Div = 0.0f;
            //while (solution_Mul != ranNumMulAdd)
            //{
            //    Console.WriteLine("{0} / {1}의 값을 입력하시오.", ranNumDiv_1, ranNumDiv_2);
            //    solution_Mul = Convert.ToInt32(Console.ReadLine()); //

            //    if (solution_Mul == ranNumMulAdd)
            //    {
            //        Console.WriteLine("정답입니다. ");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("값을 다시 적으시오. : ");

            //    }


            //}



            // Random ranNumber = new Random();
            // int RanNum = ranNumber.Next(1, 100);



            //
            //모음이 aiueo AIUEO인걸 선언
            //1~10까지 정수의 합
            //int sumNumber = 0;

            //for (int index = 1; index < 10; index++) 
            //{/////1번           2번           4번
            //    ///             5번           7번
            //    sumNumber += index;
            //    ////////3번 6번
            //    Console.WriteLine($"1부터 10까지의 정수의 합= {sumNumber}");
            //    Console.WriteLine("1부터 10까지의 정수의 합= {0} ", sumNumber);
            //}



            // Random ranNumber = new Random();
            // int RanNum = ranNumber.Next(1, 100);

            // Console.WriteLine("1~100사이 숫자를 적으시오 : ");
            // int Number = Convert.ToInt32(Console.ReadLine()); 

            //while ()

            /**
             *foreach 문은 배열(Array)이나 컬레션(Colletion) 같은 값을 여러 개 담고 있는 데이터 구조에서
             *각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
             *
             */
            //string에서 글자를 하나씩 출력
            string stringText = "Hello World!";
            //H e l l o W o r l d ! 하나하나 다 데이터라 stringText가 여러개를 담은 배열이나 컬렉션이다.
            //컬레션은 다른말로 컨테이너라고 한다.
            int loopCount = 0;
            foreach (char oneCharactor in stringText) 
            {       //stringText에서 하나씩 
                Console.Write("{0}", oneCharactor);
                loopCount++;
            }
            Console.WriteLine();
            Console.WriteLine("Loop count: {0}, stringText's length: {1}",
                loopCount, stringText.Length);



            //     1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기.
            //3의 배수이면서 4의 배수의 최소공배수는 12
            
            
            int A = 0;
            const int B = 12;
            
            for (int index = 1; index < 100;index ++)
            {
                
                Console.WriteLine("1~100사의 숫자중 3의 배수이면서 4의배수인정수의 합 = {0}",A*B);
                index += A;

                
               
                
            }

            //두개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램 작성.




            //-항상 큰 수에서 작은 수를 뺀 결과를 출력하고 결과는 언제나 0 이상이어야 함



            //구구단을 출력하되 짝수(2단, 4단, 6단, 8단)만 출력 되도록 하는 프로그램을 작성.
            //-2다은 2x2까지만,4단은 4x4 까지만,6단은 6x6까지, 8단은 8x8까지.
            //출력.
            //break와 continue를 사용할것.
            //다음 식을 만족하는 모든A와Z를 구하는 프로그램을 작성.
            //    A Z
            //   +Z A
            //--------------
            //    99
        }
    }
}