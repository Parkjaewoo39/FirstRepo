using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class funtion
    {
        //static int _number3 = 1;
        //static int _number4 = 2;
        // class안은 글로벌 변수의 앞에 언더바(_) 나 m_를 붙여서 표시
        //static 뭐뭐 메인함수() 메인함수 이름이 같을때 ()의 파라미터를 달리 줘서 같은 이름의 함수를 만들수잇다.
        static void Main(string[] args)
        {
            //Multi();
            //Multi("반갑습니다.");
            //Multi("또 만나요.",3);

            //Console.WriteLine("Factorial: {0}", Factorial(3));
            //Factorial(5);
            //int userInputOne = 0;
            //int userInputTwo = 0;
            //Console.WriteLine("비교할 수를 2개 입력하시오.: ");
            //int.TryParse(Console.ReadLine(),out userInputOne);
            //int.TryParse(Console.ReadLine(), out userInputTwo);
            //int numBer = addFunction(userInputOne,userInputTwo);
            //int numberMax = MaxFunction(userInputOne, userInputTwo);
            //int numberMin = MinFunction(userInputOne, userInputTwo);
            //Console.WriteLine("두 수의 합은 {0} 이다. \n최대값은 {1} \n최소값은 {2} ", numBer,numberMax, numberMin);


            //int userInputThree = 0;

            //Console.WriteLine("찾고자 하는 절댓값을 하나 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out userInputThree);
            //int numberAbsVa = AbsoluteValueFunction(userInputThree);
            //Console.WriteLine("절대값은 {0} 이다.",numberAbsVa);
            /////


            //int someValue = 100;
            //Console.WriteLine(someValue);
            //someValue = Hi();
            //Console.WriteLine(someValue);


            //Hi("Hi I'm JPark");
            //ShowMessage("매개변수");
            //ShowMessage("매개변수");


            //string returnValue = GetString();
            //Console.WriteLine(returnValue);


            //int r = SquareFunction(15);
            //Console.WriteLine(r);
            //Console.WriteLine("Main의 number 값은??? {0} {1}", _number3, _number4);
            //int number1 = 10;
            //int number2 = 30;
            //Swap(number1, number2);
            //Swap 함수에 넘버가 들어감
            //넘버1 넘버2가 선언된 값만 받는거임. 윗줄은
            //Console.WriteLine("Main의 number 값은??? {0} {1}", number1, number2);
            //main의 넘버는 int number 의 값이 들어가는거. swap은 swap함수로 가버리고 소멸.


            //Hi();
            //Multiply(5,4);





            /**
             * 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x,y,z)를 정의 할것.
             * 
             * -화면에 "Hello"를 출력하는 SayHello()함수를 작성.             * 
             * int 타입 매개 변수 받아서 그 횟수만큼 Hello를 반복해서 출력.
             * 
             * -다른 두 변이 주어 졌을 때 지각 삼각형의 빗변을 계산하는 함수.
             * Hypot()를 정의할것. 
             * 매개변수는 2개 타입은 double
             * 리턴 타입도 double 형
             * -주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성.
             * -판별할 값의 범위는 2~100사이의 값중에서
             * 소수는 모두 출력.
             * *-사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는
             * *프로그램을 작성.(함수사용)
             * *전화번호를 입력 받는다 -> 소괄호를 삭제한 형태로 출력한다.
             * *quit입력하면 프로그램을 종료한다.
             * *프로그램 종료 전까지 전화번호를 입력받는다.
             */

            int userMaxNumX = 0;
            int userMaxNumY = 0;
            int userMaxNumZ = 0;

            


            Console.WriteLine("최대값을 찾기 위해 첫 정수를 입력 하시오.: ");
            int.TryParse(Console.ReadLine(), out userMaxNumX);
            Console.WriteLine("최대값을 찾기 위해 두번째 정수를 입력 하시오.: ");
            int.TryParse(Console.ReadLine(), out userMaxNumY);
            Console.WriteLine("최대값을 찾기 위해 세번째 정수를 입력 하시오.: ");
            int.TryParse(Console.ReadLine(), out userMaxNumZ);

            MaximumFunction(userMaxNumX, userMaxNumY, userMaxNumZ);

            //정수 최대값
            // ===========================================

            int helloCount = 0;

            Console.WriteLine("출력하고싶은 만큼의 숫자를 입력하시오.: ");
            int.TryParse(Console.ReadLine(),out helloCount);

            SayHello(helloCount);
            // hello 출력
            // ===========================================

            double hypotNumA = 0.0f;
            double hypotNumB = 0.0f;

            
            Console.WriteLine("빗 변이 아닌 첫번째 변의 길이 입력하시오.: ");
            double.TryParse(Console.ReadLine(), out hypotNumA);
            Console.WriteLine("빗 변이 아닌 두번째 변의 길이 입력하시오.: ");
            double.TryParse(Console.ReadLine(), out hypotNumB);

            Hypot(hypotNumA,hypotNumB);
            //빗변의 길이
            // ===========================================

            Prime();
            //소수 출력.. 1의 자리 예외처리

           

            Swap();

        }    //Main()

        static void MaximumFunction(int x, int y, int z)
        {
            int MaxNumber = 0;

            if (x > y && x > z ) //x가 y보다 크고 x가 z보다 크면
            {
                MaxNumber = x;
                
            }
            else if (x <= y && z <= y) //
            {
                MaxNumber = y;
                
            }
            else if (x<z && y<z)
            {
                MaxNumber = z;
                
            }

            Console.WriteLine("최대값은 {0} ", MaxNumber);
        }//3정수 최대값

        static void SayHello(int helloCount) 
        {
            
            for (int i = 0; i < helloCount; i++)
            {
                
            Console.WriteLine("Hello");
            }
            
        }//Hello출력

        static void Hypot(double x, double y)
        {
            if (x > 0.0f && y > 0.0f)
            {
                //루트 (x)2+(y)2
                double hypotNum = 0f;
                hypotNum = Math.Sqrt(x * x + y * y);
                Console.WriteLine("{0:F5}", hypotNum);
            }           
            //직각 삼각형의 두변
        }//빗변

        static void Prime() //()안의 값을 받아서 표현한다.
        {
            for (int i = 0; i < 98+1; i++) 
            {
                int susoo = i + 2;
                if (susoo % 2 == 0 || susoo % 3 == 0 || susoo % 5 == 0|| susoo % 7 == 0)        //제외하는 방법 생각해보기.
                {
                    if (susoo == 2 || susoo == 3 || susoo == 5 || susoo == 7) 
                    {
                        Console.Write("{0} ", susoo);
                    }
                }
                
                else
                {
                    Console.Write("{0} ", susoo);
                }
            }Console.WriteLine();
        }
        //소수 다른 방식 생각해보기.

        //static void PhoneNumber(string sellPhone) 
        //{
        //    string userPhone = string.Empty;

        //    Console.WriteLine("(010)-1234-4567 형식으로 전화번호를 입력하시오.: ");
        //    string.(Console.ReadLine(),out );
        //    //(010)-4545-5454
        //    // 010 -4545-5454
        //}

        static void Swap(string a) 
        {
            char[] arrayString = new char[a.Length];
           

            Console.WriteLine("바꾸기전 문자열을 적으시오.  " );
            a = Convert.ToString(Console.ReadLine());
            

            
           
        }


        











             //static void Swap(int intValue1, int intValue2) 
             //{
             //    Console.WriteLine("바뀌기 전의 값 {0} {1} ", intValue1, intValue2);

        //    int temp; //빈공간
        //    temp = intValue1;           //1번을 빈공간에 남아주고 
        //    intValue1 = intValue2;      //1번에 2번을 넣을려면
        //    intValue2 = temp;

        //    Console.WriteLine("바뀌기 후의 값 {0} {1} ", intValue1, intValue2);


        //}


        /**
            * 함수(Function) 또는 메서드(Method)는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다.
            * 함수를 부르는 다양한 명칭
            * 함수(Function)
            * 메서드(Method)              //class{}안에 있으면 메서드라고 부른다 . 멤버 함수.
            * 프로시저(Procedure)
            * 서브루틴(Subroutine)
            * 서브모듈(Submodule)
            * 
            * 프로그래밍을 하다 보면 같은 유형의 코드를 반복할 때가 많다. 이 코드들을 매번 입력하면 불편하고
            * 입력하다 실수도 할 수 있다. 이때 '함수'를 사용한다.
            * 
            * 프로그래밍 언어에서 함수는 어떤 동작 및 행위를 표현한다. [함수의 사용 목적은 코드 재사용에 있다.]
            * 한번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다.
            * 지금 까지 사용한 Main() 메서드는 C#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
            * 또, Conosole 클래스의 WriteLine() 메서드도 함수로 볼 수 있다.
            * 
            *  - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과값을 반환시켜 주는 코드이다.
            *  - 함수는 프로그램 코드내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
            *  
            *  입력-> 처리 -> 출력
            *  
            *  함수의 종류(내장 함수와 사용자 정의 함수)
            *  함수에는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 C#이 자주 사용하는 기능을 미리 만들어서 
            *  제공하는 함수로, 특정 클래스의 함수로 표현된다.
            *  내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수, 수학 관련 함수, 형식 변환 관련 함수
            *  등으로 나눌 수 있다. 이러한 내장 함수를 API(Application Programming Interface)로 표현한다.
            *  
            *  사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.
            *  
            *  함수 정의하고 사용하기
            *  함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는 작업이다. 함수 생성 및
            *  호출은 반드시 *소괄호*가 들어간다. 함수를 정의하는 형태는 지금까지 사용한 Main() 메서드와 유사하다.
            *  다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
            *  
            *  static void [함수이름]()
            *  {
            *      함수내용
            *  }
            *  
            *  만든 함수를 호출하는 형태는 다음 세 가지가 있다.
            *  [함수이름]():
            *  [함수이름](메개변수);
            *  변수(결과 값) = [함수이름](매개변수);
            * 
            */
        //Show();
        /**
         * 함수를 만들고 반복해서 사용하기
         * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 함수를 만들고 여러 번 호출해서 사용하는 방법을 알아보자.
         */

        //Hi();
        //Hi();
        //Hi();
        //int number = 0;
        /*Console.WriteLine();*/ //내장함수


        /**
              * 이 함수는 가장 간단한 형태의 함수로, 매개변수(Parameter)도 없고 반환값(Return value)도
              * 없는 형태이다.
              * 
              */

        //함수에서 값으 주는걸 매개변수
        //함수에서 값을 받으면 리턴
        //static int Hi() 
        //{
        //    Console.WriteLine("안녕하세요");
        //    /**
        //     * 
        //     */
        //    return  0;
        //}
        ////! 매개변수와 반환값 설명
        //static int Hi(string text)
        //             //()파라미터 
        //{
        //    Console.WriteLine(text);
        //    return 0;
        //}
        //static int ParameterAndReturn() 
        //{
        //    /**
        //     * 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 호출할 때마다 조금씩 다른 기능을 적요할 때는
        //     * 함수의 매개변수를 달리하여 호출할 수 있다. 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를
        //     * 나타낸다. 이러하 매개변수는 콤마를 기준으로 여러 개 설정할 수 있으며, 문자열과 숫자 등 모든 데이터 형식을
        //     * 사용할 수 있다.
        //     * 
        //     * 매개변수(인자, 파라미터)가 없는 함수: 매개변수도 없고,반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
        //     * 앞에서 사용한 함수 중에서 모든 변수에 잇는 값을 문자열로 변환시키는 ToString() 메서드처럼 빈 괄호만 있는
        //     * 함수 형식을 나타낸다.
        //     * 
        //     * 매개변수가 있는 함수: 특정 함수에 인자 값을 1개 이상 전달하는 방식이다. 정수형, 실수형, 문자형, 문자열형,
        //     * 개체형 등 여러 가지 데이터 형식을 인자 값으로 전달할 수 있다.
        //     * 
        //     * 반환값이 있는 함수(결과값이 있는 함수): 함수의 처리 결괄르 함수를 호출한 쪽으로 반환할 때는 return 키워드를
        //     * 사용하여 데이터를 돌려줄 수 있다.
        //     * 
        //     * 매개변수가 가변(여러 개)인 함수: C#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한
        //     * 함수를 여러 개 만들 수 있다. 이를 가리켜 함수 중복 또는 함수 오버로드(Overload)라고 한다.
        //     * 
        //     * 
        //     * 
        //     */
        //    return 0;
        //}
        //static void ShowMessage(string message) 
        //{
        //    Console.WriteLine(message);
        //}

        //static string GetString() 
        //{
        //    return "반환값(Return Value)";
        //}
        //static int SquareFunction(int x) 
        //{
        //    int r = x * x;
        //    return r;
        //}


        //합 함수
        //static int addFunction(int x ,int y) 
        //{

        //    int add = x + y;

        //    return add;
        //}

        ////최댓값
        //static int MaxFunction(int x, int y)
        //{
        //    if (x >= y)
        //    {
        //        int Max = x;
        //        return x;
        //    }
        //    else 
        //    {
        //        int Max = y;
        //        return y;
        //    }                 

        //}
        ////최소값
        //static int MinFunction(int x, int y) 
        //{
        //    if (x <= y)
        //    {
        //        int Min = x;
        //        return x;
        //    }
        //    else 
        //    {
        //        int Min = y;
        //        return y;
        //    }
        //}

        ////절대값
        //static int AbsoluteValueFunction(int x) 
        //{
        //    if (x >= 0) 
        //    {
        //        int AbsVal = x;
        //        return AbsVal;
        //    }
        //    else 
        //    {
        //        int AbsVal = -x;
        //        return AbsVal;
        //    }

        //}

        //static void Functionoverloading() 
        //{
        //    /**
        //     * 함수 오버로드: 다중 정의이
        //     * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의할 수 있는데, 이를 함수 오버로드라고
        //     * 한다. 우리말로는 여러 번 정의라한다는 의미이다.
        //     */

        //}

        ////! 숫자를 받아서 출력하는 함수
        ///**
        // * @param number int type nubmer for print      
        // */
        //static void Getnumber(int number) 
        //{
        //    Console.WriteLine($"Int32: {number}");
        //    Console.WriteLine($"4바이트 정수: {number}");
        //}

        ///**
        // * @param number long type nubmer for print
        // */
        //static void GetNumber(long number)
        //{
        //    Console.WriteLine($"Int64: {number}");
        //    Console.WriteLine($"8바이트 정수: {number}");
        //}

        //static void Multi() 
        //{
        //    Console.WriteLine("안녕하세요. ");

        //}
        //static void Multi(string message) 
        //{
        //    Console.WriteLine(message);
        //}
        //static void Multi(string message, int count) 
        //{
        //    for (int i = 0; i < count; i++) 
        //    {
        //        Console.WriteLine("{0} ", message);
        //    }
        //}

        //static void RecursionFunction() 
        //{
        //    /**
        //     * 재귀 함수
        //     * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion) 또는 재귀 함수라고 한다. 
        //     */   
        //    //연산이 무거워서 잘 쓰지 못함.
        //}

        //static int Factorial(int number) 
        //{
        //    //여기서 탈출할 것임.
        //    if (number == 0 || number == 1) 
        //    {
        //        return 1;
        //    }

        //    Console.WriteLine("n의 값은 {0}", number);

        //    return number * Factorial(number - 1);//여기서 스스로 호출해서 재귀
        //}


        //static void FuntctionScope() 
        //{
        //    /**
        //     * 함수 범위: 전역 변수와 지역 변수
        //     * 클래스와 같은 레벨에서 선언된 변수를 전역 변수(Global Variable) 또는 필드(Field)라고 하며,
        //     * 함수 레벨에서 선언된 변수를 지역 변수(Local Variable) 라고 한다. 이때 동일한 이름으로 변수를
        //     * 전역 변수와 함수 내의 지역 변수로 선언할 수 있다. 함수 내에서는 함수 범위에 잇는 지역 변수를 사용하고,
        //     * 함수 범위 내에 선언된 변수가 없으면 전역 변수 내에 선언된 변수를 사용한다.
        //     * 단, C#에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 언더스코어 (_) 또는 m_ 접두사를
        //     * 붙이는 경향이 있다.
        //     */
        //}
        //static void ArrowFunction() 
        //{
        //    /**
        //     * 화살표 함수
        //     * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용하여 메서드 코드를 줄일 수 있다. 이를 화살표 함수
        //     * (Arrow Function)라고 한다. 프로그래밍에서 화살표 함수 또는 화살표 메서드는 람다 식(Lambda expression)의
        //     * 또다른 이름이다.
        //     * 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있다.
        //     * 하지만 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다.
        //     */
        //}
        //static void Hi() => Console.WriteLine("안녕하세요");
        //// => 람다형

        //static void Multiply(int a, int b) => Console.WriteLine(a * b);
        
    }       //class
}
