using System;
//System에서 저장된 값을 다
namespace AddOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //System.Console.WriteLine("Hello, World!");
            //        //Line 줄바꿈
            //System.Console.Write("Hello, World2!");
            ////Write 줄띄움 없이 붙여씀.

            //Console.WriteLine("내 이름은 \"박재우\"  입니다.");
            //Console.WriteLine("내이름은\t박재우\t 입니다.");
            ////  이스케이프 시퀀스\ 역슬래쉬
            //Console.WriteLine("여기까진그냥적고\r게임할시간이");
            //// \r은 \r이 시작하는 부분이 제일 앞으로 가서 새로 덮어씌우면서 적음.
            //Console.WriteLine("다음\n줄로 \n가요!\n");

            //Console.WriteLine("다음 줄로 가요");
            //Console.WriteLine("다음 {0} 가요 {1}", "줄로", 11);
            //                //자리표시자 {0} 는 그다음 ,내용이 들어간다.
            //                //{0} {1} ...{n]는 {0} , 첫번째 {1} ,,두번째  ...{n}은 ,,,n번쨰



            //들여쓰기 {}정리
            //Console.WriteLine("나이 {0} 이름 {1}  성별 {2}", 28, "박재우", "남자");
            //Console.WriteLine("저도 \" 준비\" 되었습니다.");

            //변하는 수 변수. 값을 주기 전에 공간을 만들어줘야함

            ////정수형을 저장 시키고 싶다.
            //int intBox;
            //int box2;
            ////int를 적으면 int형 박스를 준비하고 그박스의 이름이 intBox라고 지어줌.
            ////정수형 4를 저장하고 싶다.
            //intBox = 4;
            //box2 = 5;

            //int asdf = 5;
            //int형 asdf함수에 5의 값을 바로 할당. 즉 초기화.

            //int age;
            //age = 13;

            //age = 14;
            ////age는 13이 였다가 14로 덮혀씌워져서 13이라는 값은 사라짐.

            //int age = 14;
            //age = 15;

            //const int PhoneNumber = 010;
            //PhoneNumber = 011;
            //const float PI = 3.14f;

            //const 상수화 시키면 바꿀수 없기에 바뀌면 안될것에  const화 시키면 편하다.

            //short shortNum = 11111;
            //int intNum = 32769;
            //shortNum = (short)intNum;
            ////()소괄호 변수로 명시적 형식 변환 가능.
            ////형을 강제로 바꾸는걸 캐스팅이라고 한다.

            //short shNum = 456;
            //float floatNum = 15.596f;


            //shNum = (short)floatNum;
            //Console.WriteLine(shNum);
            ////int 정수 -2-1 0 1 2 등등 크기가 작다.
            ////float -2.1f -1.509f 0.0f 1.0983f, 2.098f 등등
            ////double
            ////변수의 크기는 정해져있어서 담을수 있는 자료형을 잘 검색하거나 생각해서 쓰기.

            //bool isTrue;
            //isTrue = false;

            ////bool형은 참과 거짓밖에 담지 못한다.
            ////bool

            //Console.WriteLine("긴문자열");
            //string 문자열 = "긴문자열";        
            //char 캐릭터형 = 'a';    //한가지 문자.

            //연산자 compute
            int firstNum = 8;
            int secondNum = 3;




            firstNum = (firstNum + secondNum);
            Console.WriteLine(firstNum);
            firstNum = (firstNum - secondNum);
            Console.WriteLine(firstNum);
            firstNum = (firstNum * secondNum);
            Console.WriteLine(firstNum);
            firstNum = (firstNum / secondNum);
            Console.WriteLine(firstNum);

            firstNum = (firstNum % secondNum);
            Console.WriteLine(firstNum);
            //컴퓨터는 왼쪽에서 오른쪽 위에서 아래로 읽음

            //연산자 %는 나누고 나머지 값을 낼때 씀.
            // % == % != 등등 나머지 같을때 뭐하고 나머지가 아닐때 멀하고 조건이나 참거짓을 걸수있다.



        }
    }
}

